using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BankDataAccess;
namespace Bank_Business
{
    public class  clsClient : clsPerson
    {
        new enum enMode { AddNew=0,Update=1}
        public int ClientID { get; set; }
        public int UserID { get; set; }
        public clsUser UserInfo { get; set; }
        public int? BankAccountID { get; set; }
        public clsBankAccount BankAccountInfo;
        new enMode _Mode;

        public clsClient()
        {
            this.ClientID = -1;
            this.UserID = -1;
            base.PersonID=-1;
            base.NationalNumber = "";
            base.FirstName = "";
            base.SecondName = "";
            base.ThirdName = "";
            base.LastName = "";
            base.Phone = "";
            base.DateOfBirth = DateTime.Now;
            base.Gendor = enGendor.Male;
            _Mode = enMode.AddNew;

        }
        private clsClient(int ClientID,int UserID, int? BankAccountID, int PersonID, string NationalNumber, string FirstName, 
            string SecondName, string ThirdName, string LastName, string Phone, DateTime DateOfBirth, enGendor Gendor)
        {
            this.ClientID = ClientID;
            this.UserID = UserID;
            this.UserInfo = clsUser.Find(UserID);
            this.PersonID = PersonID;
            this.NationalNumber = NationalNumber;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.Phone = Phone;
            this.DateOfBirth = DateOfBirth;
            this.Gendor = Gendor;
            if (BankAccountID != null)
            {

                this.BankAccountID = BankAccountID;
                this.BankAccountInfo = clsBankAccount.Find(BankAccountID.Value);
            }
            _Mode = enMode.Update;
        }

        public static new clsClient Find(int ClientID)
        {
            int UserID = -1, PersonID = -1;
            int? BankAccountID = null;
            if(clsClientData.GetClientByID(ClientID,ref PersonID,ref UserID,ref BankAccountID))
            {
                clsPerson Person = clsPerson.Find(PersonID);

                return new clsClient(ClientID,UserID,BankAccountID,PersonID,Person.NationalNumber,Person.FirstName,Person.SecondName,Person.ThirdName,
                    Person.LastName,Person.Phone,Person.DateOfBirth,Person.Gendor);
            }
            return null;
        }
        public static new clsClient Find(string AccountNumber)
        {

            int UserID = -1, PersonID = -1,ClientID=-1;
            int? BankAccountID = null;
            if (clsClientData.GetClientByAccountNumber(AccountNumber,ref ClientID, ref PersonID, ref UserID, ref BankAccountID))
            {
                clsPerson Person = clsPerson.Find(PersonID);

                return new clsClient(ClientID, UserID, BankAccountID, PersonID, Person.NationalNumber, Person.FirstName, Person.SecondName, Person.ThirdName,
                    Person.LastName, Person.Phone, Person.DateOfBirth, Person.Gendor);
            }
            return null;
        }
        public static  clsClient FindBankAccountID(int BankAccountID)
        {

            int UserID = -1, PersonID = -1, ClientID = -1;

            if (clsClientData.GetClientByBankAccountID(BankAccountID, ref ClientID, ref PersonID, ref UserID ))
            {
                clsPerson Person = clsPerson.Find(PersonID);

                return new clsClient(ClientID, UserID, BankAccountID, PersonID, Person.NationalNumber, Person.FirstName, Person.SecondName, Person.ThirdName,
                    Person.LastName, Person.Phone, Person.DateOfBirth, Person.Gendor);
            }
            return null;
        }
        public static  clsClient FindByNationalNumber(string NationalNumber)
        {

            int UserID = -1, PersonID = -1, ClientID = -1;
            int? BankAccountID = null;
            if (clsClientData.GetClientByNationalNumber(NationalNumber, ref ClientID, ref PersonID, ref UserID, ref BankAccountID))
            {
                clsPerson Person = clsPerson.Find(PersonID);

                return new clsClient(ClientID, UserID, BankAccountID, PersonID, Person.NationalNumber, Person.FirstName, Person.SecondName, Person.ThirdName,
                    Person.LastName, Person.Phone, Person.DateOfBirth, Person.Gendor);
            }
            return null;
        }

