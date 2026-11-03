using System;
using System.ComponentModel;
using System.Windows.Forms;
using Bank_Business;
using BankManagementSystem.GlobleClass;
namespace BankManagementSystem.Transaction
{
    public partial class frmTransfer : Form
    {
        int _SentClientID;
        int _DesBankAccountID;
        clsClient _SentClient;
        clsClient _DesClient;
        bool _SentClientFound = false;
        public frmTransfer(int ClientID=-1)
        {
            InitializeComponent();
            _SentClientID = ClientID;
            _SentClientFound = _SentClientID != -1;
           
        }

    

   

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {

                MessageBox.Show("Some fileds are noy valide!, put thhe mouse over the red icon(s) to see the erro",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            int Amount = Convert.ToInt32(tbAmount.Text);
            
            _SentClient = clsClient.Find(_SentClientID);
            if (_SentClient.BankAccountID == _DesBankAccountID)
            {
                MessageBox.Show("The sender and the receiver are the same person, please change the information");
                return;
            }
            if (_SentClient.BankAccountInfo.Amount < Amount)
            {
                MessageBox.Show("The amount cannot be transferred because your account does not have the required amount",
                    "Waring",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
            if (_SentClient.Tarnsfer(_DesBankAccountID, Amount, clsGloble.CurrentUser.UserID))
            {
                MessageBox.Show("The operation was successful");
                ctrlBankAccountFilterDestionstion.LoadBankAccount(_DesBankAccountID);
                ctrlBankAccountFilterSoures.LoadBankAccount(_SentClient.BankAccountID.Value);
                ctrlBankAccountFilterDestionstion.Enabled = false;
                ctrlBankAccountFilterSoures.Enabled = false;
                btnTransfer.Enabled = false;

            }
            else
                MessageBox.Show("The operation was Falied");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbAmount_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbAmount.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbAmount, "This field should not be empty");
            }
            else
                errorProvider1.SetError(tbAmount, null);
        }

        private void tbAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void frmTransfer_Load(object sender, EventArgs e)
        {
            if (_SentClientID != -1)
            {
                _SentClient = clsClient.Find(_SentClientID);
                tabControl1.SelectedTab = tpClientDestination;
                tpClientSoures.Enabled = false;
                ctrlBankAccountFilterSoures.LoadBankAccount(_SentClient.BankAccountID.Value);
            }
        }

        private void ctrlBankAccountFilterSoures_OnClientSelected(object sender, Appliaction.Control.ctrlBankAccountFilter.CoustemEventArgs e)
        {
            if(e.ClientID != -1)
            {
                _SentClientID = e.ClientID;
            }
        }

        private void ctrlBankAccountFilterDestionstion_OnClientSelected(object sender, Appliaction.Control.ctrlBankAccountFilter.CoustemEventArgs e)
        {
            if (e.ClientID != -1)
            {
                _DesBankAccountID = e.BankAccountID;
            }
        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_SentClientID == -1&&tabControl1.SelectedTab==tpClientDestination)
            {
                tabControl1.SelectedTab = tpClientSoures;
                MessageBox.Show("Please enter Soures client begin");

            }
        }
    }
}
