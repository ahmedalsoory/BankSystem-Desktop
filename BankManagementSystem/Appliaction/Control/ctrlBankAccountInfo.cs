using System;
using System.Windows.Forms;
using Bank_Business;
using BankManagementSystem.Client;
namespace BankManagementSystem.Appliaction.Control
{
    public partial class ctrlBankAccountInfo : UserControl
    {
        public ctrlBankAccountInfo()
        {
            InitializeComponent();
        }
        public clsBankAccount BankAccountInfo;
        int _ClientID;
        void _FillData(ref clsClient client)
        {
            lbAccountNumber.Text = client.BankAccountInfo.AccountNumber;
            lbAmount.Text = client.BankAccountInfo.Amount.ToString();
            lbApplicationID.Text = client.BankAccountInfo.ApplicationID.ToString();
            lbID.Text = client.BankAccountID.Value.ToString();
            lbIsActive.Text = (client.BankAccountInfo.IsActive) ? "Yes" : "No";
            lbPinCode.Text = client.BankAccountInfo.PinCode;
        }
        void _ToolStripMenuItemEnabled(bool Enabled)
        {
            clientInfoToolStripMenuItem.Enabled = Enabled;
            appliactionInfoToolStripMenuItem.Enabled = Enabled;
        }
        public void LoadBankAccountInfo(int BankAccountID,ref int ClientID)
        {
            clsClient client = clsClient.FindBankAccountID(BankAccountID);
            if (client == null)
            {
                MessageBox.Show("Client Not Found");
                BankAccountInfo = null;
                DefaultCard();
                ClientID = -1;
                _ToolStripMenuItemEnabled(false);
                return;
            }
            ClientID = client.ClientID;
            BankAccountInfo = client.BankAccountInfo;
            _ClientID = client.ClientID;
            _ToolStripMenuItemEnabled(true);
            _FillData(ref client);
        }
        public void LoadBankAccountInfo(string AccountNumber, ref int ClientID)
        {
            clsClient client = clsClient.Find(AccountNumber);
            if (client == null)
            {
                MessageBox.Show("Client Not Found");
                DefaultCard();
                BankAccountInfo = null;
                _ToolStripMenuItemEnabled(false);
                ClientID = -1;
                return;
            }
            ClientID = client.ClientID;
            BankAccountInfo = client.BankAccountInfo;
            _ToolStripMenuItemEnabled(true);
            _ClientID = client.ClientID;
            _FillData(ref client);
        }
        public void DefaultCard()
        {
            lbAccountNumber.Text = "[????]";
            lbAmount.Text = "[????]";
            lbApplicationID.Text = "[????]";
            lbID.Text = "[????]";
            lbIsActive.Text = "[????]";
            lbPinCode.Text = "[????]";
        }

        private void clientInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientInfo frm = new frmClientInfo(_ClientID);
            frm.ShowDialog();
        }

        private void appliactionInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAppliactionInfo frm = new frmAppliactionInfo(BankAccountInfo.ApplicationID);
            frm.ShowDialog();
        }
    }
}
