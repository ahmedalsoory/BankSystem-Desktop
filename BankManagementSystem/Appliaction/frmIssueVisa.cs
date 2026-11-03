using System;
using System.Windows.Forms;
using BankManagementSystem.GlobleClass;
using Bank_Business;
namespace BankManagementSystem.Appliaction
{
    public partial class frmIssueVisa : Form
    {
        int _ClientID;
        public frmIssueVisa(int ClientID=-1)
        {
            InitializeComponent();
            _ClientID = ClientID;
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (_ClientID == -1)
            {
                MessageBox.Show("you should to select client first");
                return; 
            }
            if (clsClient.IsClientHasVisa(_ClientID))
            {
                MessageBox.Show($"Client has visa by ID = {clsVisa.FindByClientID(_ClientID).VisaID}");
                return;
            }
            clsClient client = clsClient.Find(_ClientID);
            int VisaID = -1;
            if(client.IssueVisa(clsGloble.CurrentUser.UserID,ref VisaID))
            {
                MessageBox.Show($"Released successfully by Visa ID {VisaID}");
                ctrlVisaInfo1.LoadVisaInfo(VisaID);
                ctrlFilterClient1.FilterEnable = false;
                btnIssue.Enabled = false;
            }
            else
                MessageBox.Show("Released Falied");

        }

        private void frmIssueVisa_Load(object sender, EventArgs e)
        {
            ctrlFilterClient1.FilterVisble = _ClientID == -1;
            if (_ClientID != -1)
            {
                ctrlVisaInfo1.DefaultCard(_ClientID);
            }
        }

        private void ctrlFilterClient1_OnClientSelected(object sender, Control.ctrlFilterClient.ClientSelectedEventArgs e)
        {
            _ClientID = e.ClientID;
            btnIssue.Enabled = _ClientID != -1;
            if(_ClientID!=-1)
                ctrlVisaInfo1.DefaultCard(_ClientID);
            else
                ctrlVisaInfo1.DefaultCard();


        }

        private void ctrlFilterClient1_Load(object sender, EventArgs e)
        {

        }
    }
}
