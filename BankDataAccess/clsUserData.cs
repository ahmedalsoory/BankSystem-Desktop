using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BankDataAccess
{
    public static class clsUserData
    {


        //this not worked yet
        public static bool GetDeleteUserByID(int UserID, ref string Username, ref string Password, ref bool IsActive,
          ref int EmployeeID, ref int PermissionsID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"select * from Users
                                 where UserID=@UserID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", UserID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                Username = (string)reader["Username"];
                                Password = (string)reader["Password"];
                                IsActive = (bool)reader["IsActive"];
                                EmployeeID = (int)reader["EmployeeID"];
                                PermissionsID = (int)reader["PermissionsID"];
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
        //
        public static bool GetUserByID(int UserID,ref string Username,ref string Password,ref bool IsActive,
            ref int EmployeeID,ref int PermissionsID)
        {
            bool isFound = false;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetUserByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserID", UserID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                Username = (string)reader["Username"];
                                Password = (string)reader["Password"];
                                IsActive = (bool)reader["IsActive"];
                                EmployeeID = (int)reader["EmployeeID"];
                                PermissionsID = (int)reader["PermissionsID"];
                            }
                        }
                    }
                    catch(Exception)
                    {

                    }
                }
            }



            return isFound;
        }
        public static bool GetUserByUsernameAndPassword(string Username,string Password,ref int UserID,ref bool IsActive,
           ref int EmployeeID, ref int PermissionsID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
      

                using (SqlCommand command = new SqlCommand("SP_GetUserByUsernameAndPassword", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Username", Username);
                    command.Parameters.AddWithValue("@Password", Password);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                UserID = (int)reader["UserID"];
                                IsActive = (bool)reader["IsActive"];
                                EmployeeID = (int)reader["EmployeeID"];
                                PermissionsID = (int)reader["PermissionsID"];
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
        public static bool GetUserByEmployeeID(int EmployeeID, ref int UserID, ref string Username, ref string Password, 
            ref bool IsActive,ref int PermissionsID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_GetUserByEmployeeID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@EmployeeID", EmployeeID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                Username = (string)reader["Username"];
                                Password = (string)reader["Password"];
                                IsActive = (bool)reader["IsActive"];
                                UserID = (int)reader["UserID"];
                                PermissionsID = (int)reader["PermissionsID"];
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
        public static int AddNewUser(string Username,string Password,bool IsActive,int EmployeeID,int PermissionsID)
        {
            int UserID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_AddNewUser", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Username", Username);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@IsActive", IsActive);
                    command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                    command.Parameters.AddWithValue("@PermissionsID", PermissionsID);

     

                    try
                    {
                        connection.Open();
                        
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int ID))
                            UserID = ID;
                    }
                    catch(Exception ex)
                    {

                    }
                }

            }



            return UserID;
        }

        public static bool UpdateUser(int UserID,string Username, string Password, bool IsActive)
        {
            bool isUpdated = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
          
                using (SqlCommand command = new SqlCommand("SP_UpdateUser", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserID", UserID);
                    command.Parameters.AddWithValue("@Username", Username);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.Parameters.AddWithValue("@IsActive", IsActive);
                 

                    try
                    {
                        connection.Open();
                        isUpdated = command.ExecuteNonQuery() > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show( ex.Message.ToString());
                    }
                }

            }



            return isUpdated;
        }
        
        public static bool MarkForDeleted(int UserID)
        {
            bool isDeleted = false;
            string Username = Guid.NewGuid().ToString();
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command  = new SqlCommand("SP_MarkForDeleted", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserID", UserID);
                    command.Parameters.AddWithValue("@Username", Username);
                    try
                    {
                        connection.Open();
                        isDeleted = command.ExecuteNonQuery() > 0;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }


            return isDeleted;
        }

        public static bool ChangePassword(int UserID,string NewPassword)
        {
            bool isSucceed = false;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                
                using (SqlCommand command = new SqlCommand("SP_ChangePassword", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@NewPassword", NewPassword);
                    command.Parameters.AddWithValue("@UserID", UserID);

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


        public static DataTable GetAllData()
        {
            DataTable dtAllData = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_GetAllUser", connection))
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

        public static bool isUserExistByID(int UserID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
              

                using (SqlCommand command = new SqlCommand("SP_isUserExistByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@UserID", UserID);

                    try
                    {
                        connection.Open();
                        isFound = command.ExecuteReader().HasRows;
                    }
                    catch(Exception)
                    {

                    }
                }
            }


            return isFound;
        }
        public static bool isUserExistByEmployeeID(int EmployeeID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
    
                using (SqlCommand command = new SqlCommand("SP_isUserExistByEmployeeID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@EmployeeID", EmployeeID);

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
        public static bool isUserExistByUsername(string Username)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_isUserExistByUsername", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Username", Username);

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
