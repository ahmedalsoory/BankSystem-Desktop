using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace BankDataAccess
{

    public class LoginData
    {
       public int LoginID { get; }
       public DateTime LoginDate { get; }
       public DateTime LogoutDate { get; }
       public int LoginUser { get; }
        public LoginData(int LoginID, DateTime LoginDate, DateTime LogoutDate, int LoginUser)
        {
            this.LoginID= LoginID;
            this.LoginDate= LoginDate;
            this.LogoutDate = LogoutDate;
            this.LoginUser = LoginUser;
        }
    }
    
    public static class clsLoginsData
    {
        public static List<LoginData> GetAllData2()
        {
            List<LoginData> data = new List<LoginData>();


            try
            {
                using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("select * from logins", connection))
                    {
                        connection.Open();
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                LoginData login = new LoginData((int)reader[0],(DateTime)reader[1],(DateTime)reader[2],(int)reader[3]);
                                data.Add(login);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

            }

            return data;
        }



        public static bool Find(int LoginID,ref DateTime LoginDate,ref DateTime LogoutDate,ref int LoginUser)
        {
            bool isFound = false;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {

                using(SqlCommand command = new SqlCommand("SP_GetLoginByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@LoginID", LoginID);

                    try
                    {
                        connection.Open();
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                LoginDate = (DateTime)reader["LoginDate"];
                                LogoutDate = (DateTime)reader["LogoutDate"];
                                LoginUser = (int)reader["LoginUser"];

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

        public static int AddNewLogin(DateTime LoginDate, DateTime LogoutDate, int LoginUser)
        {
            int LoginID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using(SqlCommand command = new SqlCommand("SP_AddNewLogin", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@LoginDate", LoginDate);
                    command.Parameters.AddWithValue("@LogoutDate", LogoutDate);
                    command.Parameters.AddWithValue("@LoginUser", LoginUser);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int ID))
                            LoginID = ID;
                    }
                    catch (Exception)
                    {

                    }

                }
            }


                return LoginID; 
        }





        public static DataTable GetAllData()
        {
            DataTable dtAllData = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetAllLogins", connection))
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

    }
}
