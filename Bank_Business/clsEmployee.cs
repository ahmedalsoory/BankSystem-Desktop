using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BankDataAccess;

namespace Bank_Business
{
    public class clsEmployee : clsPerson
    {
       new enum  enMode { AddNew=0,Update=1}
        public int EmployeeID { get; set; }
        public float Salary { get; set; }
        public  string WorkType { get; set; }
        public int CreatedByUserID { get; set; }

        new enMode _Mode;

        public clsEmployee()
        {
            this.EmployeeID = -1;
            this.Salary = 0;
            this.WorkType = "";
            this.PersonID = -1;
            this.NationalNumber = "";
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.Phone = "";
            this.DateOfBirth = DateTime.Now;
            this.Gendor = enGendor.Male;
            _Mode = enMode.AddNew;
        }

        private clsEmployee(int EmployeeID, float Salary, string WorkType, int PersonID,int CreatedByUserID,bool PersonData=false)
        {
            this.EmployeeID = EmployeeID;
            this.Salary = Salary;
            this.WorkType = WorkType;
            this.CreatedByUserID = CreatedByUserID;
            base.PersonID = PersonID;

            if (PersonData) {
                clsPerson person = clsPerson.Find(PersonID);
                base.NationalNumber = person.NationalNumber;
                base.FirstName = person.FirstName;
                base.SecondName = person.SecondName;
                base.ThirdName = person.ThirdName;
                base.LastName = person.LastName;
                base.Phone = person.Phone;
                base.DateOfBirth = person.DateOfBirth;
                base.Gendor = person.Gendor;
            }

            _Mode = enMode.Update;
        }
        
        public new static clsEmployee Find(int EmployeeID,bool PersonData=false)
        {
            float Salary = 0;
            string WorkType = "";
            int PersonID = -1, UserID=-1;
            if(clsEmployeesData.GetEmployeeByID(EmployeeID,ref Salary,ref WorkType ,ref PersonID,ref UserID))
            {
            
                return new clsEmployee(EmployeeID, Salary, WorkType, PersonID,UserID, PersonData);
            }


            return null;
        }
        public new static clsEmployee Find(string NationalNumber ,bool PersonData= false)
        {
            float Salary = 0;
            string WorkType = "";
            int PersonID = -1, UserID = -1, EmployeeID=-1;
            if (clsEmployeesData.GetEmployeeByNationalNumber(NationalNumber,ref EmployeeID, ref Salary, ref WorkType, ref PersonID, ref UserID))
            {
    
                return new clsEmployee(EmployeeID, Salary, WorkType, PersonID, UserID, PersonData);
            }


            return null;
        }
        public  static clsEmployee FindByPersonID(int PersonID, bool PersonData = false)
        {
            float Salary = 0;
            string WorkType = "";
            int EmployeeID = -1, UserID = -1;
            if (clsEmployeesData.GetEmployeeByPersonID(PersonID,ref EmployeeID, ref Salary, ref WorkType, ref UserID))
            {

                return new clsEmployee(EmployeeID, Salary, WorkType, PersonID, UserID, PersonData);
            }


            return null;
        }
        bool _AddNewEmployee()
        {
            this.EmployeeID = clsEmployeesData.AddNewEmployee(this.Salary, this.WorkType, this.PersonID,this.CreatedByUserID);
            return this.EmployeeID != -1;
        }
        bool _UpdateEmployee()
        {
            return clsEmployeesData.UpdateEmployee(this.EmployeeID, this.Salary, this.WorkType);
        }
        public new bool Save()
        {
            base._Mode = (clsPerson.enMode)_Mode;
            bool isExist = clsPerson.IsExist(this.NationalNumber);
            if (!isExist || isExist && _Mode == enMode.Update)
                if (!base.Save()) return false;

            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewEmployee())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdateEmployee();

                default:
                    return false;
            }

        }

        public static new bool IsExist(int EmployeeID)
        {
            return clsEmployeesData.IsEmployeeExist(EmployeeID);
        }
        public static bool IsEmployeeExistByPersonID(int PersonID)
        {
            return clsEmployeesData.IsEmployeeExistByPersonID(PersonID);
        }

        public static new DataTable GetAllData()
        {
            return clsEmployeesData.GetAllEmployees();
        }
        public static new bool Delete(int EmployeeID)
        {
            if (clsUser.isUserExistByEmployeeID(EmployeeID))
                return MarkForDeleted(EmployeeID);
            return clsEmployeesData.DeleteEmployee(EmployeeID);
        }
        public  bool Delete()
        {
            return Delete(this.EmployeeID);
        }
        protected static new bool MarkForDeleted(int EmployeeID) // this function using when delete user only 
        {
            int PersonID = Find(EmployeeID).PersonID;

            if (!clsClient.IsExist(PersonID))
                clsPerson.MarkForDeleted(PersonID);
            return clsEmployeesData.MarkForDeleted(EmployeeID);
        }
        protected new bool MarkForDeleted() // this function using when delete user only 
        {
            if (!clsClient.IsExist(this.PersonID))
                base.MarkForDeleted();
            return clsEmployeesData.MarkForDeleted(this.EmployeeID);
        }
    }
}
