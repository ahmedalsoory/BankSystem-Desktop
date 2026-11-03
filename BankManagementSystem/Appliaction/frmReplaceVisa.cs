using System;
using System.Windows.Forms;
using BankManagementSystem.GlobleClass;
using Bank_Business;
namespace BankManagementSystem.Appliaction
{
    public partial class frmReplaceVisa : Form
    {
        int _ClientID;
        clsClient.enReplaceFor _ReplaceFor=clsClient.enReplaceFor.ReplaceVisaForLost;
        public frmReplaceVisa(int ClientID=-1)
        {
            InitializeComponent();
            _ClientID = ClientID;
        }

        private void frmReplaceVisa_Load(object sender, EventArgs e)
        {
            ctrlFilterClient1.FilterVisble = (_ClientID == -1);
            if (_ClientID == -1)
                ctrlApplicationInfo1.DefaultCard((clsApplication.enApplicationType)_ReplaceFor);
            else
                ctrlApplicationInfo1.DefaultCard((clsApplication.enApplicationType)_ReplaceFor,_ClientID);

        }

        private void ctrlFilterClient1_OnClientSelected(object sender, Control.ctrlFilterClient.ClientSelectedEventArgs e)
        {
            _ClientID = e.ClientID;
            if(_ClientID!=-1)
                ctrlApplicationInfo1.DefaultCard((clsApplication.enApplicationType)_ReplaceFor, _ClientID) ;
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            if (!clsClient.IsClientHasVisa(_ClientID))
            {
                MessageBox.Show("The customer does not have a Visa");
                return;
            }
            int VisaID = 0;
            int AppliactionID = 0;
            if(clsClient.Find(_ClientID).ReplaceVisa(ref AppliactionID, ref VisaID,clsGloble.CurrentUser.UserID, _ReplaceFor))
            {
                MessageBox.Show($"The operation was successful the new visa id {VisaID}");
                ctrlApplicationInfo1.LoadAppliactionInfo(AppliactionID);
                gbReplaceFor.Enabled = false;
                btnReplace.Enabled = false;
                ctrlFilterClient1.Enabled = false;
            }
            else
                MessageBox.Show($"The operation was failed");


        }

        private void rbLost_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLost.Checked)
             _ReplaceFor = clsClient.enReplaceFor.ReplaceVisaForLost; 
            else
                _ReplaceFor = clsClient.enReplaceFor.ReplaceVisaForDamage;

            if (_ClientID == -1)
                ctrlApplicationInfo1.DefaultCard((clsApplication.enApplicationType)_ReplaceFor);
            else
                ctrlApplicationInfo1.DefaultCard((clsApplication.enApplicationType)_ReplaceFor,_ClientID);



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
