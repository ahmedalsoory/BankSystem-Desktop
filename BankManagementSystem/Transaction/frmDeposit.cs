using System;
using System.ComponentModel;
using System.Windows.Forms;
using BankManagementSystem.GlobleClass;
using Bank_Business;
namespace BankManagementSystem.Transaction
{
    public partial class frmDeposit : Form
    {
        int _ClientID;
        clsAccountTransactions.enAccountTransactionType _TransactionType;
        public frmDeposit(clsAccountTransactions.enAccountTransactionType TransactionType, int ClientID = -1)
        {
            InitializeComponent();
            _ClientID = ClientID;
            _TransactionType = TransactionType;
        }

        private void frmDeposit_Load(object sender, EventArgs e)
        {
            ctrlBankAccountFilter1.FindVisble = (_ClientID == -1);
            if (_ClientID != -1)
            {
                ctrlBankAccountFilter1.LoadBankAccount(clsClient.Find(_ClientID).BankAccountID.Value);
                btnDeposit.Enabled = true;
            }
            switch (_TransactionType)
            {
                case clsAccountTransactions.enAccountTransactionType.Deposit:
                    this.Text = this.btnDeposit.Text = lbTitle.Text = "Deposit";
                    break;

                case clsAccountTransactions.enAccountTransactionType.Withdraw:
                    this.Text = this.btnDeposit.Text = lbTitle.Text = "Withdraw";

                    break;
            }
        }

        private void ctrlBankAccountFilter1_OnClientSelected(object sender, Appliaction.Control.ctrlBankAccountFilter.CoustemEventArgs e)
        {
            _ClientID = e.ClientID;
            btnDeposit.Enabled = (e.ClientID != -1);
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {

                MessageBox.Show("Some fileds are noy valide!, put thhe mouse over the red icon(s) to see the erro",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }


            float Amount = Convert.ToSingle(tbAmount.Text);
            clsClient client = clsClient.Find(_ClientID);
            if (_TransactionType == clsAccountTransactions.enAccountTransactionType.Withdraw)
            {
                if (!(client.BankAccountInfo.Amount > Amount + 50))
                {
                    errorProvider1.SetError(tbAmount, "The value to be withdrawn is greater than the value inside your account");
                    return;
                }
                errorProvider1.SetError(tbAmount, null);
                if (!client.Withdraw(Amount, clsGloble.CurrentUser.UserID))
                {
                     MessageBox.Show("The operation was Falied");
                     return;
                }
                MessageBox.Show("The operation was successful");
                ctrlBankAccountFilter1.LoadBankAccount(client.BankAccountID.Value);
                btnDeposit.Enabled = false;
                tbAmount.Enabled = false;
                ctrlBankAccountFilter1.FindEnable = false;

            }
            else
            {
                if (client.Deposit(Amount, clsGloble.CurrentUser.UserID))
                {

                    MessageBox.Show("The operation was successful");
                    ctrlBankAccountFilter1.LoadBankAccount(client.BankAccountID.Value);
                    btnDeposit.Enabled = false;
                    tbAmount.Enabled = false;
                    ctrlBankAccountFilter1.FindEnable = false;
                }
                else
                {
                    MessageBox.Show("The operation was Falied");
                }
            }
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
    }
}
