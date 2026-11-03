using System;
using System.Data;
using BankDataAccess;

namespace Bank_Business
{
    public class clsApplication
    {
        enum enMode { AddNew=0,Update=1}
        public enum enApplicationStatus { New = 1, cancelled = 2, completed = 3 }
        public enum enApplicationType {OpenBankAccount = 1, ChequeBookIssuance=2, VersionVisaFirstTime=3, 
            ReplaceVisaForLost=4,ReplaceVisaForDamage = 5,RenewVisa=6 }

        public int ApplicationID { get; set; }

        public DateTime ApplicationDate { get; set; }
        public int ClientID { get; set; }
        public clsClient ClientInfo;
        public int CreatedByUserID { get; set; }
        public clsUser UserInfo;
        public byte ApplicationTypeID { get; set; }
        public clsApplicationType ApplicationTypeInfo;
        public enApplicationStatus ApplicationStatus { get; set; }
        enMode _Mode;
        public float AppliactionFees { get; set; }
        public clsApplication()
        {
            this.ApplicationID = -1;
            this.ClientID = -1;
            this.CreatedByUserID = -1;
            _Mode = enMode.AddNew;
        }
        private clsApplication(int ApplicationID, DateTime ApplicationDate, int ClientID, int CreatedByUserID
            , byte ApplicationTypeID, float AppliactionFees, enApplicationStatus ApplicationStatus, bool ClientData = false,
            bool UserData = false, bool UserEmplyeeData = false, bool UserParsonalData = false , bool PermissionsData = false
            , bool ApplicationTypeData=false)
        {
            this.ApplicationID = ApplicationID;
            this.ApplicationDate = ApplicationDate;
            this.ClientID = ClientID;
            if(ClientData)
                ClientInfo = clsClient.Find(ClientID);
            this.CreatedByUserID = CreatedByUserID;
            if(UserData)
                UserInfo = clsUser.Find(CreatedByUserID,UserEmplyeeData,PermissionsData, UserParsonalData);
            this.ApplicationTypeID = ApplicationTypeID;
            if(ApplicationTypeData)
                ApplicationTypeInfo = clsApplicationType.Find(ApplicationTypeID);
            this.ApplicationStatus = ApplicationStatus;
            this.AppliactionFees = AppliactionFees;
            _Mode = enMode.Update;
        }
        
        bool _AddNewApplication()
        {
            this.ApplicationID = clsApplicationData.AddNewApplication( this.ClientID, this.CreatedByUserID,
                this.ApplicationTypeID);
            return this.ApplicationID != -1;
        } 
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewApplication())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

            

                default:
                    return false;
            }
        }

        public static clsApplication Find(int ApplicationID, bool ClientData = false,
            bool UserData = false, bool UserEmplyeeData = false, bool UserParsonalData = false, bool PermissionsData = false
            , bool ApplicationTypeData = false)
        {
            DateTime ApplicationDate = DateTime.Now;

            int ClientID = -1, CreatedByUserID = -1;
            byte ApplicationTypeID = 10, ApplicationStatus=9;
            float AppliactionFees = 0;
            if (clsApplicationData.GetApplicationByID(ApplicationID,ref ApplicationDate,ref ClientID,ref CreatedByUserID,
                ref AppliactionFees, ref ApplicationTypeID,ref ApplicationStatus))
            {
                return new clsApplication(ApplicationID, ApplicationDate, ClientID, CreatedByUserID, ApplicationTypeID,
                   AppliactionFees, (enApplicationStatus)ApplicationStatus,ClientData,UserData,UserEmplyeeData,UserParsonalData,
                   PermissionsData,ApplicationTypeData);
            }

            return null;
        }
        public bool Cancel()
        {
            return clsApplicationData.ConvertApplicationStatus(this.ApplicationID, Convert.ToByte(enApplicationStatus.cancelled));
        }
        public bool Completed()
        {
            return clsApplicationData.ConvertApplicationStatus(this.ApplicationID, Convert.ToByte(enApplicationStatus.completed));
        }
        public static DataTable GetAllData()
        {
            return clsApplicationData.GetAllData();
        }
        public static bool ChequeBookIssuance(int ClientID, int CreatedByUserID)
        {

            return  clsApplicationData.AddNewApplication(ClientID,CreatedByUserID, Convert.ToByte(enApplicationType.ChequeBookIssuance)
                ) !=-1;
        }



    }
}
