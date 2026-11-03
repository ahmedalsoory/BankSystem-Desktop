using BankManagementSystem.Client;
using BankManagementSystem.People;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankManagementSystem.Employee;
using BankManagementSystem.Login;
using BankManagementSystem.Users;
using BankManagementSystem.LoginRegisters;
using BankManagementSystem.Appliaction;
using BankManagementSystem.Appliaction.AppliactionType;
using BankManagementSystem.Transaction;
using Bank_Business;
namespace BankManagementSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new frmOpenBankAccount(17));
             Application.Run(new frmLogin());
          //   Application.Run(new frmLoginRegisters());

        }
    }
}
