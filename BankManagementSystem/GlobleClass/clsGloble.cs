using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank_Business;
namespace BankManagementSystem.GlobleClass
{
   public static class clsGloble
    {
        public enum enSubClasses { Client = 1, Employee = 2 }


        public static clsUser CurrentUser = null;

        public static bool IsPersonExistAnySubClasses(enSubClasses ClassNotSearch, int PersonID)
        {

            switch (ClassNotSearch)
            {
                case enSubClasses.Client:
                    return clsEmployee.IsEmployeeExistByPersonID(PersonID);
                case enSubClasses.Employee:
                    return clsClient.IsExist(PersonID,clsClient.enExistByInt.PersonID); 
            }
            return false;
        }



    }
}
