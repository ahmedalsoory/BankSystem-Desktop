using System;
using System.Data;
using System.Data.SqlClient;
namespace BankDataAccess
{
    public static class clsAccountTransactionTypeData
    {
        public static bool GetAccountTransactionTypeByID(byte AccountTransactionTypeID,ref string TypeName,ref float Fees)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetAccountTransactionTypeByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@AccountTransactionTypeID", AccountTransactionTypeID);

                    try
                    {
                        connection.Open();
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                TypeName = (string)reader["TypeName"];
                                Fees = Convert.ToSingle(reader["Fees"]);
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

        public static bool UpdateAccountTransactionType(byte AccountTransactionTypeID, string TypeName, float Fees)
        {
            bool isUpdated = false;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_UpdateAccountTransactionType", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@TypeName", TypeName);
                    command.Parameters.AddWithValue("@Fees", Fees);
                    command.Parameters.AddWithValue("@AccountTransactionTypeID", AccountTransactionTypeID);

                    try
                    {
                        connection.Open();
                        isUpdated = command.ExecuteNonQuery() > 0;
                    }
                    catch(Exception ex)
                    {

                    }
                }
            }




            return isUpdated;
        }

        public static DataTable GetAllData()
        {
            DataTable dtAllData = new DataTable();

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using(SqlCommand command = new SqlCommand("SP_GetAllAccountTransactionType", connection))
                {
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
    }
}
