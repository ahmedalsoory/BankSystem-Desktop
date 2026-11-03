using System;
using System.Data;
using BankDataAccess;
namespace Bank_Business
{
    public class clsBankAccount
    {
        enum enMode {AddNew=0,Update=1 }
        public int BankAccountID { get; set; }
        public string AccountNumber { get; set; }
        public float Amount { get; set; }
        public bool IsActive { get; set; }
        public string PinCode { get; set; }
        public int ApplicationID { get; set; }
        public clsApplication ApplicationInfo;
        enMode _Mode;
        public clsBankAccount()
        {
            this.BankAccountID = -1;
            this.AccountNumber = "";
            this.Amount = 0;
            this.IsActive = false;
            this.PinCode = "";
            this.ApplicationID = -1;
            _Mode = enMode.AddNew;
        }
        private clsBankAccount(int BankAccountID, string AccountNumber, float Amount, bool IsActive, string PinCode,
            int ApplicationID,bool ApplicationData=false, bool ApplicationClientData = false,
            bool ApplicationUserData = false, bool ApplicationUserEmplyeeData = false, bool ApplicationUserParsonalData = false, 
            bool ApplicationUserPermissionsData = false, bool ApplicationTypeData = false)
        {
            this.BankAccountID = BankAccountID;
            this.AccountNumber = AccountNumber;
            this.Amount = Amount;
            this.IsActive = IsActive;
            this.PinCode = PinCode;
            this.ApplicationID = ApplicationID;
            if (ApplicationData)
                this.ApplicationInfo = clsApplication.Find(ApplicationID,ApplicationClientData,ApplicationUserData,ApplicationUserEmplyeeData,
                    ApplicationUserParsonalData,ApplicationUserPermissionsData, ApplicationTypeData);
            _Mode = enMode.Update;
        }

        public static clsBankAccount Find(int BankAccountID)
        {
            string AccountNumber = "", PinCode = "";
            float Amount = 0;
            bool IsActive = false;
            int ApplicationID = -1;

            if(clsBankAccountData.GetAccountByID(BankAccountID,ref AccountNumber,ref Amount,ref IsActive,ref PinCode
                ,ref ApplicationID))
            {
                return new clsBankAccount(BankAccountID, AccountNumber, Amount, IsActive, PinCode, ApplicationID);
            }


            return null;
        }
        public static clsBankAccount Find(string AccountNumber)
        {
            string  PinCode = "";
            float Amount = 0;
            bool IsActive = false;
            int ApplicationID = -1, BankAccountID=-1;

            if (clsBankAccountData.GetAccountByAccountNumber(AccountNumber,ref BankAccountID, ref Amount, ref IsActive, ref PinCode
                , ref ApplicationID))
            {
                return new clsBankAccount(BankAccountID, AccountNumber, Amount, IsActive, PinCode, ApplicationID);
            }


            return null;
        }
        bool _AddNewBankAccount()
        {
            this.AccountNumber = _GetRandomNumber(100000,1000000);
            while (IsExist(this.AccountNumber))
            {
                this.AccountNumber = _GetRandomNumber(100000, 1000000);
            }
            this.PinCode= _GetRandomNumber(1000, 10000);
            this.BankAccountID = clsBankAccountData.AddNewBankAccount(this.AccountNumber,this.Amount,this.IsActive,this.PinCode,
                this.ApplicationID);

            return this.BankAccountID != -1;
        }

        string _GetRandomNumber(int Min,int Max)
        {
            Random r = new Random();
            return r.Next(Min, Max).ToString();
        }


        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewBankAccount())
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
            return clsBankAccountData.GetAllData();
        }
        public static bool IsExist(int BankAccountID)
        {
            return clsBankAccountData.IsExist(BankAccountID);
        }
        public static bool IsExist(string AccountNumber)
        {
            return clsBankAccountData.IsExist(AccountNumber);
        }

    }
}
