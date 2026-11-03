using System;
using System.Windows.Forms;
using Bank_Business;
namespace BankManagementSystem.Appliaction.AppliactionType
{
    public partial class frmListAppliactionType : Form
    {
        public frmListAppliactionType()
        {
            InitializeComponent();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditAppliactionType frm = new frmEditAppliactionType(Convert.ToByte(
                dgvAppliactionTypeList.SelectedRows[0].Cells[0].Value));
            frm.ShowDialog();
            frmListAppliactionType_Load(null,null);
        }

        private void frmListAppliactionType_Load(object sender, EventArgs e)
        {
            dgvAppliactionTypeList.DataSource = clsApplicationType.GetAllData();
            lbRecord.Text = dgvAppliactionTypeList.Rows.Count.ToString();
            
        }
    }
}
