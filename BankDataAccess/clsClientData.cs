using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace BankDataAccess
{
    public static class clsClientData
    {
        public static bool GetClientByID(int ClientID,ref int PersonID,ref int UserID,ref int? BankAccountID)
        {
            bool isFound = false;

            using (SqlConnection connection =new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetClientByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ClientID", ClientID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                PersonID = (int)reader["PersonID"];
                                UserID = (int)reader["UserID"];
                                if (reader["BankAcountID"] != DBNull.Value)
                                    BankAccountID = (int)reader["BankAcountID"];

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
        public static bool GetClientByNationalNumber(string NationalNumber, ref int ClientID, ref int PersonID, 
            ref int UserID, ref int? BankAccountID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetClientByNationalNumber", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@NationalNumber", NationalNumber);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                PersonID = (int)reader["PersonID"];
                                ClientID = (int)reader["ClientID"];
                                UserID = (int)reader["UserID"];
                                if (reader["BankAcountID"] != DBNull.Value)
                                    BankAccountID = (int)reader["BankAcountID"];

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
        public static bool GetClientByPersonID(int PersonID, ref int ClientID , ref int UserID, ref int? BankAccountID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
               
                using (SqlCommand command = new SqlCommand("SP_GetClientByPersonID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PersonID", PersonID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                ClientID = (int)reader["ClientID"];
                                UserID = (int)reader["UserID"];
                                if (reader["BankAcountID"] != DBNull.Value)
                                    BankAccountID = (int)reader["BankAcountID"];

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

        public static bool GetClientByBankAccountID(int BankAccountID, ref int ClientID, ref int PersonID, ref int UserID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {


                using (SqlCommand command = new SqlCommand("SP_GetClientByBankAccountID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@BankAcountID", BankAccountID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                PersonID = (int)reader["PersonID"];
                                UserID = (int)reader["UserID"];
                                ClientID = (int)reader["ClientID"];

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }


            return isFound;
        }

        public static bool GetClientByAccountNumber(string AccountNumber,ref int ClientID, ref int PersonID, ref int UserID, 
            ref int? BankAccountID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
          
                using (SqlCommand command = new SqlCommand("SP_GetClientByAccountNumber", connection))
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
                                ClientID = (int)reader["ClientID"];
                                PersonID = (int)reader["PersonID"];
                                UserID = (int)reader["UserID"];
                                if (reader["BankAcountID"] != DBNull.Value)
                                    BankAccountID = (int)reader["BankAcountID"];

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

        public static bool GetClientByVisaID(int VisaID, ref int ClientID, ref int PersonID, ref int UserID,
            ref int? BankAccountID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_GetClientByVisaID", connection))
                {
                    command.Parameters.AddWithValue("@VisaID", VisaID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                ClientID = (int)reader["ClientID"];
                                PersonID = (int)reader["PersonID"];
                                UserID = (int)reader["UserID"];
                                if (reader["BankAcountID"] != DBNull.Value)
                                    BankAccountID = (int)reader["BankAcountID"];

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
        public static bool GetClientByVisaNumber(string VisaNumber, ref int ClientID, ref int PersonID, ref int UserID,
        ref int? BankAccountID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetClientByVisaNumber", connection))
                {
                    command.Parameters.AddWithValue("@VisaNumber", VisaNumber);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                ClientID = (int)reader["ClientID"];
                                PersonID = (int)reader["PersonID"];
                                UserID = (int)reader["UserID"];
                                if (reader["BankAcountID"] != DBNull.Value)
                                    BankAccountID = (int)reader["BankAcountID"];

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
        public static int AddNewClient(int PersonID, int UserID)
        {
            int ClientID = -1;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_AddNewClient", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    command.Parameters.AddWithValue("@UserID", UserID);

                    SqlParameter parameter = new SqlParameter("@ClientID", SqlDbType.Int);
                    parameter.Direction = ParameterDirection.Output;
                    command.Parameters.Add(parameter);


                    try
                    {
                        connection.Open();

                        if (command.ExecuteNonQuery() > 0 && int.TryParse(parameter.Value.ToString(), out int ID))
                            ClientID = ID;
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }


            }


            return ClientID;
        }

        public static bool DeleteClient(int ClientID)
        {
            bool isDeleted = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_DeleteClient", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ClientID", ClientID);

                    try
                    {
                        connection.Open();
                        isDeleted = command.ExecuteNonQuery() > 0;
                    }
                    catch(Exception)
                    {

                    }
                }

            }


            return isDeleted;
        }

        public static DataTable GetAllData()
        {
            DataTable dtAllData = new DataTable();

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
             
                using (SqlCommand command = new SqlCommand("SP_GetAllClient", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
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
        public static bool isExistByID(int ClientID)
        {
            bool isFound = false;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_isClientExistByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ClientID", ClientID);
                    try
                    {
                        connection.Open();
                        isFound = command.ExecuteReader().HasRows;
                    }
                    catch (Exception)
                    {

                    }
                }

            }


            return isFound;
        }
        public static bool isExistByPersonID(int PersonID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
              
                using (SqlCommand command = new SqlCommand("SP_isClientExistByPersonID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PersonID", PersonID);

                    try
                    {
                        connection.Open();
                        isFound = command.ExecuteReader().HasRows;
                    }
                    catch (Exception)
                    {

                    }
                }

            }


            return isFound;
        }
        public static bool isExistByNationalNumber(string NationalNumber)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_isClientExistByNationalNumber", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@NationalNumber", NationalNumber);

                    try
                    {
                        connection.Open();
                        isFound = command.ExecuteReader().HasRows;
                    }
                    catch (Exception)
                    {

                    }
                }

            }


            return isFound;
        }
        public static bool isExistByAccountNumber(string AccountNumber)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_isClientExistByAccountNumber", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

                    try
                    {
                        connection.Open();
                        isFound = command.ExecuteReader().HasRows;
                    }
                    catch (Exception)
                    {

                    }
                }

            }


            return isFound;
        }
        public static bool isExistByBankAcountID(int BankAcountID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_isClientExistByBankAcountID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@BankAcountID", BankAcountID);

                    try
                    {
                        connection.Open();
                        isFound = command.ExecuteReader().HasRows;
                    }
                    catch (Exception)
                    {

                    }
                }

            }


            return isFound;
        }
        public static bool isClientHasBankAccount(int ClientID)
        {
            bool has = false;

            using (SqlConnection connection =new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using(SqlCommand command = new SqlCommand("SP_isClientHasBankAccount", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ClientID", ClientID);

                    try
                    {
                        connection.Open();
                        has = command.ExecuteReader().HasRows;
                    }
                    catch (Exception)
                    {

                    }
                }
            }




            return has;
        }
        public static bool isExistByVisaID(int VisaID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_isClientExistByVisaID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@VisaID", VisaID);

                    try
                    {
                        connection.Open();
                        isFound = command.ExecuteReader().HasRows;
                    }
                    catch (Exception)
                    {

                    }
                }

            }


            return isFound;
        }
        public static bool isExistByVisaNumber(string VisaNumber)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
               

                using (SqlCommand command = new SqlCommand("SP_isClientExistByVisaNumber", connection))
                {
                    command.Parameters.AddWithValue("@VisaNumber", VisaNumber);

                    try
                    {
                        connection.Open();
                        isFound = command.ExecuteReader().HasRows;
                    }
                    catch (Exception)
                    {

                    }
                }

            }


            return isFound;
        }
        public static bool OpenBankAccount(int ClientID,int BankAccountID)
        {
            bool isSuccess = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"UPDATE [dbo].[Clients]
                                 SET [BankAcountID] = @BankAccountID
                                 WHERE ClientID=@ClientID";

                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BankAccountID", BankAccountID);
                    command.Parameters.AddWithValue("@ClientID", ClientID);

                    try
                    {
                        connection.Open();
                        isSuccess = command.ExecuteNonQuery()>0;
                    }
                    catch (Exception)
                    {

                    }
                }
            }




            return isSuccess;
        }
        
        public static bool IsClientHasVisa(int ClientID)
        {
            bool heHas = false;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"SELECT FOUND=1 FROM Visa
                                 WHERE ClientID=@ClientID";

                using(SqlCommand command = new SqlCommand(query,connection))
                {
                    command.Parameters.AddWithValue("@ClientID", ClientID);

                    try
                    {
                        connection.Open();
                        heHas = command.ExecuteReader().HasRows;
                    }
                    catch (Exception)
                    {

                    }
                }
            }


            return heHas;


        }

        public static bool Deposit(int BankAcountID,float Amount)
        {
            bool isSucceed = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"UPDATE [dbo].[BankAccounts]
                                 SET [Amount] = Amount+@Amount
                                 WHERE BankAccountID=@BankAcountID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BankAcountID", BankAcountID);
                    command.Parameters.AddWithValue("@Amount", Amount);

                    try
                    {
                        connection.Open();
                        isSucceed = command.ExecuteNonQuery() > 0;
                    }
                    catch (Exception)
                    {

                    }

                }
            }



            return isSucceed;
        }
    }
}
