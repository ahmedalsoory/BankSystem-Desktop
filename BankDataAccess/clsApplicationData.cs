using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace BankDataAccess
{
    public static class clsApplicationData
    {
        public static bool GetApplicationByID(int ApplicationID,ref DateTime ApplicationDate,ref int ClientID,ref int CreatedByUserID,
            ref float AppliactionFees, ref byte ApplicationTypeID,ref byte ApplicationStatus)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
             

                using(SqlCommand command = new SqlCommand("SP_GetAppliactionByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ApplicationID", ApplicationID);                    
                    try
                    {
                        connection.Open();
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                ApplicationDate = (DateTime)reader["ApplicationDate"];
                                ClientID = (int)reader["ClientID"];
                                CreatedByUserID = (int)reader["CreatedByUserID"];
                                ApplicationTypeID = Convert.ToByte(reader["ApplicationTypeID"]);
                                AppliactionFees = Convert.ToSingle(reader["AppliactionFees"]);
                                ApplicationStatus = Convert.ToByte(reader["ApplicationStatus"]);

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

        public static int AddNewApplication(int ClientID,int CreatedByUserID,byte ApplicationTypeID)
        {
            int ApplicationID = -1;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
             

                using (SqlCommand command = new SqlCommand("SP_AddNewAppliaction", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                 
                    command.Parameters.AddWithValue("@ClientID", ClientID);
                    command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                    command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

                 

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int ID))
                            ApplicationID = ID;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                
            }



            return ApplicationID;
        }

    
        public static bool DeleteApplication(int ApplicationID)
        {
            bool isDeleted = false;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"DELETE FROM [dbo].[Applications]
                                 WHERE ApplicationID=@ApplicationID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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

                using (SqlCommand command = new SqlCommand("SP_GetAllApplications", connection))
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
        public static bool ConvertApplicationStatus(int ApplicationID, byte ApplicationStatus)
        {
            bool isUpdated = false;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
            
                using (SqlCommand command = new SqlCommand("SP_ConvertApplicationStatus", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
                    command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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
        public static bool IsApplicationExist(int ApplicationID)
        {
            bool isFound = false;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using(SqlCommand command = new SqlCommand("SP_IsApplicationExist", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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
        
    }
}
