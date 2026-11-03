using System;
using System.Data;
using System.Windows.Forms;
using Bank_Business;
using BankManagementSystem.Client;

namespace BankManagementSystem.Appliaction
{
    public partial class frmAppliactionList : Form
    {
        static DataTable _dtAllAppliactions = clsApplication.GetAllData();
        DataTable _dtAppliactions = _dtAllAppliactions.DefaultView.ToTable(false, "ApplicationID", "ApplicationDate",
            "ClientName", "AppliactionType", "ApplicationStatus", "AppliactionFees");
        public frmAppliactionList()
        {
            InitializeComponent();
        }
        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.Text == "None")
            {
                _dtAppliactions.DefaultView.RowFilter = "";
                lbRecord.Text = dgvAppliactionList.Rows.Count.ToString();
            }
            tbFilter.Visible = (cbFilterBy.Text == "Application ID" || cbFilterBy.Text == "Client Name")&&cbFilterBy.Text!="None";
            cbApplicationType.Visible = (cbFilterBy.Text == "Application Type")&& cbFilterBy.Text != "None";
            cbApplicationStatus.Visible = (cbFilterBy.Text == "Application Status")&& cbFilterBy.Text != "None";
        }

        private void cb_VisibleChanged(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            if (combo.Visible)
                combo.SelectedIndex = 0;
        }

        private void frmAppliactionList_Load(object sender, EventArgs e)
        {
            dgvAppliactionList.DataSource = _dtAppliactions;

            if (dgvAppliactionList.Rows.Count > 0)
            {
                dgvAppliactionList.Columns[0].HeaderText = "Application ID";
                dgvAppliactionList.Columns[0].Width = 120;
                dgvAppliactionList.Columns[1].HeaderText = "Application Date";
                dgvAppliactionList.Columns[1].Width = 160;
                dgvAppliactionList.Columns[2].HeaderText = "Client Name";
                dgvAppliactionList.Columns[2].Width = 200;
                dgvAppliactionList.Columns[3].HeaderText = "Appliaction Type";
                dgvAppliactionList.Columns[3].Width = 160;
                dgvAppliactionList.Columns[4].HeaderText = "Application Status";
                dgvAppliactionList.Columns[4].Width = 120;
                dgvAppliactionList.Columns[5].HeaderText = "Appliaction Fees";
                dgvAppliactionList.Columns[5].Width = 120;
            }

            cbFilterBy.SelectedIndex = 0;
            lbRecord.Text = dgvAppliactionList.Rows.Count.ToString();
        }
        /*
         All
New
Cancelled
Completed
             
             */
        private void tbFilter_TextChanged(object sender, EventArgs e)
        {

            if(cbFilterBy.Text=="None"||string.IsNullOrEmpty( tbFilter.Text))
            {
                _dtAppliactions.DefaultView.RowFilter = "";
                lbRecord.Text = dgvAppliactionList.Rows.Count.ToString();
                return;
            }

            string FilterCoulmn = "";

            switch (cbFilterBy.Text)
            {
                case "Application ID":
                    FilterCoulmn = "ApplicationID";
                    break;

                case "Client Name":
                    FilterCoulmn = "ClientName";
                    break;
            }

            if (FilterCoulmn == "ApplicationID")
            {
                _dtAppliactions.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterCoulmn, tbFilter.Text.Trim());
            }
            else
                _dtAppliactions.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterCoulmn, tbFilter.Text.Trim());
            lbRecord.Text = dgvAppliactionList.Rows.Count.ToString();

        }
        string _GetApplicationStatusText(byte Index)
        {
            string []str = { "", "New", "Cancelled","Completed" };
            return str[Index];
        }
        string _GetApplicationTypeText(byte Index)
        {
            string[] str = { "", "Open Bank Account", "Cheque Book Issuance", "Version Visa First Time",
            "Replace Visa For Lost","Replace Visa For Damage"};
            return str[Index];
        }
        private void cbApplicationStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbApplicationStatus.Text == "All")
            {
                _dtAppliactions.DefaultView.RowFilter = "";
                lbRecord.Text = dgvAppliactionList.Rows.Count.ToString();
                return;
            }
            
            _dtAppliactions.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", "ApplicationStatus",
                _GetApplicationStatusText((byte)cbApplicationStatus.SelectedIndex));

            lbRecord.Text = dgvAppliactionList.Rows.Count.ToString();

        }

        private void cbApplicationType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbApplicationType.Text== "All")
            {
                _dtAllAppliactions.DefaultView.RowFilter = "";
                lbRecord.Text = dgvAppliactionList.Rows.Count.ToString();
                return;
            }
            _dtAppliactions.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", "AppliactionType",
        _GetApplicationTypeText((byte)cbApplicationType.SelectedIndex));

            lbRecord.Text = dgvAppliactionList.Rows.Count.ToString();
        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilterBy.Text == "Application ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void showPersonalInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int AppliactionID = (int)dgvAppliactionList.SelectedRows[0].Cells[0].Value;
            frmClientInfo frm = new frmClientInfo(clsApplication.Find(AppliactionID).ClientID);
            frm.ShowDialog();
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

    }
}
