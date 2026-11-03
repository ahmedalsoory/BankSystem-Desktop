using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BankDataAccess;
namespace Bank_Business
{
    public class clsUser
    {
        enum enMode { AddNew = 0, Update = 1 }
        enMode _Mode;
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public int PermissionsID { get; set; }
        public clsPermissions PermissionsInfo{ get; private set; } 

        public int EmployeeID { get; set; }
        public clsEmployee EmployeeInfo { get; private set; }

        public clsUser()
        {
            this.UserID = -1;
            this.Username = "";
            this.Password = "";
            this.IsActive = false;
            this.EmployeeID = -1;
            this.PermissionsID = -1;
            _Mode = enMode.AddNew;
        }

        private clsUser(int UserID, string Username, string Password, bool IsActive, int PermissionsID, int EmployeeID, bool EmployeeData = false,
           bool PermissionsData = false,bool PersonData=true)
        {
            this.UserID = UserID;
            this.Username = Username;
            this.Password = Password;
            this.IsActive = IsActive;
            this.PermissionsID = PermissionsID;
            if (PermissionsData)
                this.PermissionsInfo = clsPermissions.Find(PermissionsID);
            this.EmployeeID = EmployeeID;
            if(EmployeeData)
                this.EmployeeInfo = clsEmployee.Find(EmployeeID,PersonData);
            _Mode = enMode.Update;
        }

        public static clsUser Find(int UserID,bool EmployeeData = false,bool PermissionsData = false,bool PersonData=false)
        {
            string Username = "", Password = "";
            bool isActive = false;
            int PermissionsID = -1, EmployeeID=-1;

            if(clsUserData.GetUserByID(UserID,ref Username,ref Password,ref isActive,ref EmployeeID,ref PermissionsID))
            {
                return new clsUser(UserID, Username, Password, isActive, PermissionsID, EmployeeID,EmployeeData,PermissionsData,PersonData);
            }
            return null;
        }
        public static clsUser Find(string Username,string Password, bool EmployeeData = false, bool PermissionsData = false)
        {
           
            bool isActive = false;
            int PermissionsID = -1, EmployeeID = -1, UserID=-1;

            if (clsUserData.GetUserByUsernameAndPassword( Username,Password,ref UserID,ref isActive, ref EmployeeID, ref PermissionsID))
            {
                return new clsUser(UserID, Username, Password, isActive, PermissionsID, EmployeeID,EmployeeData,PermissionsData);
            }
            return null;
        }
       
        public static bool isExist(int UserID)
        {
            return clsUserData.isUserExistByID(UserID);
        }
        public static bool isExist(string Username)
        {
            return clsUserData.isUserExistByUsername(Username);
        }
        public static bool isUserExistByEmployeeID(int EmployeeID)
        {
            return clsUserData.isUserExistByEmployeeID(EmployeeID);
        }
        bool _AddNewUser()
        {
            this.UserID = clsUserData.AddNewUser(this.Username, this.Password, this.IsActive, this.EmployeeID, this.PermissionsID);
            return this.UserID != -1;
        }
        bool _UpdateUser()
        {
            return clsUserData.UpdateUser(this.UserID, this.Username, this.Password, this.IsActive);
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewUser())
                    {
                        _Mode = enMode.Update;
                      
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateUser();

                default:
                    return false;
            }
        } 
        
        public static DataTable GetAllUser()
        {
            return clsUserData.GetAllData();
        }
        public static bool Delete(int UserID)
        {
            
            if (!isExist(UserID)) return false;

            return  clsUserData.MarkForDeleted(UserID) ;
        }

        public bool ChangePassword(string NewPassword)
        {

            return clsUserData.ChangePassword(this.UserID, NewPassword);
        }
    }
}
