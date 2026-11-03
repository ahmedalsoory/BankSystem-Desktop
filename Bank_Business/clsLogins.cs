using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BankDataAccess;
namespace Bank_Business
{
    public class clsLogins
    {
        //int LoginID,ref DateTime LoginDate,ref DateTime LogoutDate,ref int LoginUser

        enum enMode { AddNew=0,Update=1}
        enMode _Mode;
        public int LoginID { get; set; }
        public DateTime LoginDate { get; set; }
        public DateTime LogoutDate { get; set; }
        public int LoginUser { get; set; }
        public clsUser UserInfo { get; private set; }

        public clsLogins()
        {
            this.LoginID = -1;
            this.LoginUser = -1;
            _Mode = enMode.AddNew;
        }
        private clsLogins(int LoginID,DateTime LoginDate,DateTime LogoutDate,int LoginUser,bool UserData=false,
             bool UserEmployeeData = false, bool UserPermissionsData = false, bool UserPersonData = false)
        {
            this.LoginID = LoginID;
            this.LoginDate = LoginDate;
            this.LogoutDate = LogoutDate;
            this.LoginUser = LoginUser;
            _Mode = enMode.Update;
            if(UserData)
                this.UserInfo = clsUser.Find(LoginUser,UserEmployeeData,UserPermissionsData,UserPersonData);
        }

        bool _AddNewLogin()
        {
            this.LoginID = clsLoginsData.AddNewLogin(this.LoginDate, this.LogoutDate, this.LoginUser);
            return this.LoginID != -1; 
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLogin())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                default:
                    return false;
            }
        }
        public static clsLogins Find(int LoginID, bool UserData = false)
        {
            DateTime LoginDate = DateTime.Now, LogoutDate = DateTime.Now;
            int LoginUser = -1;

            if(clsLoginsData.Find(LoginID,ref LoginDate,ref LogoutDate,ref LoginUser))
            {
                return new clsLogins(LoginID,LoginDate,LogoutDate,LoginUser,UserData);
            }
            return null;
        }
        public static DataTable GetAllData()
        {
            return clsLoginsData.GetAllData();
        }

    }
}
