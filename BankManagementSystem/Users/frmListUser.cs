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
using BankManagementSystem.GlobleClass;
namespace BankManagementSystem.Users
{
    public partial class frmListUser : Form
    {


        static DataTable _dtAllUsers = clsUser.GetAllUser();
        DataTable _dtUser = _dtAllUsers.DefaultView.ToTable(false,"UserID", "EmployeeID", "Username", "IsActive","PermissionsID");
        public frmListUser()
        {
            InitializeComponent();
        }
        void _RefrechUserList()
        {
            _dtAllUsers = clsUser.GetAllUser();
            _dtUser = _dtAllUsers.DefaultView.ToTable(false, "UserID", "EmployeeID", "Username", "IsActive", "PermissionsID");
            dgvUserList.DataSource = _dtUser;
            lbRecord.Text = dgvUserList.Rows.Count.ToString();
        }
        private void frmListUser_Load(object sender, EventArgs e)
        {
            dgvUserList.DataSource = _dtUser;

            if (dgvUserList.Rows.Count > 0)
            {
                dgvUserList.Columns[0].HeaderText = "User ID.";
                dgvUserList.Columns[0].Width = 120;
                dgvUserList.Columns[1].HeaderText = "Employee ID";
                dgvUserList.Columns[1].Width = 110;
                dgvUserList.Columns[2].HeaderText = "User Name";
                dgvUserList.Columns[2].Width = 120;
                dgvUserList.Columns[3].HeaderText = "Is Active";
                dgvUserList.Columns[3].Width = 140;
                dgvUserList.Columns[4].HeaderText = "Permissions ID";
                dgvUserList.Columns[4].Width = 120;
            }
            lbRecord.Text = dgvUserList.Rows.Count.ToString();
            cbFilter.SelectedIndex = 0;
        }

        private void showPersonalInformatinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserInfo frm = new frmUserInfo((int)dgvUserList.SelectedRows[0].Cells["UserID"].Value);
            frm.ShowDialog();
            _RefrechUserList();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser();
            frm.ShowDialog();
            _RefrechUserList();

        }

        private void updateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddEditUser frm = new frmAddEditUser((int)dgvUserList.SelectedRows[0].Cells["UserID"].Value);
            frm.ShowDialog();
            _RefrechUserList();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure delete this user","Deleted User",MessageBoxButtons.YesNo,MessageBoxIcon.Information)
                == DialogResult.No)
            {
                return;
            }


            if (clsUser.Delete((int)dgvUserList.SelectedRows[0].Cells[0].Value))
            {
                MessageBox.Show("User Deleted Secced");
                _RefrechUserList();
            }
            else
                MessageBox.Show("User Deleted Failed");


        }
        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            string FilterCoulmn = "";
            switch (cbFilter.Text)
            {
                case "User ID":
                    FilterCoulmn = "UserID";
                    break;
                case "User name":
                    FilterCoulmn = "Username";
                    break;
                case "Employee ID":
                    FilterCoulmn = "EmployeeID";
                    break;
            }
            if (tbFilter.Text.Trim() == "" || FilterCoulmn == "None")
            {
                _dtUser.DefaultView.RowFilter = "";
                lbRecord.Text = dgvUserList.Rows.Count.ToString();
                return;
            }

            if (FilterCoulmn == "Username")
            {
                _dtUser.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterCoulmn, tbFilter.Text.Trim());
            }
            else
                _dtUser.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterCoulmn, tbFilter.Text.Trim());

        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFilter.Visible = (cbFilter.Text != "None" && cbFilter.Text != "Is Active");
            cbIsActive.Visible = (cbFilter.Text == "Is Active");
            tbFilter.Clear();
            if (cbIsActive.Visible)
                cbIsActive.SelectedIndex = 0;
        }

        private void cbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbIsActive.Text == "All")
            {
                _dtUser.DefaultView.RowFilter = "";
                return;
            }
            byte isActive = 0;
            if (cbIsActive.Text == "Yes") isActive = 1;
            _dtUser.DefaultView.RowFilter = string.Format("[{0}] = {1}", "IsActive", isActive);
        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text == "User ID" || cbFilter.Text == "Employee ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
