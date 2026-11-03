using System;
using System.Windows.Forms;
using Bank_Business;
using BankManagementSystem.Client;

namespace BankManagementSystem.Appliaction.Control
{
    public partial class ctrlVisaInfo : UserControl
    {
        public ctrlVisaInfo()
        {
            InitializeComponent();
        }
        public clsVisa VisaInfo;
        public void DefaultCard()
        {
            lbAppliactionID.Text = "[????]";
            lbClientID.Text = "[????]";
            lbExpiryDate.Text = "[????]";
            lbIsActive.Text = "[????]";
            lbIssueDate.Text = "[????]";
            lbLength.Text = "[????]";
            lbVisaNumber.Text = "[????]";
            lbVisaID.Text = "[????]";
            showAppliactionInfoToolStripMenuItem.Enabled = false;
            showClientInfoToolStripMenuItem.Enabled = false;
        }
        void _FillData(ref clsVisa visa)
        {
            lbAppliactionID.Text = visa.AppliactionID.ToString();
            lbClientID.Text = visa.ClientID.ToString();
            lbExpiryDate.Text = visa.ExpiryDate.ToString("yyyy/MM/dd");
            lbIsActive.Text = (visa.IsActive)?"Yes":"No";
            lbIssueDate.Text = visa.IssueDate.ToString("yyyy/MM/dd");
            lbLength.Text = visa.Lenght.ToString();
            lbVisaNumber.Text = visa.VisaNumber;
            lbVisaID.Text = visa.VisaID.ToString();
        }
        public void LoadVisaInfo(int VisaID)
        {
             VisaInfo = clsVisa.Find(VisaID);
            if (VisaInfo == null)
            {
                MessageBox.Show("Visa is Not Found");
                DefaultCard();
                showAppliactionInfoToolStripMenuItem.Enabled = false;
                showClientInfoToolStripMenuItem.Enabled =false;
                return;
            }
            _FillData(ref VisaInfo);
            showAppliactionInfoToolStripMenuItem.Enabled = true;
            showClientInfoToolStripMenuItem.Enabled = true;

        }
        public void LoadVisaInfoByClientID(int ClientID)
        {
            VisaInfo = clsVisa.FindByClientID(ClientID);
            if (VisaInfo == null)
            {
                MessageBox.Show("Visa is Not Found");
                DefaultCard();
                showAppliactionInfoToolStripMenuItem.Enabled = false;
                showClientInfoToolStripMenuItem.Enabled = false;
                return;
            }
            _FillData(ref VisaInfo);
            showAppliactionInfoToolStripMenuItem.Enabled = true;
            showClientInfoToolStripMenuItem.Enabled = true;

        }
        public void DefaultCard(int ClientID)
        {
            lbAppliactionID.Text = "[????]";
            lbClientID.Text = ClientID.ToString();
            lbExpiryDate.Text = "[????]";
            lbIsActive.Text = "[????]";
            lbIssueDate.Text = "[????]";
            lbLength.Text = "10";
            lbVisaNumber.Text = "[????]";
            lbVisaID.Text = "[????]";
            showAppliactionInfoToolStripMenuItem.Enabled = false;
            showClientInfoToolStripMenuItem.Enabled = true;

        }
        private void ctrlVisaInfo_Load(object sender, EventArgs e)
        {

        }

        private void showClientInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VisaInfo != null)
            {
                frmClientInfo frm = new frmClientInfo(VisaInfo.ClientID);
                frm.ShowDialog();
            }
        }

        private void showAppliactionInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (VisaInfo != null)
            {
                frmAppliactionInfo frm = new frmAppliactionInfo(VisaInfo.AppliactionID);
                frm.ShowDialog();
            }
        }
    }
}
