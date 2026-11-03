using System;
using System.ComponentModel;
using System.Windows.Forms;
using BankManagementSystem.Client;
using Bank_Business;
namespace BankManagementSystem.Appliaction.Control
{
    public partial class ctrlBankAccountFilter : UserControl
    {
        public ctrlBankAccountFilter()
        {
            InitializeComponent();
        }
        int _ClientID=-1;
        public bool FindEnable { 
            set 
            {
                gbFind.Enabled = value;

            }
        }
        public bool FindVisble
        {
            set
            {
                gbFind.Visible = value;

            }

        }
        public int ClientID { get { return _ClientID; } }
        public class CoustemEventArgs : EventArgs
        {
            public int ClientID;
            public int BankAccountID;

            public CoustemEventArgs(int ClientID,int BankAccountID)
            {
                this.ClientID = ClientID;
                this.BankAccountID = BankAccountID;
            }

        }
        public event EventHandler<CoustemEventArgs> OnClientSelected;
        public void LoadBankAccount(int BankAccountID)
        {
            ctrlBankAccountInfo1.LoadBankAccountInfo(BankAccountID,ref _ClientID);
            if(_ClientID != -1)
            {
                tbFind.Text = BankAccountID.ToString();
            }
        }

        protected virtual void RaiseOnClientSelected(CoustemEventArgs e)
        {
            OnClientSelected?.Invoke(this, e);
        }
        public clsBankAccount BankAccountInfo { get { return ctrlBankAccountInfo1.BankAccountInfo; } }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            _ClientID = -1;
            switch (cbFilter.Text)
            {
                case "Bank Account ID":
                    ctrlBankAccountInfo1.LoadBankAccountInfo(Convert.ToInt32(tbFind.Text),ref _ClientID);
                    break;

                case "Account Number":
                    ctrlBankAccountInfo1.LoadBankAccountInfo(tbFind.Text, ref _ClientID);
                    break;
            }
            if (_ClientID == -1)
            {
                tbFind.Focus();
                tbFind.SelectAll();
                showAppliactionInfoToolStripMenuItem.Enabled = false;
                showClientInfoToolStripMenuItem.Enabled = false;
            }
            else
            {
                showAppliactionInfoToolStripMenuItem.Enabled = true;
                showClientInfoToolStripMenuItem.Enabled = true;
            }
            if (OnClientSelected != null && ctrlBankAccountInfo1.BankAccountInfo != null)
                RaiseOnClientSelected(new CoustemEventArgs(ClientID, ctrlBankAccountInfo1.BankAccountInfo.BankAccountID));
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFind.Clear();
        }
        private void tbFind_Validating(object sender, CancelEventArgs e)
        {
            if (!gbFind.Enabled || !gbFind.Visible) return;
            if (string.IsNullOrEmpty(tbFind.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbFind, "This field doesn't have to be empty.");

            }
            else
                errorProvider1.SetError(tbFind, null);

        }
        private void tbFind_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void ctrlBankAccountFilter_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0;
        }

        private void showClientInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientInfo frm = new frmClientInfo(_ClientID);
            frm.ShowDialog();
        }

        private void showAppliactionInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAppliactionInfo frm = new frmAppliactionInfo(ctrlBankAccountInfo1.BankAccountInfo.ApplicationID);
            frm.ShowDialog();
        }
    }
}
