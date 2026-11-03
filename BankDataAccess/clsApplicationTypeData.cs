using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace BankDataAccess
{
    public static class clsApplicationTypeData
    {
        public static bool GetApplicationTypeByID(byte ApplicationTypeID,ref string ApplicationName,ref float ApplicationFees)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetApplicationTypeByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                ApplicationName = (string)reader["ApplicationName"];
                                ApplicationFees = Convert.ToSingle(reader["ApplicationFees"]);
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

        public static bool UpdateApplicationType(byte ApplicationTypeID,string ApplicationName,float ApplicationFees)
        {
            bool isUpdated = false;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using(SqlCommand command = new SqlCommand("SP_UpdateApplicationType", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ApplicationName", ApplicationName);
                    command.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);
                    command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

                    try
                    {
                        connection.Open();
                        isUpdated = command.ExecuteNonQuery() > 0;
                    }
                    catch (Exception)
                    {

                    }
                }
            }



            return isUpdated;
        }

        public static DataTable GetAllData()
        {
            DataTable dtAllData = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetAllApplicationType", connection))
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
