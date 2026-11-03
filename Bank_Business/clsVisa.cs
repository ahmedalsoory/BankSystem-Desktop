using System;
using System.Data;
using BankDataAccess;
namespace Bank_Business
{
    /*
    int VisaID,ref string VisaNumber,ref string Password,ref byte Lenght,
       ref DateTime IssueDate,ref DateTime ExpiryDate,ref int AppliactionID,ref int ClientID

    */
    public class clsVisa
    {
        enum enMode { AddNew=0,Update=1}
        enMode _Mode;
        public int VisaID { get; set; }
        public string VisaNumber { get; set; }
        public string Password { get; set; }
        public byte Lenght { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public int AppliactionID { get; set; }
        public int ClientID { get; set; }
        public clsClient ClientInfo { get; private set; }
        public bool IsActive { get; set; }
        public clsVisa()
        {
            this.VisaID = -1;
            this.VisaNumber = "";
            this.Password = "";
            this.Lenght = 0;
            this.IssueDate = DateTime.Now;
            this.ExpiryDate = DateTime.Now;
            this.AppliactionID = -1;
            this.ClientID = -1;
            this.IsActive = false;
            _Mode = enMode.AddNew;
        }
        private clsVisa(int VisaID,string VisaNumber,string Password,byte Lenght,DateTime IssueDate,DateTime ExpiryDate
            ,int AppliactionID,int ClientID,bool isActive,bool ClientData=false)
        {
            this.VisaID = VisaID;
            this.VisaNumber = VisaNumber;
            this.Password = Password;
            this.Lenght = Lenght;
            this.IssueDate = IssueDate;
            this.ExpiryDate = ExpiryDate;
            this.AppliactionID = AppliactionID;
            this.ClientID = ClientID;
            if(ClientData)
                ClientInfo = clsClient.Find(ClientID);
            this.IsActive = isActive;
            _Mode = enMode.Update;
        }

        public static clsVisa Find(int VisaID, bool ClientData = false)
        {
            int AppliactionID = -1, ClientID = -1;
            string VisaNumber = "", Password = "";
            DateTime IssueDate = DateTime.Now, ExpiryDate = DateTime.Now;
            bool isActive = false;
            byte Lenght = 0;

            if(clsVisaData.GetVisaByID(VisaID,ref VisaNumber,ref Password,ref Lenght,ref IssueDate,
                ref ExpiryDate,ref AppliactionID,ref ClientID,ref isActive))
            {
                return new clsVisa(VisaID, VisaNumber, Password, Lenght, IssueDate, ExpiryDate, AppliactionID,
                    ClientID, isActive,ClientData);
            }

            return null;
        }
        public static clsVisa FindByClientID(int ClientID, bool ClientData = false)
        {
            int AppliactionID = -1, VisaID = -1;
            string VisaNumber = "", Password = "";
            DateTime IssueDate = DateTime.Now, ExpiryDate = DateTime.Now;
            bool isActive = false;
            byte Lenght = 0;

            if (clsVisaData.GetVisaByClientID(ClientID,ref VisaID, ref VisaNumber, ref Password, ref Lenght, ref IssueDate,
                ref ExpiryDate, ref AppliactionID, ref isActive))
            {
                return new clsVisa(VisaID, VisaNumber, Password, Lenght, IssueDate, ExpiryDate, AppliactionID,
                    ClientID, isActive,ClientData);
            }

            return null;
        }
        bool _AddNewVisa()
        {
            this.VisaNumber = clsUtil.GetRandomNumber(8);
            while (isExist(this.VisaNumber))
            {
                this.VisaNumber = clsUtil.GetRandomNumber(8);
            }
            this.Password= clsUtil.GetRandomNumber(4);
            this.VisaID = clsVisaData.AddNewVisa(this.VisaNumber, this.Password, this.Lenght, this.AppliactionID, this.ClientID);
            return this.VisaID != -1;
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewVisa())
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
            return clsVisaData.GetAllData();
        }
        public static bool isExist(int VisaID)
        {
            return clsVisaData.IsExist(VisaID);
        }
        public static bool isExist(string VisaNumber)
        {
            return clsVisaData.IsExist(VisaNumber);
        }
        public  bool UnActive()
        {
            return clsVisaData.UnActive(VisaID);
        }
        public clsVisa Copy()
        {
            clsVisa visa = new clsVisa();
            visa.ClientID = this.ClientID;
            visa.AppliactionID = this.AppliactionID;
            visa.ExpiryDate = this.ExpiryDate;
            visa.IsActive = this.IsActive;
            visa.IssueDate = this.IssueDate;
            visa.Lenght = this.Lenght;
            visa.Password = this.Password;
            visa.VisaNumber = this.VisaNumber;
            visa.ClientInfo = ClientInfo;
            return visa;
        }

    }
}