        public static  clsClient FindByPersonID(int PersonID)
        {
            int UserID = -1, ClientID = -1;
            int? BankAccountID = null;
            if (clsClientData.GetClientByPersonID(PersonID, ref ClientID, ref UserID, ref BankAccountID))
            {
                clsPerson Person = clsPerson.Find(PersonID);

                return new clsClient(ClientID, UserID, BankAccountID, PersonID, Person.NationalNumber, Person.FirstName, Person.SecondName, Person.ThirdName,
                    Person.LastName, Person.Phone, Person.DateOfBirth, Person.Gendor);
            }
            return null;
        }
        public static clsClient FindByVisaID(int VisaID)
        {
            int UserID = -1, ClientID = -1,PersonID=-1;
            int? BankAccountID = null;
            if (clsClientData.GetClientByVisaID(VisaID, ref ClientID, ref PersonID,ref UserID, ref BankAccountID))
            {
                clsPerson Person = clsPerson.Find(PersonID);

                return new clsClient(ClientID, UserID, BankAccountID, VisaID, Person.NationalNumber, Person.FirstName, Person.SecondName, Person.ThirdName,
                    Person.LastName, Person.Phone, Person.DateOfBirth, Person.Gendor);
            }
            return null;
        }
        public static clsClient FindByVisaNumber(string VisaNumber)
        {

            int UserID = -1, PersonID = -1, ClientID = -1;
            int? BankAccountID = null;
            if (clsClientData.GetClientByVisaNumber(VisaNumber, ref ClientID, ref PersonID, ref UserID, ref BankAccountID))
            {
                clsPerson Person = clsPerson.Find(PersonID);

                return new clsClient(ClientID, UserID, BankAccountID, PersonID, Person.NationalNumber, Person.FirstName, Person.SecondName, Person.ThirdName,
                    Person.LastName, Person.Phone, Person.DateOfBirth, Person.Gendor);
            }
            return null;
        }
        bool _AddNewClient()
        {
            this.ClientID= clsClientData.AddNewClient(this.PersonID, this.UserID);
            return this.ClientID != -1;
        }
        bool _UpdateClinet()
        {
            return true;
        }
        public new bool Save()
        {
            base._Mode=(clsPerson.enMode)_Mode;

            bool isExist = clsPerson.IsExist(this.NationalNumber);
            if(!isExist || isExist && _Mode==enMode.Update)
                if (!base.Save()) return false;

            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewClient())
                    {
                        this.UserInfo = clsUser.Find(UserID);
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateClinet();
                default:
                    return false;
            }
        }
        public enum enExistByInt { ClientID=0, PersonID=1, BankAcountID =2, VisaID=3 }
        public enum enExistByString { NationalNumber =0, AccountNumber =1, VisaNumber=2 }

        public  static bool IsExist(int Value,enExistByInt ExistBy)
        {
            switch (ExistBy)
            {
                case enExistByInt.ClientID:
                    return clsClientData.isExistByID(Value);

                case enExistByInt.PersonID:
                    return clsClientData.isExistByPersonID(Value);

                case enExistByInt.BankAcountID:
                    return clsClientData.isExistByBankAcountID(Value);

                case enExistByInt.VisaID:
                    return clsClientData.isExistByVisaID(Value);

                default:
                    return false;
            }
        }

        public static bool IsExist(string Value,enExistByString ExistBy)
        {
            switch (ExistBy)
            {

                case enExistByString.AccountNumber:
                    return clsClientData.isExistByAccountNumber(Value);

                case enExistByString.NationalNumber:
                    return clsClientData.isExistByNationalNumber(Value);

                case enExistByString.VisaNumber:
                    return clsClientData.isExistByVisaNumber(Value);

                default:
                    return false;
            }
        }

        //public static new bool IsExist(int ClientID)
        //{
        //    return clsClientData.isExistByID(ClientID);
        //}
        //public static bool IsExistByPersonID(int PersonID)
        //{
        //    return clsClientData.isExistByPersonID(PersonID);
        //}
        //public static new bool IsExist(string NationalNumber)
        //{
        //    return clsClientData.isExistByNationalNumber(NationalNumber);
        //}
        //public static bool IsExistByBankAcountID(int BankAcountID)
        //{
        //    return clsClientData.isExistByBankAcountID(BankAcountID);
        //}
        //public static bool IsExistByAccountNumber(string AccountNumber)
        //{
        //    return clsClientData.isExistByAccountNumber(AccountNumber);
        //}
        //public static bool isExistByVisaID(int VisaID)
        //{
        //    return clsClientData.isExistByVisaID(VisaID);
        //}
        //public static bool isExistByVisaNumber(string VisaNumber)
        //{
        //    return clsClientData.isExistByVisaNumber(VisaNumber);
        //}

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;

            clsClient client = (clsClient)obj;

