using System;
using System.Windows.Forms;
using Bank_Business;
using BankManagementSystem.GlobleClass;
namespace BankManagementSystem.Appliaction
{
    public partial class frmChequeBookIssuance : Form
    {
        int _ClientID;
        public frmChequeBookIssuance(int ClientID=-1)
        {
            InitializeComponent();
            _ClientID = ClientID;
            gbFilter.Visible = _ClientID == -1;
        }

        private void frmChequeBookIssuance_Load(object sender, EventArgs e)
        {
            if (_ClientID != -1)
            {
                ctrlApplicationInfo1.DefaultCard(clsApplication.enApplicationType.ChequeBookIssuance,_ClientID);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int ClientID = Convert.ToInt32(tbFilter.Text);
            if (clsClient.IsExist(ClientID,clsClient.enExistByInt.ClientID))
            {
                ctrlApplicationInfo1.DefaultCard(clsApplication.enApplicationType.ChequeBookIssuance, ClientID);

            }
            else
            {
                MessageBox.Show("Client is not Found");
                ctrlApplicationInfo1.DefaultCard();
            }
           
            

            
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (_ClientID == -1)
                _ClientID = Convert.ToInt32(tbFilter.Text);
            clsClient client = clsClient.Find(_ClientID);

            if (client == null)
            {
                MessageBox.Show("Client is not Found");
                return;
            }
            if (client.BankAccountID == null)
            {
                MessageBox.Show("Client has not Bank Account");
                return;
            }
            int AppliactionID = -1;
            if (client.ChequeBookIssuance(ref AppliactionID ,clsGloble.CurrentUser.UserID))
            {
                MessageBox.Show("Released successfully");
                ctrlApplicationInfo1.LoadAppliactionInfo(AppliactionID);
                gbFilter.Enabled = btnIssue.Enabled = false;

            }
            else
            {
                MessageBox.Show("Released falied");

            }

        }
    }
}
