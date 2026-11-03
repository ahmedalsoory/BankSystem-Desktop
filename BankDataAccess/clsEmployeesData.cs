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
    public static class clsEmployeesData
    {
        public static bool GetEmployeeByID(int EmployeeID,ref float Salary,ref string WorkType,ref int PersonID,ref int UserID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetEmployeeByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                    try
                    {
                        connection.Open();
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Salary = Convert.ToSingle(reader["Salary"]);
                                WorkType = (string)reader["WorkType"];
                                PersonID = (int)reader["PersonID"];
                                UserID = (int)reader["UserID"];
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
        public static bool GetEmployeeByPersonID(int PersonID, ref int EmployeeID, ref float Salary, ref string WorkType,ref int UserID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetEmployeeByPersonID", connection))
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
                                Salary = Convert.ToSingle(reader["Salary"]);
                                WorkType = (string)reader["WorkType"];
                                EmployeeID = (int)reader["EmployeeID"];
                                UserID = (int)reader["UserID"];
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
        public static bool GetEmployeeByNationalNumber( string NationalNumber, ref int EmployeeID, ref float Salary, ref string WorkType,ref int PersonID,
            ref int UserID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetEmployeeByNationalNumber", connection))
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
                                Salary = Convert.ToSingle(reader["Salary"]);
                                WorkType = (string)reader["WorkType"];
                                EmployeeID = (int)reader["EmployeeID"];
                                UserID = (int)reader["UserID"];
                                PersonID = (int)reader["PersonID"];
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
        public static int AddNewEmployee(float Salary,string WorkType,int PersonID, int UserID)
        {
            int EmployeeID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
       
                 using (SqlCommand command = new SqlCommand("SP_AddNewEmployee", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Salary", Salary);
                    command.Parameters.AddWithValue("@WorkType", WorkType);
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    command.Parameters.AddWithValue("@UserID", UserID);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int ID))
                            EmployeeID = ID;
                    }
                    catch (Exception)
                    {
                       
                    }

                }

                }



            return EmployeeID;
        }

        public static bool UpdateEmployee(int EmployeeID, float Salary, string WorkType)
        {
            bool isUpdated = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
  

                using (SqlCommand command = new SqlCommand("SP_UpdateEmployee", connection))
                {
                    command.CommandType= CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                    command.Parameters.AddWithValue("@Salary", Salary);
                    command.Parameters.AddWithValue("@WorkType", WorkType);
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

        public static bool DeleteEmployee(int EmployeeID)
        {
            bool isDeleted = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
              
                using (SqlCommand command = new SqlCommand("SP_DeleteEmployee", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@EmployeeID", EmployeeID);
                    try
                    {
                        connection.Open();
                        isDeleted = command.ExecuteNonQuery() > 0;
                    }
                    catch (Exception)
                    {

                    }
                }
            }



            return isDeleted;
        }

        public static DataTable GetAllEmployees()
        {
            DataTable dtAllEmployees = new DataTable();

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
  
                using(SqlCommand command = new SqlCommand("SP_GetAllEmployees", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader= command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dtAllEmployees.Load(reader);
                        }
                    }
                    catch (Exception)
                    {

                    }
                }
            }


            return dtAllEmployees;
        }

        public static bool IsEmployeeExist(int EmployeeID)
        {
            bool isFound = false;
            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using(SqlCommand command = new SqlCommand("SP_IsEmployeeExist", connection))
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
        public static bool IsEmployeeExistByPersonID(int PersonID)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_IsEmployeeExistByPersonID", connection))
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


        //this not worked yet
        public static bool MarkForDeleted(int EmployeeID)
        {
            bool isDeleted = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"UPDATE [dbo].[Employees]
                                 SET [MarkForDeleted] = 1
                                 WHERE EmployeeID=@EmployeeID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EmployeeID", EmployeeID);

                    try
                    {
                        connection.Open();
                        isDeleted = command.ExecuteNonQuery() > 0;
                    }
                    catch (Exception)
                    {

                    }
                }
            }


            return isDeleted;
        }

    }
}
