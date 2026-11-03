using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankManagementSystem.People;
using Bank_Business;
using BankManagementSystem.GlobleClass;
using BankManagementSystem.Appliaction;
using BankManagementSystem.Transaction;
namespace BankManagementSystem.Client
{
    public partial class frmListClient : Form
    {
        static DataTable _dtAllClient = clsClient.GetAllData();
        DataTable _dtClient = _dtAllClient.DefaultView.ToTable(false, "ClientID","PersonID", "FirstName"
                                                       , "SecondName", "ThirdName", "LastName");
        public frmListClient()
        {
            InitializeComponent();
        }

        void _RefreshClientList()
        {
            _dtAllClient = clsClient.GetAllData();
            _dtClient= _dtAllClient.DefaultView.ToTable(false, "ClientID", "PersonID", "FirstName"
                                                       , "SecondName", "ThirdName", "LastName");

            dgvClientList.DataSource = _dtClient;
            lbReocrd.Text = dgvClientList.Rows.Count.ToString();
        }

        private void showPersonalInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonInfo frm = new frmPersonInfo((int)dgvClientList.SelectedRows[0].Cells[1].Value);
            frm.ShowDialog();
        }

        private void addNewClientToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (((clsGloble.CurrentUser.PermissionsInfo.PermissionsForClient) & Convert.ToByte(clsPermissions.enPermissonsForClient.AddClient))
                       != Convert.ToByte(clsPermissions.enPermissonsForClient.AddClient))
            {
                MessageBox.Show("do not have Permissions you should reviews the admin");
                return;
            }
            frmAddEditClient frm = new frmAddEditClient();
            frm.ShowDialog();
            _RefreshClientList();

        }

        private void updateClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (((clsGloble.CurrentUser.PermissionsInfo.PermissionsForClient) & Convert.ToByte(clsPermissions.enPermissonsForClient.UpdateClient))
                        != Convert.ToByte(clsPermissions.enPermissonsForClient.UpdateClient))
            {
                MessageBox.Show("do not have Permissions you should reviews the admin");
                return;
            }
            frmAddEditClient frm = new frmAddEditClient((int)dgvClientList.SelectedRows[0].Cells[0].Value);
            frm.ShowDialog();
            _RefreshClientList();

        }

        private void deleteClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (((clsGloble.CurrentUser.PermissionsInfo.PermissionsForClient) & Convert.ToByte(clsPermissions.enPermissonsForClient.DeleteClient))
                       != Convert.ToByte(clsPermissions.enPermissonsForClient.DeleteClient))
            {
                MessageBox.Show("do not have Permissions you should reviews the admin");
                return;
            }


            if (MessageBox.Show("Are you soure delete this Client", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
                == DialogResult.Yes)
            {
                int PersonID = (int)dgvClientList.SelectedRows[0].Cells[1].Value;
                int ClientID= (int)dgvClientList.SelectedRows[0].Cells[0].Value;
                bool ClientDeleted = clsClient.Delete(ClientID);
                if (!ClientDeleted)
                {
                    MessageBox.Show("Client Deleted Failed");
                    return;
                }
                if (clsGloble.IsPersonExistAnySubClasses(clsGloble.enSubClasses.Client, PersonID))
                {
                        MessageBox.Show("Client Deleted Seccued");
                        return;
                }
                else
                {
                        if(clsPerson.Delete(PersonID))
                            MessageBox.Show("Client Deleted Seccued");
                        else
                            MessageBox.Show("Client Deleted Failed");

                }
                _RefreshClientList();
                
            }
        }

        private void frmListClient_Load(object sender, EventArgs e)
        {
            dgvClientList.DataSource = _dtClient;

            if (dgvClientList.Rows.Count > 0)
            {
                dgvClientList.Columns[0].HeaderText = "Client ID.";
                dgvClientList.Columns[0].Width = 120;
                dgvClientList.Columns[1].HeaderText = "Person ID";
                dgvClientList.Columns[1].Width = 110;
                dgvClientList.Columns[2].HeaderText = "First Name";
                dgvClientList.Columns[2].Width = 120;
                dgvClientList.Columns[3].HeaderText = "Second Name";
                dgvClientList.Columns[3].Width = 140;
                dgvClientList.Columns[4].HeaderText = "Third Name";
                dgvClientList.Columns[4].Width = 120;
                dgvClientList.Columns[5].HeaderText = "Last Name";
                dgvClientList.Columns[5].Width = 120;
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addNewClientToolStripMenuItem_Click(null, null);
        }

        private void chequeBookIssuanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (((clsGloble.CurrentUser.PermissionsInfo.PermissionsForAppliaction) & Convert.ToByte(clsPermissions.enPermissonsForAppliaction.ChequeBookIssuance))
                       != Convert.ToByte(clsPermissions.enPermissonsForAppliaction.ChequeBookIssuance))
            {
                MessageBox.Show("do not have Permissions you should reviews the admin");
                return;
            }

            frmChequeBookIssuance frm = new frmChequeBookIssuance(
                Convert.ToInt32(dgvClientList.SelectedRows[0].Cells[0].Value));
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

            frmOpenBankAccount frm = new frmOpenBankAccount(
                Convert.ToInt32(dgvClientList.SelectedRows[0].Cells[0].Value));
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


            frmIssueVisa frm = new frmIssueVisa(
                Convert.ToInt32(dgvClientList.SelectedRows[0].Cells[0].Value));
            frm.ShowDialog();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            int ClientID = Convert.ToInt32(dgvClientList.SelectedRows[0].Cells[0].Value);
            bool isExist = clsClient.isClientHasBankAccount(ClientID);
            bool isClientHasVisa= clsClient.IsClientHasVisa(ClientID);
            openBankAccountToolStripMenuItem.Enabled = !isExist;
            transactionToolStripMenuItem.Enabled = isExist;
            chequeBookIssuanceToolStripMenuItem.Enabled = isExist;
            visaToolStripMenuItem.Enabled = isExist;
            if (visaToolStripMenuItem.Enabled)
            {
                versionVisaFirstTimeToolStripMenuItem.Enabled = isExist && !isClientHasVisa;
                replaceVisaToolStripMenuItem.Enabled = !versionVisaFirstTimeToolStripMenuItem.Enabled;
                renewVisaToolStripMenuItem.Enabled = replaceVisaToolStripMenuItem.Enabled;
            }
        }

        private void replaceVisaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (((clsGloble.CurrentUser.PermissionsInfo.PermissionsForAppliaction) & Convert.ToByte(clsPermissions.enPermissonsForAppliaction.ReplaceVisa))
                      != Convert.ToByte(clsPermissions.enPermissonsForAppliaction.ReplaceVisa))
            {
                MessageBox.Show("do not have Permissions you should reviews the admin");
                return;
            }

            frmReplaceVisa frm = new frmReplaceVisa(
                Convert.ToInt32(dgvClientList.SelectedRows[0].Cells[0].Value));
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
            frmRenewVisa frm = new frmRenewVisa(
               Convert.ToInt32(dgvClientList.SelectedRows[0].Cells[0].Value));
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
            frmDeposit frm = new frmDeposit(clsAccountTransactions.enAccountTransactionType.Deposit,
                Convert.ToInt32(dgvClientList.SelectedRows[0].Cells[0].Value));
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

            frmDeposit frm = new frmDeposit(clsAccountTransactions.enAccountTransactionType.Withdraw,
                Convert.ToInt32(dgvClientList.SelectedRows[0].Cells[0].Value));
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
            frmTransfer frm = new frmTransfer(
                Convert.ToInt32(dgvClientList.SelectedRows[0].Cells[0].Value));
            frm.ShowDialog();
        }
    }
}
