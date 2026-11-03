using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BankDataAccess;
namespace Bank_Business
{
    public class clsPerson
    {

        public enum enGendor { Male=0,Female=1 }
        protected enum enMode { AddNew=0,Update=1}
        public int PersonID { get; set; }
        public string NationalNumber { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public enGendor Gendor { get; set; }
        public string FullName
        {
            get { return FirstName + " " + SecondName + " " + ThirdName + " " + LastName; }
        }
        protected enMode _Mode;
        public clsPerson()
        {
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
        private clsPerson(int PersonID, string NationalNumber, string FirstName, string SecondName, string ThirdName
              , string LastName, string Phone, DateTime DateOfBirth, enGendor Gendor)
        {
            this.PersonID = PersonID;
            this.NationalNumber = NationalNumber;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.Phone = Phone;
            this.DateOfBirth = DateOfBirth;
            this.Gendor = Gendor;
            _Mode = enMode.Update;
        }
        public  static clsPerson Find(int PersonID)
        {
            string NationalNumber = "", FirstName = "", SecondName = "", ThirdName = "", LastName = "", Phone="";
            DateTime DateOfBirth = DateTime.Now;
            byte Gendor = 0;

            if(clsPeopleData.GetPersonByID(PersonID,ref NationalNumber,ref FirstName,ref SecondName,ref ThirdName,ref LastName,ref Phone,
                ref DateOfBirth,ref Gendor))
            {
                return new clsPerson(PersonID, NationalNumber, FirstName, SecondName, ThirdName, LastName, Phone, DateOfBirth,
                    (enGendor)Gendor);
            }

            return null;
        }
        public static clsPerson Find(string NationalNumber)
        {
            int PersonID = -1;
            string  FirstName = "", SecondName = "", ThirdName = "", LastName = "", Phone = "";
            DateTime DateOfBirth = DateTime.Now;
            byte Gendor = 0;

            if (clsPeopleData.GetPersonByNationalNumber(NationalNumber, ref PersonID, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref Phone,
                ref DateOfBirth, ref Gendor))
            {
                return new clsPerson(PersonID, NationalNumber, FirstName, SecondName, ThirdName, LastName, Phone, DateOfBirth,
                    (enGendor)Gendor);
            }

            return null;
        }

        bool _AddNewPerson()
        {
            
            this.PersonID = clsPeopleData.AddNewPerson(this.NationalNumber, this.FirstName, this.SecondName, this.ThirdName, this.LastName,
                this.Phone, this.DateOfBirth, Convert.ToByte( this.Gendor));

            return this.PersonID != -1;
        }
        bool _UpdatePerson()
        {
            return clsPeopleData.UpdatePerson(this.PersonID,this.NationalNumber,this.FirstName,this.SecondName,this.ThirdName,
                this.LastName,this.Phone,this.DateOfBirth,Convert.ToByte(this.Gendor));
        }
        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:
                    if (_AddNewPerson())
                    {
                        _Mode = enMode.Update;
                        return true;
                    }
                    return false;

                case enMode.Update:
                    return _UpdatePerson();

                default:
                    return false;
            }
        }

        protected  static bool IsExist(int PersonID)
        {
            return clsPeopleData.IsPersonExist(PersonID);
        }
        protected static bool IsExist(string NationalNumber)
        {
            return clsPeopleData.IsPersonExist(NationalNumber);
        }

        public static DataTable GetAllData()
        {
            return clsPeopleData.GetAllPeople();
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType()) return false;

            clsPerson Person1 = (clsPerson)obj;

            return Person1.PersonID == this.PersonID && Person1.NationalNumber == this.NationalNumber
               && Person1.FullName == this.FullName && this.Gendor == Person1.Gendor && Person1.Phone == this.Phone
               && Person1.DateOfBirth == this.DateOfBirth;
        }

        public static bool Delete(int PersonID)
        {
            return clsPeopleData.DeletePerson(PersonID);
        }
        public static  bool MarkForDeleted(int PersonID) // this function using when delete user only 
        {
            return clsPeopleData.MarkForDeleted(PersonID);
        }
        public  bool MarkForDeleted() // this function using when delete user only 
        {
            return clsPeopleData.MarkForDeleted(this.PersonID);
        }
    }
}
