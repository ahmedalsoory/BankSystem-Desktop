using System;
using System.Windows.Forms;

namespace BankManagementSystem.Appliaction
{
    public partial class frmAppliactionInfo : Form
    {
        int _AppliactionID;
        public frmAppliactionInfo(int AppliactionID)
        {
            InitializeComponent();
            _AppliactionID = AppliactionID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAppliactionInfo_Load(object sender, EventArgs e)
        {
            ctrlApplicationInfo1.LoadAppliactionInfo(_AppliactionID);
        }
    }
}
