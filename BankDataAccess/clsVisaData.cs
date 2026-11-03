using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace BankDataAccess
{
    public static class clsVisaData
    {
        public static bool GetVisaByID(int VisaID,ref string VisaNumber,ref string Password,ref byte Lenght,
            ref DateTime IssueDate,ref DateTime ExpiryDate,ref int AppliactionID,ref int ClientID,ref bool IsActive)
        {
            bool isFound = false;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using(SqlCommand command = new SqlCommand("SP_GetVisaByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@VisaID", VisaID);
                    try
                    {
                        connection.Open();
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                VisaNumber = (string)reader["VisaNumber"];
                                Password = (string)reader["Password"];
                                Lenght = Convert.ToByte(reader["Length"]);
                                IssueDate = (DateTime)reader["IssueDate"];
                                ExpiryDate = (DateTime)reader["ExpiryDate"];
                                AppliactionID = (int)reader["AppliactionID"];
                                ClientID = (int)reader["ClientID"];
                                IsActive = (bool)reader["IsActive"];
                                isFound = true;

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
        public static bool GetVisaByClientID(int ClientID,ref int VisaID, ref string VisaNumber, ref string Password, ref byte Lenght,
         ref DateTime IssueDate, ref DateTime ExpiryDate, ref int AppliactionID, ref bool IsActive)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetVisaByClientID", connection))
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
                                VisaNumber = (string)reader["VisaNumber"];
                                Password = (string)reader["Password"];
                                Lenght = Convert.ToByte(reader["Length"]);
                                IssueDate = (DateTime)reader["IssueDate"];
                                ExpiryDate = (DateTime)reader["ExpiryDate"];
                                AppliactionID = (int)reader["AppliactionID"];
                                VisaID = (int)reader["VisaID"];
                                IsActive = (bool)reader["IsActive"];

                            }
                        }
                    }
                    catch (Exception ex)
                    {
                      
                    }
                }

            }


            return isFound;
        }
        public static int AddNewVisa(string VisaNumber,string Password,byte Length, int AppliactionID,int ClientID)
        {
            int VisaID = -1;
            
            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using(SqlCommand command = new SqlCommand("SP_AddNewVisa", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@VisaNumber", VisaNumber);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@Length", Length);
                    command.Parameters.AddWithValue("@ExpiryDate", DateTime.Now.AddYears(10));
                    command.Parameters.AddWithValue("@AppliactionID", AppliactionID);
                    command.Parameters.AddWithValue("@ClientID", ClientID);


                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int ID))
                            VisaID = ID;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                

            }



            return VisaID;
        }

        public static DataTable GetAllData()
        {
            DataTable dtAllData = new DataTable();

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                
                using(SqlCommand command = new SqlCommand("SP_GetAllVisa", connection))
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

        public static bool IsExist(string VisaNumber)
        {
            bool isFound = false;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_IsVisaExistByVisaNumber", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
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
        public static bool IsExist(int VisaID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_IsVisaExistByID", connection))
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
        public static bool UnActive(int VisaID)
        {
            bool isSucceed = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_VisaUnActive", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@VisaID", VisaID);
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