            return base.Equals((clsPerson)obj) && client.ClientID == this.ClientID &&
                client.UserID == this.ClientID;
        }
        public static new DataTable GetAllData()
        {
            return clsClientData.GetAllData();
        }

        public static new bool  Delete(int ClientID)
        {
            
            return clsClientData.DeleteClient(ClientID);
        }
        public  bool ChequeBookIssuance(ref int AppliactionID,int CreatedByUserID)
        {
            
            if (this.BankAccountID == null) return false;

            clsApplication application = new clsApplication();
            application.ClientID = this.ClientID;
            application.ApplicationTypeID= Convert.ToByte(clsApplication.enApplicationType.ChequeBookIssuance);
            application.AppliactionFees = clsApplicationType.Find(
                Convert.ToByte(clsApplication.enApplicationType.ChequeBookIssuance)).ApplicationFees;
            application.ApplicationStatus = clsApplication.enApplicationStatus.New;
            application.CreatedByUserID = CreatedByUserID;
            if (application.Save())
            {

                AppliactionID = application.ApplicationID;
                return true;
            }
            return false;
        }
        public bool OpenBankAccount(ref int AppliactionID, int CreatedByUserID)
        {
            if (this.BankAccountID != null) return false;

            clsApplication application = new clsApplication();
            application.ClientID = this.ClientID;
            application.ApplicationTypeID = Convert.ToByte(clsApplication.enApplicationType.OpenBankAccount);
            application.AppliactionFees = clsApplicationType.Find(application.ApplicationTypeID).ApplicationFees;
            application.ApplicationStatus = clsApplication.enApplicationStatus.completed;
            application.CreatedByUserID = CreatedByUserID;
            if (!application.Save()) return false;
            AppliactionID = application.ApplicationID;
            clsBankAccount bankAccount = new clsBankAccount();
            bankAccount.Amount = 100;
            bankAccount.ApplicationID = application.ApplicationID;
            bankAccount.IsActive = true;
            if (!bankAccount.Save()) return false;
            this.BankAccountID = bankAccount.BankAccountID;
            this.BankAccountInfo = clsBankAccount.Find(BankAccountID.Value);

            return clsClientData.OpenBankAccount(this.ClientID,this.BankAccountID.Value);
        }

        public bool IssueVisa(int CreatedByUserID,ref int VisaID)
        {

            clsApplication application = new clsApplication();
            application.ClientID = this.ClientID;
            application.ApplicationTypeID = Convert.ToByte(clsApplication.enApplicationType.VersionVisaFirstTime);
            application.AppliactionFees = clsApplicationType.Find(application.ApplicationTypeID).ApplicationFees;
            application.ApplicationStatus = clsApplication.enApplicationStatus.completed;
            application.CreatedByUserID = CreatedByUserID;
            if (!application.Save()) return false;
            clsVisa visa = new clsVisa();
            visa.AppliactionID = application.ApplicationID;
            visa.ClientID = this.ClientID;
            visa.Lenght = 10;
            if (!visa.Save()) return false;
            VisaID = visa.VisaID;
            return true;
        }
        public static bool isClientHasBankAccount(int ClientID)
        {
            return clsClientData.isClientHasBankAccount(ClientID);
        }
        public static bool IsClientHasVisa(int ClientID)
        {
            return clsClientData.IsClientHasVisa(ClientID);
        }
        public  bool IsClientHasVisa()
        {
            return clsClientData.IsClientHasVisa(this.ClientID);
        }
        public enum enReplaceFor { ReplaceVisaForLost = 4, ReplaceVisaForDamage = 5 }
        public bool ReplaceVisa(ref int AppliactionID, ref int NewVisaID,int CreatedByUserID, enReplaceFor ReplaceFor)
        {
            if (!IsClientHasVisa(this.ClientID)) return false;

            clsApplication application = new clsApplication();
            application.ApplicationTypeID = Convert.ToByte(ReplaceFor);
            application.AppliactionFees = clsApplicationType.Find(application.ApplicationTypeID).ApplicationFees;
            application.ApplicationDate = DateTime.Now;
            application.ApplicationStatus = clsApplication.enApplicationStatus.completed;
            application.ClientID = this.ClientID;
            application.CreatedByUserID = CreatedByUserID;
            if (!application.Save()) return false;
            clsVisa OldVisa = clsVisa.FindByClientID(ClientID);
            clsVisa NewVisa = OldVisa.Copy();
            NewVisa.AppliactionID = application.ApplicationID;
            if (!OldVisa.UnActive()|| !NewVisa.Save()) return false;
            NewVisaID = NewVisa.VisaID;
            AppliactionID = application.ApplicationID;
            return true;

        }
        public bool RenewVisa(ref int AppliactionID, ref int NewVisaID, int CreatedByUserID)
        {
            clsVisa OldVisa = clsVisa.FindByClientID(this.ClientID);
            if (OldVisa.ExpiryDate > DateTime.Now) return false;
            clsApplication application = new clsApplication();
            application.ApplicationDate = DateTime.Now;
            application.ApplicationStatus = clsApplication.enApplicationStatus.completed;
            application.ApplicationTypeID = Convert.ToByte(clsApplication.enApplicationType.RenewVisa);
            application.AppliactionFees = clsApplicationType.Find(application.ApplicationTypeID).ApplicationFees;
            application.ClientID = this.ClientID;
            application.CreatedByUserID = CreatedByUserID;
            if (!application.Save()) return false;
            AppliactionID = application.ApplicationID;
            clsVisa NewVisa = OldVisa.Copy();
            if (!OldVisa.UnActive()) return false;
            NewVisa.AppliactionID = AppliactionID;
            NewVisa.IssueDate = DateTime.Now;
            NewVisa.ExpiryDate = DateTime.Now.AddYears(NewVisa.Lenght);
            if (!NewVisa.Save()) return false;
            NewVisaID = NewVisa.VisaID;
            return true;
        }
        public bool RenewVisa(ref int NewVisaID, int CreatedByUserID)
        {
            clsVisa OldVisa = clsVisa.FindByClientID(this.ClientID);
            if (OldVisa.ExpiryDate > DateTime.Now) return false;
            clsApplication application = new clsApplication();
            application.ApplicationDate = DateTime.Now;
            application.ApplicationStatus = clsApplication.enApplicationStatus.completed;
            application.ApplicationTypeID = Convert.ToByte(clsApplication.enApplicationType.RenewVisa);
            application.AppliactionFees = clsApplicationType.Find(application.ApplicationTypeID).ApplicationFees;
            application.ClientID = this.ClientID;
            application.CreatedByUserID = CreatedByUserID;
            if (!application.Save()) return false;
            clsVisa NewVisa = OldVisa.Copy();
            if (!OldVisa.UnActive()) return false;
            NewVisa.AppliactionID = application.ApplicationID;
            NewVisa.IssueDate = DateTime.Now;
            NewVisa.ExpiryDate = DateTime.Now.AddYears(NewVisa.Lenght);
            if (!NewVisa.Save()) return false;
            NewVisaID = NewVisa.VisaID;
            return true;
        }
        public bool Deposit(float Amount, int CreatedByUserID)
        {

            clsAccountTransactions transactions = new clsAccountTransactions();
            transactions.AccountTransactionTypeID = clsAccountTransactions.enAccountTransactionType.Deposit;
            transactions.Amont = Amount;
            transactions.ClientAccountTransaction = this.ClientID;
            transactions.CreatedByUserID = CreatedByUserID;
            transactions.TransactionDate = DateTime.Now;
            if (!transactions.Save()) return false;
            return clsClientData.Deposit(this.BankAccountID.Value,Amount);
        }
        public bool Withdraw(float Amount, int CreatedByUserID)
        {
            clsAccountTransactions transactions = new clsAccountTransactions();
            transactions.AccountTransactionTypeID = clsAccountTransactions.enAccountTransactionType.Withdraw;
            transactions.Amont = Amount;
            transactions.ClientAccountTransaction = this.ClientID;
            transactions.CreatedByUserID = CreatedByUserID;
            transactions.TransactionDate = DateTime.Now;
            if (!transactions.Save()) return false;
            return clsClientData.Deposit(this.BankAccountID.Value,Amount*-1);
        }
        public bool Tarnsfer(int BankAccountID, float Amount, int CreatedByUserID)
        {

            clsAccountTransactions transactions = new clsAccountTransactions();
            transactions.AccountTransactionTypeID = clsAccountTransactions.enAccountTransactionType.Transfer;
            transactions.Amont = Amount;
            transactions.ClientAccountTransaction = this.ClientID;
            transactions.CreatedByUserID = CreatedByUserID;
            transactions.TransactionDate = DateTime.Now;
            transactions.ClientAccountDestination = clsClient.FindBankAccountID(BankAccountID).ClientID;
            if (!clsClientData.Deposit(this.BankAccountID.Value, -1*Amount)) return false;
            if (!clsClientData.Deposit(BankAccountID, 1 * Amount)) return false;
            if (!transactions.Save()) return false;
            return true;
        }


    }
}
