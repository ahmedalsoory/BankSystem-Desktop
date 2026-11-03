using System;
using System.Windows.Forms;
using Bank_Business;
namespace BankManagementSystem.Appliaction.Control
{
    public partial class ctrlFilterClient : UserControl
    {

        public bool FilterEnable
        {
            set
            {
                gbFilter.Enabled = value;
            }
        }
        public bool FilterVisble
        {
            set
            {
                gbFilter.Visible = value;
            }
        }

        public ctrlFilterClient()
        {
            InitializeComponent();
        }

        public class ClientSelectedEventArgs : EventArgs
        {
            public int ClientID { get; }
            public ClientSelectedEventArgs(int ClientID)
            {
                this.ClientID = ClientID;
            }
        }
        public event EventHandler<ClientSelectedEventArgs> OnClientSelected;

        protected virtual void RaiseOnClientSelected(ClientSelectedEventArgs e)
        {
            OnClientSelected?.Invoke(this, e);
        }
        void _FindClient()
        {
            int ClientID = -1;

            switch (cbFindBy.Text)
            {
                case "Client ID":
                    ClientID = Convert.ToInt32(tbFilter.Text);
                    if (clsClient.IsExist(ClientID,clsClient.enExistByInt.ClientID))
                    {
                        MessageBox.Show("Client is Found");
                    }
                    else
                        ClientID = -1;
                    break;

                case "NationalNumber":

                    if (clsClient.IsExist(tbFilter.Text,clsClient.enExistByString.NationalNumber))
                    {
                        ClientID = clsClient.FindByNationalNumber(tbFilter.Text).ClientID;
                        MessageBox.Show("Client is Found");
                  
                    }
                    break;
                case "Bank Account ID":

                    if (clsClient.IsExist(Convert.ToInt32(tbFilter.Text),clsClient.enExistByInt.BankAcountID))
                    {
                        ClientID = clsClient.FindBankAccountID(Convert.ToInt32(tbFilter.Text)).ClientID;

                        MessageBox.Show("Client is Found");

                    }
                    break;
                case "Account Number":
                    if (clsClient.IsExist(tbFilter.Text,clsClient.enExistByString.AccountNumber))
                    {
                        ClientID = clsClient.Find(tbFilter.Text).ClientID;
                        MessageBox.Show("Client is Found");
                      
                    }
                    break;
                case "Visa ID":
                    if(clsClient.IsExist(Convert.ToInt32(tbFilter.Text),clsClient.enExistByInt.VisaID))
                    {
                        ClientID = clsClient.FindByVisaID(Convert.ToInt32(tbFilter.Text)).ClientID;
                        MessageBox.Show("Client is Found");
                    }
                    break;

                case "Visa Number":
                    if (clsClient.IsExist(tbFilter.Text,clsClient.enExistByString.VisaNumber))
                    {
                        ClientID = clsClient.FindByVisaNumber(tbFilter.Text).ClientID;
                        MessageBox.Show("Client is Found");
                    }
                    break;
            }
            if (ClientID == -1)
            {
                MessageBox.Show("Client is Not Found");
                tbFilter.SelectAll();
                tbFilter.Focus();
            }

            if (OnClientSelected != null)
                RaiseOnClientSelected(new ClientSelectedEventArgs(ClientID));

        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            _FindClient();
        }

        private void cbFindBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFilter.Clear();
        }
        private void ctrlFilterClient_Load(object sender, EventArgs e)
        {
            cbFindBy.SelectedIndex = 0;
        }
        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void gbFilter_Enter(object sender, EventArgs e)
        {

        }

        private void tbFilter_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbFilter.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbFilter, "This field should not be empty");
                return;
            }
            else
                errorProvider1.SetError(tbFilter, null);

            if (cbFindBy.Text == "Account Number" && tbFilter.Text.Trim().Length != 6)
            {

                e.Cancel = true;
                errorProvider1.SetError(tbFilter, "The field consists of 6 digits");
                return;
            }
            else
                errorProvider1.SetError(tbFilter, null);

            if (cbFindBy.Text == "Visa Number" && tbFilter.Text.Trim().Length != 9)
            {

                e.Cancel = true;
                errorProvider1.SetError(tbFilter, "The field consists of 9 digits");
                return;
            }
            else
                errorProvider1.SetError(tbFilter, null);
        }

        private void tbFilter_Leave(object sender, EventArgs e)
        {
           

        }
    }
}
