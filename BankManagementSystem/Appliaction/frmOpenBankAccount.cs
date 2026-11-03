using System;
using System.Windows.Forms;
using BankManagementSystem.GlobleClass;
using Bank_Business;
using BankManagementSystem.Client;

namespace BankManagementSystem.Appliaction
{
    public partial class frmOpenBankAccount : Form
    {
        int _ClientID;
        public frmOpenBankAccount(int ClientID=-1)
        {
            InitializeComponent();
            _ClientID = ClientID;
        }

        private void frmOpenBankAccount_Load(object sender, EventArgs e)
        {
            gbFilter.Visible = (_ClientID == -1);
            llClientInfo.Enabled = !gbFilter.Visible;
            if (!gbFilter.Visible) lbClientID.Text = _ClientID.ToString();
        }
        void _FillData(ref clsClient client)
        {
            lbAmount.Text = client.BankAccountInfo.Amount.ToString();
            lbApplicationID.Text = client.BankAccountInfo.ApplicationID.ToString();
            lbBankAccountID.Text = client.BankAccountID.ToString();
            lbClientID.Text = lbClientID.Text;
            lbIsActive.Text = (client.BankAccountInfo.IsActive) ? "Yes" : "No";
            lbPinCode.Text = client.BankAccountInfo.PinCode;
            lbAccountNumber.Text = client.BankAccountInfo.AccountNumber;
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            clsClient client = clsClient.Find(_ClientID);
            if (client.BankAccountID != null)
            {
                MessageBox.Show($"The customer has a prepaid account Bank Account ID = {client.BankAccountID.ToString()}");
                return;
            }
            int AppliactionID = -1;
            if (client.OpenBankAccount(ref AppliactionID,clsGloble.CurrentUser.UserID))
            {
                MessageBox.Show("Account opening process was successful");
                _FillData(ref client);
                btnOpen.Enabled = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int ClientID = Convert.ToInt32(tbFilter.Text);
            if (!clsClient.IsExist(ClientID,clsClient.enExistByInt.ClientID))
            {
                MessageBox.Show("Client Not Found");
                llClientInfo.Enabled = false;
                return;
            }
            _ClientID = ClientID;
            lbClientID.Text = _ClientID.ToString();
            llClientInfo.Enabled = true ;


        }

        private void llClientInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmClientInfo frm = new frmClientInfo(_ClientID);
            frm.ShowDialog();
        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
