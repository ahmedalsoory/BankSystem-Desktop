using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BankDataAccess
{
    public static class clsPeopleData
    {

        public static bool GetPersonByID(int PersonID,ref string NationalNumber,ref string FirstName,ref string SecondName,ref string ThirdName
           ,ref string LastName,ref string Phone,ref DateTime DateOfBirth,ref byte Gendor)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
          
                using (SqlCommand command = new SqlCommand("SP_GetPersonByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    try
                    {
                        connection.Open();
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                NationalNumber = (string)reader["NationalNumber"];
                                FirstName = (string)reader["FirstName"];
                                SecondName = (string)reader["SecondName"];
                                ThirdName = (string)reader["ThirdName"];
                                LastName = (string)reader["LastName"];
                                Phone = (string)reader["Phone"];
                                DateOfBirth = (DateTime)reader["DateOfBirth"];
                                Gendor = Convert.ToByte( reader["Gendor"]);

                                isFound = true;


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
        public static bool GetPersonByNationalNumber(string NationalNumber,ref int PersonID, ref string FirstName, ref string SecondName, ref string ThirdName
         , ref string LastName, ref string Phone, ref DateTime DateOfBirth, ref byte Gendor)
        {
            bool isFound = false;
            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                //string query = @"Select * from People
                //                where NationalNumber=@NationalNumber";

                using (SqlCommand command = new SqlCommand("SP_GetPersonByNationalNumber", connection))
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
                                PersonID = (int)reader["PersonID"];
                                FirstName = (string)reader["FirstName"];
                                SecondName = (string)reader["SecondName"];
                                ThirdName = (string)reader["ThirdName"];
                                LastName = (string)reader["LastName"];
                                Phone = (string)reader["Phone"];
                                DateOfBirth = (DateTime)reader["DateOfBirth"];
                                Gendor = Convert.ToByte(reader["Gendor"]);

                                isFound = true;


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
        public static int AddNewPerson(string NationalNumber,string FirstName,string SecondName,string ThirdName
              ,string LastName,string Phone, DateTime DateOfBirth,byte Gendor)
        {
            int PersonID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_AddNewPerson", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@NationalNumber", NationalNumber);
                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@SecondName", SecondName);
                    command.Parameters.AddWithValue("@ThirdName", ThirdName);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@Phone", Phone);
                    command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    command.Parameters.AddWithValue("@Gendor", Gendor);

                    SqlParameter parameter = new SqlParameter("@PersonID", SqlDbType.Int);
                    parameter.Direction = ParameterDirection.Output;
                    command.Parameters.Add(parameter);
                    try
                    {
                        connection.Open();
                        if (command.ExecuteNonQuery() > 0 && int.TryParse(parameter.Value.ToString(), out int ID))
                            PersonID = ID;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }


            return PersonID;
        }
     
        public static bool UpdatePerson(int PersonID, string NationalNumber, string FirstName, string SecondName, string ThirdName
              , string LastName, string Phone, DateTime DateOfBirth, byte Gendor)
        {
            bool isUpdated = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
               
                using (SqlCommand command = new SqlCommand("SP_UpdatePerson", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PersonID", PersonID);
                    command.Parameters.AddWithValue("@NationalNumber", NationalNumber);
                    command.Parameters.AddWithValue("@FirstName", FirstName);
                    command.Parameters.AddWithValue("@SecondName", SecondName);
                    command.Parameters.AddWithValue("@ThirdName", ThirdName);
                    command.Parameters.AddWithValue("@LastName", LastName);
                    command.Parameters.AddWithValue("@Phone", Phone);
                    command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                    command.Parameters.AddWithValue("@Gendor", Gendor);
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

        public static bool DeletePerson(int PersonID)
        {
            bool isDeleted = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using (SqlCommand command = new SqlCommand("SP_DeletePerson", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PersonID", PersonID);

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

        public static DataTable GetAllPeople()
        {
            DataTable dtAllPeople = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetAllPeople", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dtAllPeople.Load(reader);

                        }
                    }
                    catch (Exception)
                    {

                    }
                }

            }


            return dtAllPeople;
        }

        public static bool IsPersonExist(int PersonID)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {                
                using (SqlCommand command = new SqlCommand("SP_IsPersonExistByID", connection))
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
        public static bool IsPersonExist(string NationalNumber)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_IsPersonExistByNationalNumber", connection))
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
        public static bool MarkForDeleted(int PersonID)
        {
            bool isDeleted = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                string query = @"UPDATE [dbo].[People]
                                 SET [MarkForDeleted] = 1
                                 WHERE PersonID=@PersonID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PersonID", PersonID);

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
