using System;
using System.Data;
using BankDataAccess;
namespace Bank_Business
{
    public class clsAccountTransactionType
    {
        enum enMode { AddNew=0,Update=1}
        public byte AccountTransactionTypeID { get; set; }
        public string TypeName { get; set; }

        public float Fees { get; set; }
        enMode _Mode;

        public clsAccountTransactionType()
        {
            this.AccountTransactionTypeID = 0;
            this.TypeName = "";
            this.Fees = 0;
            _Mode = enMode.AddNew;
        }

        private clsAccountTransactionType(byte AccountTransactionTypeID, string TypeName, float Fees)
        {
            this.AccountTransactionTypeID = AccountTransactionTypeID;
            this.TypeName = TypeName;
            this.Fees = Fees;
            _Mode = enMode.Update;
        }

        bool _UpdateAccountTransactionType()
        {
            return clsAccountTransactionTypeData.UpdateAccountTransactionType(this.AccountTransactionTypeID, this.TypeName, this.Fees);
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.Update:
                    return _UpdateAccountTransactionType();

                default:
                    return false;
            }
        }

        public static DataTable GetAllData()
        {
            return clsAccountTransactionTypeData.GetAllData();
        }

        public static clsAccountTransactionType Find(byte AccountTransactionTypeID)
        {
            string TypeName = "";
            float Fees = 0;

            if (clsAccountTransactionTypeData.GetAccountTransactionTypeByID(AccountTransactionTypeID, ref TypeName, ref Fees))
            {
                return new clsAccountTransactionType(AccountTransactionTypeID,TypeName,Fees);
            }
            return null;
        }

    }

}
