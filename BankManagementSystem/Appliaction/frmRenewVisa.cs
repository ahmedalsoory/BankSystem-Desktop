using System;
using System.Windows.Forms;
using BankManagementSystem.GlobleClass;
namespace BankManagementSystem.Appliaction
{
    public partial class frmRenewVisa : Form
    {
        int _ClientID;
        public frmRenewVisa(int ClientID=-1)
        {
            InitializeComponent();
            _ClientID = ClientID;
        }

        private void ctrlFilterClient1_OnClientSelected(object sender, Control.ctrlFilterClient.ClientSelectedEventArgs e)
        {
            _ClientID = e.ClientID;
            if (_ClientID != -1)
                ctrlVisaInfo1.LoadVisaInfoByClientID(_ClientID);
                
        }

        private void frmRenewVisa_Load(object sender, EventArgs e)
        {
            ctrlFilterClient1.FilterVisble = (_ClientID == -1);
            if (_ClientID != -1)
            {
                btnRenew.Enabled = true;
                ctrlVisaInfo1.LoadVisaInfoByClientID(_ClientID);
            }

        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            if (ctrlVisaInfo1.VisaInfo == null)
            {
                MessageBox.Show("Enter date");
                return;
            }
            if (DateTime.Now < ctrlVisaInfo1.VisaInfo.ExpiryDate)
            {
                MessageBox.Show("It can't be renewed Visa because it hasn't expired.");
                return;
            }
            int VisaID = 0;
            if(ctrlVisaInfo1.VisaInfo.ClientInfo.RenewVisa(ref VisaID, clsGloble.CurrentUser.UserID))
            {
                MessageBox.Show("The operation was completed successfully Information will be uploaded The New Visa");
                btnRenew.Enabled = false;
                ctrlFilterClient1.FilterEnable = false;
                ctrlVisaInfo1.LoadVisaInfo(VisaID);
            }
            else
            {
                MessageBox.Show("The operation was Failed");

            }
        }
    }
}
