using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank_Business;
namespace BankManagementSystem.LoginRegisters
{
    public partial class frmLoginRegisters : Form
    {
        static DataTable _dtAllLogins = clsLogins.GetAllData();
        DataTable _dtLogins = _dtAllLogins.DefaultView.ToTable(false, "LoginID", "LoginDate", "LogoutDate", "LoginUser");
        public frmLoginRegisters()
        {
            InitializeComponent();
        }
        string CustomFormat = "yyyy/MM/dd";
        string RowFiler="";

        private void frmLoginRegisters_Load(object sender, EventArgs e)
        {
            dgvLoginsList.DataSource = _dtLogins;
            cbFilter.SelectedIndex = 0;
            if (dgvLoginsList.Rows.Count > 0)
            {
                dgvLoginsList.Columns[0].HeaderText = "Login ID.";
                dgvLoginsList.Columns[0].Width = 120;
                dgvLoginsList.Columns[1].HeaderText = "Login Date";
                dgvLoginsList.Columns[1].Width = 110;
                dgvLoginsList.Columns[2].HeaderText = "Logout Date";
                dgvLoginsList.Columns[2].Width = 120;
                dgvLoginsList.Columns[3].HeaderText = "Login User";
                dgvLoginsList.Columns[3].Width = 140;

            }

            lbRecord.Text = dgvLoginsList.Rows.Count.ToString();
        }


             
        private void tbFilter_TextChanged(object sender, EventArgs e)
        {

            if (cbFilter.Text == "None" || string.IsNullOrEmpty(tbFilter.Text))
            {
                _dtLogins.DefaultView.RowFilter = "";
                lbRecord.Text = dgvLoginsList.Rows.Count.ToString();
                return;
            }


            string filterColumn = "";
            switch (cbFilter.Text)
            {
                case "Login ID":
                    filterColumn = "LoginID";
                    break;

                case "User ID":
                    filterColumn = "LoginUser";
                    break;

            }
            _dtLogins.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, tbFilter.Text.Trim());
            lbRecord.Text = dgvLoginsList.Rows.Count.ToString();
        }


        
        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFilter.Visible = (cbFilter.Text != "None");

        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
        
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
