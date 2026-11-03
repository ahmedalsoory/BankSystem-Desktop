using System;
using System.Data;
using BankDataAccess;
namespace Bank_Business
{
    public class clsApplicationType
    {
        enum enMode { AddNew=0,Update=1}
       
        public byte ApplicationTypeID { get; set; }
        public string ApplicationName { get; set; }
        public float ApplicationFees { get; set; }
       
        enMode _Mode;
        public clsApplicationType()
        {
            this.ApplicationTypeID = 0;
            this.ApplicationName = "";
            this.ApplicationFees = 0;
            _Mode = enMode.AddNew;
        }

        private clsApplicationType(byte ApplicationTypeID, string ApplicationName, float ApplicationFees)
        {
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationName = ApplicationName;
            this.ApplicationFees = ApplicationFees;
            _Mode = enMode.Update;
        }

        bool _UpdateApplicationType()
        {
            return clsApplicationTypeData.UpdateApplicationType(this.ApplicationTypeID, this.ApplicationName, this.ApplicationFees);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.Update:
                    return _UpdateApplicationType();

                default:
                    return false;
            }
        }

        public static DataTable GetAllData()
        {
            return clsApplicationTypeData.GetAllData();
        }
        public static clsApplicationType Find(byte ApplicationTypeID)
        {
            string ApplicationName = "";
            float ApplicationFees = 0;

            if(clsApplicationTypeData.GetApplicationTypeByID(ApplicationTypeID,ref ApplicationName,ref ApplicationFees))
            {
                return new clsApplicationType(ApplicationTypeID, ApplicationName, ApplicationFees);
            }
            return null;
        }


    }
}
