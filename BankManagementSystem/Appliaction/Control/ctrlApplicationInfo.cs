using System;
using System.Windows.Forms;
using Bank_Business;
using BankManagementSystem.GlobleClass;
namespace BankManagementSystem.Appliaction.Control
{
    public partial class ctrlApplicationInfo : UserControl
    {
        public ctrlApplicationInfo()
        {
            InitializeComponent();
        }

        public clsApplication ApplicationInfo;


        public void DefaultCard()
        {
            lbAppliactionDate.Text = "[????]";
            lbAppliactionFees.Text = "[????]";
            lbAppliactionID.Text = "[????]";
            lbApplicationType.Text = "[????]";
            lbClientName.Text = "[????]";
            lbCreatedBy.Text = "[????]";
        }
        void _FillData()
        {
            lbAppliactionDate.Text = ApplicationInfo.ApplicationDate.ToString("yyyy/MM/dd");
            lbAppliactionFees.Text = ApplicationInfo.ApplicationTypeInfo.ApplicationFees.ToString();
            lbAppliactionID.Text = ApplicationInfo.ApplicationID.ToString();
            lbApplicationType.Text = ApplicationInfo.ApplicationTypeInfo.ApplicationName;
            lbClientName.Text = ApplicationInfo.ClientInfo.FullName;
            lbCreatedBy.Text = ApplicationInfo.UserInfo.Username;
        }
        string AppliactionTypeText(clsApplication.enApplicationType ApplicationType)
        {
            string []str = { "",
            "Open Bank Account",
            "Cheque Book Issuance",
            "Version Visa First Time",
            "Replace Visa For Lost",
            "Replace Visa For Damage",
            "Renew Visa"
            };
            return str[Convert.ToByte(ApplicationType)];
        }
        public void LoadAppliactionInfo(int AppliactionID)
        {
            ApplicationInfo = clsApplication.Find(AppliactionID,ApplicationTypeData:true,ClientData:true,UserData: true);
            if (ApplicationInfo == null)
            {
                MessageBox.Show("Appliaction Not Found");
                DefaultCard();
                return;
            }
            _FillData();
        }
        public void DefaultCard(clsApplication.enApplicationType ApplicationType,int ClientID)
        {
            lbClientName.Text = clsClient.Find(ClientID).FullName;
            lbCreatedBy.Text = clsGloble.CurrentUser.Username;
            lbApplicationType.Text = AppliactionTypeText(ApplicationType);
            lbAppliactionFees.Text = clsApplicationType.Find(Convert.ToByte(ApplicationType)).ApplicationFees.ToString();
            lbAppliactionDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
        }
        public void DefaultCard(clsApplication.enApplicationType ApplicationType)
        {
            lbClientName.Text = "[????]";
            lbCreatedBy.Text = clsGloble.CurrentUser.Username;
            lbApplicationType.Text = AppliactionTypeText(ApplicationType);
            lbAppliactionFees.Text = clsApplicationType.Find(Convert.ToByte(ApplicationType)).ApplicationFees.ToString();
            lbAppliactionDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
        }
    }
}
