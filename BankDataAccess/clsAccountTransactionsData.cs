using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace BankDataAccess
{
    public class clsAccountTransactionsData
    {
        public static bool GetAccountTransactionsByID(int AccountTransactionID,ref byte AccountTransactionTypeID,ref DateTime TransactionDate,
            ref float Amont,ref int CreatedByUserID,ref int ClientAccountTransaction,ref int? ClientAccountdestination)
        {
            bool isFound = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                
                using (SqlCommand command = new SqlCommand("SP_GetAccountTransactionsByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@AccountTransactionID", AccountTransactionID);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                isFound = true;
                                AccountTransactionTypeID = Convert.ToByte(reader["AccountTransactionTypeID"]);
                                TransactionDate = (DateTime)reader["TransactionDate"];
                                Amont = Convert.ToSingle(reader["Amont"]);
                                CreatedByUserID = (int)reader["CreatedByUserID"];
                                ClientAccountTransaction = (int)reader["ClientAccountTransaction"];
                                if (reader["ClientAccountdestination"] != DBNull.Value)
                                    ClientAccountdestination = (int)reader["ClientAccountdestination"];
                            }
                        }
                    }
                    catch(Exception ex)
                    {

                    }
                }
            }


            return isFound;
        }

        public static int AddNewAccountTransactions( byte AccountTransactionTypeID,DateTime TransactionDate,float Amont,int CreatedByUserID,
            int ClientAccountTransaction,int? ClientAccountDestination)
        {
            int AccountTransactionID = -1;

            using(SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {


                using (SqlCommand command = new SqlCommand("SP_AddNewAccountTransactions", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@AccountTransactionTypeID", AccountTransactionTypeID);
                    command.Parameters.AddWithValue("@TransactionDate", TransactionDate);
                    command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                    command.Parameters.AddWithValue("@ClientAccountTransaction", ClientAccountTransaction);
                    command.Parameters.AddWithValue("@Amont", Amont);
                    if(ClientAccountDestination.HasValue)
                        command.Parameters.AddWithValue("@ClientAccountdestination", ClientAccountDestination);
                    else
                        command.Parameters.AddWithValue("@ClientAccountdestination", DBNull.Value);

                    SqlParameter parameter = new SqlParameter("@ReturnVal", SqlDbType.Int);
                    parameter.Direction = ParameterDirection.ReturnValue;
                    command.Parameters.Add(parameter);

                    try
                    {
                        connection.Open();
                        object resutl = parameter.Value;
                        if (resutl != null && int.TryParse(resutl.ToString(), out int ID))
                            AccountTransactionID = ID;
                    }
                    catch(Exception ex)
                    {

                    }
                }

            }
            return AccountTransactionID;
        }
        public static bool UpdateAccountTransactions(int AccountTransactionID, byte AccountTransactionTypeID, DateTime TransactionDate, float Amont, 
            int CreatedByUserID,int ClientAccountTransaction, int? ClientAccountDestination)
        {
            bool IsUpdated = false;

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
          
                using (SqlCommand command = new SqlCommand("SP_UpdateAccountTransactions", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@AccountTransactionID", AccountTransactionID);
                    command.Parameters.AddWithValue("@AccountTransactionTypeID", AccountTransactionTypeID);
                    command.Parameters.AddWithValue("@TransactionDate", TransactionDate);
                    command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
                    command.Parameters.AddWithValue("@ClientAccountTransaction", ClientAccountTransaction);
                    command.Parameters.AddWithValue("@Amont", Amont);
                    if (ClientAccountDestination.HasValue)
                        command.Parameters.AddWithValue("@ClientAccountdestination", ClientAccountDestination);
                    else
                        command.Parameters.AddWithValue("@ClientAccountdestination", DBNull.Value);

                    try
                    {
                        connection.Open();
                        IsUpdated = command.ExecuteNonQuery() > 0;
                    }
                    catch (Exception ex)
                    {

                    }
                }

            }
            return IsUpdated;
        }


        public static DataTable GetAllTransactions()
        {
            DataTable dtAllTransactions = new DataTable();

            using (SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_GetAllTransactions", connection))       
                {
                    command.CommandType = CommandType.StoredProcedure;
                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                                dtAllTransactions.Load(reader);
                        }
                    }
                    catch (Exception)
                    {

                    }
                }


            }


            return dtAllTransactions;
        }
        
    }
}
