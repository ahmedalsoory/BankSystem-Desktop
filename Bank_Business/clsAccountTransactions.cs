using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BankDataAccess;
namespace Bank_Business
{
    public class clsAccountTransactions
    {
        //1 - deposit , 2 - Withdraw , 3 - transfer
        enum enMode { AddNew=0,Update=1 };
        public enum enAccountTransactionType { Deposit=1, Withdraw=2 , Transfer =3}
        
        public int AccountTransactionID { get; set; }
        public enAccountTransactionType AccountTransactionTypeID { get; set; }
        public float Amont { get; set; }
        public DateTime TransactionDate { get; set; }
        public int CreatedByUserID { get; set; }
        public clsUser UserInfo;
        public int ClientAccountTransaction { get; set; }
        public clsClient ClientAccountTransactionInfo;
        public int? ClientAccountDestination { get; set; }
        public clsClient ClientAccountDestinationInfo;
        enMode _Mode;

        public clsAccountTransactions()
        {
            this.AccountTransactionID = -1;
            this.CreatedByUserID = -1;
            this.ClientAccountTransaction = -1;
            _Mode = enMode.AddNew;
        }

        private clsAccountTransactions(int AccountTransactionID, enAccountTransactionType AccountTransactionTypeID, DateTime TransactionDate, float Amont,
            int CreatedByUserID, int ClientAccountTransaction, int? ClientAccountDestination, bool UserData = false, bool EmployeeUserData = false,
            bool UserPermissionsData = false, bool UserPersnalData = false,bool ClientAccountTransactionData = false,
            bool ClientAccountDestinationData=false)
        {
           
            this.AccountTransactionID = AccountTransactionID;
            this.AccountTransactionTypeID = AccountTransactionTypeID;
            this.TransactionDate = TransactionDate;
            this.Amont = Amont;
            this.CreatedByUserID = CreatedByUserID;
            if (UserData)
            {
                UserInfo = clsUser.Find(CreatedByUserID, EmployeeUserData, UserPermissionsData, UserPersnalData);
            }
            this.ClientAccountTransaction = ClientAccountTransaction;
            if (ClientAccountTransactionData)
                ClientAccountTransactionInfo = clsClient.Find(ClientAccountTransaction);
            

            this.ClientAccountDestination = ClientAccountDestination;

            if (ClientAccountDestination.HasValue&& ClientAccountDestinationData)
            {
                ClientAccountDestinationInfo = clsClient.Find(ClientAccountDestination.Value);
            }

            _Mode = enMode.Update;
        }

        bool _AddNewAccountTransactions()
        {
            this.AccountTransactionID = clsAccountTransactionsData.AddNewAccountTransactions(Convert.ToByte( this.AccountTransactionTypeID),
                this.TransactionDate,this.Amont, this.CreatedByUserID, this.ClientAccountTransaction, this.ClientAccountDestination);

            return this.AccountTransactionID != -1; 
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewAccountTransactions())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                default:
                    return false;
            }
        }

        public static DataTable GetAllData()
        {
            return clsAccountTransactionsData.GetAllTransactions();
        }

    }
}
