using System;
using BankDataAccess;
namespace Bank_Business
{
    public class clsPermissions
    {

        public enum enPermissonsForClient { AddClient=1 , UpdateClient=2, DeleteClient=4 }
        public enum enPermissonsForEmployee { AddEmployee = 1, UpdateEmployee = 2, DeleteEmployee = 4 }
        public enum enPermissonsForUser { AddUser = 1, UpdateUser = 2, DeleteUser = 4 }
        public enum enPermissonsForAppliaction { OpenBankAccount = 1, ChequeBookIssuance = 2, VersionVisaFirstTime = 4
        , RenewVisa=8, ReplaceVisa=16,
        }
        public enum enPermissonsForTransaction
        {
            Deposit = 1, Withdraw = 2, Transfer = 4, TransactionRecord = 8
        }

        enum enMode { AddNew=0,Update=1}
        public int PermissionsID { get; set; }
        public byte PermissionsForClient { get; set; }
        public byte PermissionsForUser { get; set; }
        public byte PermissionsForEmployee { get; set; }
        public byte PermissionsForAppliaction { get; set; }
        public byte PermissionsForTransaction { get; set; }
        public bool PermissionsForLogRegisters { get; set; }
        enMode _Mode;

        public clsPermissions()
        {
          
            this.PermissionsID = -1;
            this.PermissionsForUser = 0;
            this.PermissionsForTransaction = 0;
            this.PermissionsForLogRegisters = false;
            this.PermissionsForEmployee = 0;
            this.PermissionsForClient = 0;
            this.PermissionsForAppliaction = 0;
            _Mode = enMode.AddNew;
        }
        private clsPermissions(int PermissionsID, byte PermissionsForClient, byte PermissionsForUser,
            byte PermissionsForEmployee, byte PermissionsForAppliaction, byte PermissionsForTransaction
            , bool PermissionsForLogRegisters)
        {
            this.PermissionsID = PermissionsID;
            this.PermissionsForClient = PermissionsForClient;
            this.PermissionsForUser = PermissionsForUser;
            this.PermissionsForEmployee = PermissionsForEmployee;
            this.PermissionsForAppliaction = PermissionsForAppliaction;
            this.PermissionsForTransaction = PermissionsForTransaction;
            this.PermissionsForLogRegisters = PermissionsForLogRegisters;
            _Mode = enMode.Update;
        }
        public static clsPermissions Find(int PermissionsID)
        {
            byte PermissionsForClient = 0, PermissionsForUser = 0, PermissionsForEmployee = 0,
                PermissionsForAppliaction = 0, PermissionsForTransaction = 0;
            bool PermissionsForLogRegisters = false;

            if(clsPermissionsData.GetPermissionsByID(PermissionsID,ref PermissionsForClient,ref PermissionsForUser,
                ref PermissionsForEmployee,ref PermissionsForAppliaction, ref PermissionsForTransaction,
                ref PermissionsForLogRegisters))
            {
                return new clsPermissions(PermissionsID, PermissionsForClient, PermissionsForUser, PermissionsForEmployee,
                    PermissionsForAppliaction, PermissionsForTransaction, PermissionsForLogRegisters);
                
            }


            return null;
        }
        bool _AddNewPermissions()
        {
            this.PermissionsID = clsPermissionsData.AddNewPermissions(this.PermissionsForClient, this.PermissionsForUser,
                this.PermissionsForEmployee, this.PermissionsForAppliaction, this.PermissionsForTransaction,
                this.PermissionsForLogRegisters);

            return this.PermissionsID != -1;
        }
        bool _UpdatePermissions()
        {
            return clsPermissionsData.UpdatePermissions(this.PermissionsID, this.PermissionsForClient,
                this.PermissionsForUser,this.PermissionsForEmployee, this.PermissionsForAppliaction,
                this.PermissionsForTransaction, this.PermissionsForLogRegisters);

        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPermissions())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdatePermissions();

                default:
                    return false;
            }
        }
    }
}
