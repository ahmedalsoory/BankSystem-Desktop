using System;
using System.Data;
using System.Data.SqlClient;

namespace BankDataAccess
{
    public static class clsBankAccountData
    {
        public static bool GetAccountByID(int BankAccountID,ref string AccountNumber,ref float Amount,ref bool IsActive,
            ref string PinCode,ref int ApplicationID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetAccountByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@BankAccountID", BankAccountID);
                    
                    try
                    {
                        connection.Open();
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                AccountNumber = (string)reader["AccountNumber"];
                                Amount = Convert.ToSingle(reader["Amount"]);
                                IsActive = Convert.ToBoolean(reader["IsActive"]);
                                PinCode = (string)reader["PinCode"];
                                ApplicationID = (int)reader["ApplicationID"];
                            }
                        }
                    }
                    catch (Exception)
                    {

                    }
                }

            }



                return isFound;
        }

        public static bool GetAccountByAccountNumber(string AccountNumber,ref int BankAccountID, ref float Amount, ref bool IsActive,
            ref string PinCode, ref int ApplicationID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
             

                using (SqlCommand command = new SqlCommand("SP_GetAccountByAccountNumber", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                BankAccountID = (int)reader["BankAccountID"];
                                Amount = Convert.ToSingle(reader["Amount"]);
                                IsActive = Convert.ToBoolean(reader["IsActive"]);
                                PinCode = (string)reader["PinCode"];
                                ApplicationID = (int)reader["ApplicationID"];
                            }
                        }
                    }
                    catch (Exception)
                    {

                    }
                }

            }



            return isFound;
        }

        
        public static int AddNewBankAccount(string AccountNumber, float Amount,bool IsActive,string PinCode,int ApplicationID)
        {
            int BankAccountID = -1;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
        
                using(SqlCommand command = new SqlCommand("SP_AddNewBankAccount", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;   
                    command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
                    command.Parameters.AddWithValue("@Amount", Amount);

                    command.Parameters.AddWithValue("@PinCode", PinCode);
                    command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int ID))
                            BankAccountID = ID;
                    }
                    catch (Exception)
                    {

                    }
                }
            }
            return BankAccountID;
        }


        // this is not work yet
        public static bool UpdateBankAccount(int BankAccountID,string AccountNumber,float Amount,bool IsActive,string PinCode,
            int ApplicationID)
        {
            bool IsUpdated = false;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"UPDATE [dbo].[BankAccounts]
                                 SET [AccountNumber] = @AccountNumber
                                    ,[Amount] = @Amount
                                    ,[IsActive] = @IsActive
                                    ,[PinCode] = @PinCode
                                    ,[ApplicationID] = @ApplicationID
                                 WHERE BankAccountID=@BankAccountID";

                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
                    command.Parameters.AddWithValue("@Amount", Amount);
                    command.Parameters.AddWithValue("@IsActive", IsActive);
                    command.Parameters.AddWithValue("@PinCode", PinCode);
                    command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
                    command.Parameters.AddWithValue("@BankAccountID", BankAccountID);

                    try
                    {
                        connection.Open();
                        IsUpdated = command.ExecuteNonQuery() > 0;
                    }
                    catch (Exception)
                    {

                    }


                }

            }



            return IsUpdated;
        }
        //
        public static DataTable GetAllData()
        {
            DataTable dtAllData = new DataTable();

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using(SqlCommand command = new SqlCommand("SP_GetAllBankAccount", connection))  
                {
                    command.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        connection.Open();
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dtAllData.Load(reader);
                        }
                    }
                    catch (Exception)
                    {

                    }
                }
            }


            return dtAllData;
        }
        public static bool IsExist(string AccountNumber)
        {
            bool isExist = false;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using(SqlCommand command = new SqlCommand("SP_IsExistAccountNumber", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

                    try
                    {
                        connection.Open();
                        isExist = command.ExecuteReader().HasRows;
                    }
                    catch (Exception)
                    {

                    }
                    

                }

            }



            return isExist;
        }
        public static bool IsExist(int BankAccountID)
        {
            bool isExist = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_IsExistBankAccountID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@BankAccountID", BankAccountID);

                    try
                    {
                        connection.Open();
                        isExist = command.ExecuteReader().HasRows;
                    }
                    catch (Exception)
                    {

                    }


                }

            }



            return isExist;
        }

    }
}
