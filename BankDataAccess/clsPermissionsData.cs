using System;
using System.Data;
using System.Data.SqlClient;
namespace BankDataAccess
{
    public class clsPermissionsData
    {
        public static bool GetPermissionsByID(int PermissionsID,ref byte PermissionsForClient, ref byte PermissionsForUser
            ,ref byte  PermissionsForEmployee,ref byte PermissionsForAppliaction,ref byte PermissionsForTransaction,
            ref bool PermissionsForLogRegisters)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetPermissionsByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PermissionsID", PermissionsID);
                    try
                    {
                        connection.Open();
                        using(SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                PermissionsForClient = Convert.ToByte(reader["PermissionsForClient"]);
                                PermissionsForUser = Convert.ToByte(reader["PermissionsForUser"]);
                                PermissionsForEmployee = Convert.ToByte(reader["PermissionsForEmployee"]);
                                PermissionsForAppliaction = Convert.ToByte(reader["PermissionsForAppliaction"]);
                                PermissionsForTransaction = Convert.ToByte(reader["PermissionsForTransaction"]);
                                PermissionsForLogRegisters = Convert.ToBoolean(reader["PermissionsForLogRegisters"]);
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

        public static int AddNewPermissions(byte PermissionsForClient,byte PermissionsForUser,byte PermissionsForEmployee
           ,byte PermissionsForAppliaction,byte PermissionsForTransaction,bool PermissionsForLogRegisters)
        {
            int PermissionsID = -1;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using(SqlCommand command = new SqlCommand("SP_AddNewPermissions", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PermissionsForClient", PermissionsForClient);
                    command.Parameters.AddWithValue("@PermissionsForUser", PermissionsForUser);
                    command.Parameters.AddWithValue("@PermissionsForEmployee", PermissionsForEmployee);
                    command.Parameters.AddWithValue("@PermissionsForAppliaction", PermissionsForAppliaction);
                    command.Parameters.AddWithValue("@PermissionsForTransaction", PermissionsForTransaction);
                    command.Parameters.AddWithValue("@PermissionsForLogRegisters", PermissionsForLogRegisters);

                    SqlParameter parameter = new SqlParameter("@ReturnVal", SqlDbType.Int);
                    parameter.Direction = ParameterDirection.ReturnValue;
                    command.Parameters.Add(parameter);

                    try
                    {
                        connection.Open();
                        object result = parameter.Value;
                        if (result != null && int.TryParse(result.ToString(), out int ID))
                            PermissionsID = ID;
                    }
                    catch (Exception)
                    {

                    }
                }
                 

            }




                return PermissionsID;
        }

        public static bool UpdatePermissions(int PermissionsID, byte PermissionsForClient, byte PermissionsForUser, 
            byte PermissionsForEmployee, byte PermissionsForAppliaction, byte PermissionsForTransaction,
            bool PermissionsForLogRegisters)
        {
            bool isUpdated = false;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_UpdatePermissions", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@PermissionsID", PermissionsID);
                    command.Parameters.AddWithValue("@PermissionsForClient", PermissionsForClient);
                    command.Parameters.AddWithValue("@PermissionsForUser", PermissionsForUser);
                    command.Parameters.AddWithValue("@PermissionsForEmployee", PermissionsForEmployee);
                    command.Parameters.AddWithValue("@PermissionsForAppliaction", PermissionsForAppliaction);
                    command.Parameters.AddWithValue("@PermissionsForTransaction", PermissionsForTransaction);
                    command.Parameters.AddWithValue("@PermissionsForLogRegisters", PermissionsForLogRegisters);

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


    }
}
