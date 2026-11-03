using System;
using System.Windows.Forms;
using BankManagementSystem.Client;
using BankManagementSystem.Employee;
using BankManagementSystem.Users;
using BankManagementSystem.Appliaction;
using BankManagementSystem.LoginRegisters;
using BankManagementSystem.Appliaction.AppliactionType;
using BankManagementSystem.Transaction;
using BankManagementSystem.GlobleClass;
using Bank_Business;
namespace BankManagementSystem
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void appliactionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
   
            frmListClient frm = new frmListClient();
            frm.ShowDialog();
        }

        private void emplyeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListEmployee frm = new frmListEmployee();
            frm.ShowDialog();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListUser frm = new frmListUser();
            frm.ShowDialog();
        }

        private void logRegistersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoginRegisters frm = new frmLoginRegisters();
            frm.ShowDialog();
        }

        private void chequeBookIssuanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (((clsGloble.CurrentUser.PermissionsInfo.PermissionsForAppliaction) & Convert.ToByte(clsPermissions.enPermissonsForAppliaction.ChequeBookIssuance))
         != Convert.ToByte(clsPermissions.enPermissonsForAppliaction.ChequeBookIssuance))
            {
                MessageBox.Show("do not have Permissions you should reviews the admin");
                return;
            }

            frmChequeBookIssuance frm = new frmChequeBookIssuance();
            frm.ShowDialog();
        }

        private void openBankAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (((clsGloble.CurrentUser.PermissionsInfo.PermissionsForAppliaction) & Convert.ToByte(clsPermissions.enPermissonsForAppliaction.OpenBankAccount))
        != Convert.ToByte(clsPermissions.enPermissonsForAppliaction.OpenBankAccount))
            {
                MessageBox.Show("do not have Permissions you should reviews the admin");
                return;
            }
            frmOpenBankAccount frm = new frmOpenBankAccount();
            frm.ShowDialog();
        }

        private void versionVisaFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (((clsGloble.CurrentUser.PermissionsInfo.PermissionsForAppliaction) & Convert.ToByte(clsPermissions.enPermissonsForAppliaction.VersionVisaFirstTime))
   != Convert.ToByte(clsPermissions.enPermissonsForAppliaction.VersionVisaFirstTime))
            {
                MessageBox.Show("do not have Permissions you should reviews the admin");
                return;
            }
            frmIssueVisa frm = new frmIssueVisa();
            frm.ShowDialog();
        }

        private void mangeAppliactionTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListAppliactionType frm = new frmListAppliactionType();
            frm.ShowDialog();
        }

        private void replaceVisaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (((clsGloble.CurrentUser.PermissionsInfo.PermissionsForAppliaction) & Convert.ToByte(clsPermissions.enPermissonsForAppliaction.ReplaceVisa))
   != Convert.ToByte(clsPermissions.enPermissonsForAppliaction.ReplaceVisa))
            {
                MessageBox.Show("do not have Permissions you should reviews the admin");
                return;
            }
            frmReplaceVisa frm = new frmReplaceVisa();
            frm.ShowDialog();
        }

        private void renewVisaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (((clsGloble.CurrentUser.PermissionsInfo.PermissionsForAppliaction) & Convert.ToByte(clsPermissions.enPermissonsForAppliaction.RenewVisa))
   != Convert.ToByte(clsPermissions.enPermissonsForAppliaction.RenewVisa))
            {
                MessageBox.Show("do not have Permissions you should reviews the admin");
                return;
            }
            frmRenewVisa frm = new frmRenewVisa();
            frm.ShowDialog();
        }

        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (((clsGloble.CurrentUser.PermissionsInfo.PermissionsForTransaction) & Convert.ToByte(clsPermissions.enPermissonsForTransaction.Deposit))
   != Convert.ToByte(clsPermissions.enPermissonsForTransaction.Deposit))
            {
                MessageBox.Show("do not have Permissions you should reviews the admin");
                return;
            }
            frmDeposit frm = new frmDeposit(clsAccountTransactions.enAccountTransactionType.Deposit);
            frm.ShowDialog();
        }

        private void withdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (((clsGloble.CurrentUser.PermissionsInfo.PermissionsForTransaction) & Convert.ToByte(clsPermissions.enPermissonsForTransaction.Withdraw))
!= Convert.ToByte(clsPermissions.enPermissonsForTransaction.Withdraw))
            {
                MessageBox.Show("do not have Permissions you should reviews the admin");
                return;
            }
            frmDeposit frm = new frmDeposit(clsAccountTransactions.enAccountTransactionType.Withdraw);
            frm.ShowDialog();

        }

        private void transferToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (((clsGloble.CurrentUser.PermissionsInfo.PermissionsForTransaction) & Convert.ToByte(clsPermissions.enPermissonsForTransaction.Transfer))
!= Convert.ToByte(clsPermissions.enPermissonsForTransaction.Transfer))
            {
                MessageBox.Show("do not have Permissions you should reviews the admin");
                return;
            }

            frmTransfer frm = new frmTransfer();
            frm.ShowDialog();
        }

        private void transactionRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (((clsGloble.CurrentUser.PermissionsInfo.PermissionsForTransaction) & Convert.ToByte(clsPermissions.enPermissonsForTransaction.TransactionRecord))
!= Convert.ToByte(clsPermissions.enPermissonsForTransaction.TransactionRecord))
            {
                MessageBox.Show("do not have Permissions you should reviews the admin");
                return;
            }
            frmTransactionRecord frm = new frmTransactionRecord();
            frm.ShowDialog();
        }

        private void userInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserInfo frm = new frmUserInfo(clsGloble.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangePassword frm = new frmChangePassword(clsGloble.CurrentUser.UserID);
            frm.ShowDialog();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
