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
namespace BankManagementSystem.Users
{
    public partial class frmAddEditUser : Form
    {
        enum enMode { AddNew=0,Update=1}
        enMode _Mode;
        int _EmployeeID = -1;
        int _UserID;
        clsUser _User;
        public frmAddEditUser(int UserID=-1)
        {
            InitializeComponent();
            _Mode = (UserID == -1) ? enMode.AddNew : enMode.Update;
            _UserID = UserID;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (_EmployeeID == -1)
            {
                MessageBox.Show("Enter Employee");
                return;
            }
            if (clsUser.isUserExistByEmployeeID(_EmployeeID))
            {
                MessageBox.Show("The Employee is user enter another one");
                _EmployeeID = -1;
                return;
            }
            tabControl1.SelectedTab = tpUserInfo;
        }
        void _FillData()
        {
            _User.EmployeeID = _EmployeeID;
            _User.Username = tbUsername.Text;
            _User.Password = tbPassword.Text;
            _User.IsActive = rbIsActve.Checked;
        }
        void _LoadData()
        {
            ctrlEmployeeFilter1.LoadDataByEmployeeID(_User.EmployeeID);
            lbUserID.Text = _User.UserID.ToString();
            tbPassword.Text = _User.Password;
            tbUsername.Text = _User.Username;
            rbIsActve.Checked = _User.IsActive;
        }
        private void ctrlEmployeeFilter1_OnEmployeeSelected(object sender, Employee.Contorl.ctrlEmployeeFilter.CoustemEventArgs e)
        {
            _EmployeeID = e.EmployeeID;
        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbPassword, "This field should not be empty");
            }
            else
                errorProvider1.SetError(tbPassword, null);

        }

        private void tbUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbUsername.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbUsername, "This field should not be empty");
                return;
            }
            else
                errorProvider1.SetError(tbUsername, null);

            if (clsUser.isExist(tbUsername.Text)&&tbUsername.Text != _User.Username)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbUsername, "This username used by another user enter another one");
            }
            else
                errorProvider1.SetError(tbUsername, null);

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                btnNext.Visible = false; 
                btnSave.Visible = true;
                return;
            }
            if (tabControl1.SelectedTab == tpEmpoyeeInfo)
            {
                btnNext.Visible = true;
                btnSave.Visible = false;
            }
            else
            {
                btnNext.Visible = false;
                btnSave.Visible = true;
            }
        }


        private void frmAddEditUser_Load(object sender, EventArgs e)
        {

            if (_Mode == enMode.Update)
            {
                lbTitle.Text = this.Text = "Update User";
                _User = clsUser.Find(_UserID);
                _EmployeeID = _User.EmployeeID;
                _LoadData();
            }
            else
            {
                lbTitle.Text = this.Text = "Add New User";
                _User = new clsUser();
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!this.ValidateChildren())
            {

                MessageBox.Show("Some fileds are noy valide!, put thhe mouse over the red icon(s) to see the erro",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            _FillData();
            if (_User.Save())
            {
                _Mode = enMode.Update;
                lbUserID.Text = _User.UserID.ToString();
                MessageBox.Show("The operation was successful");
                this.Text = lbTitle.Text = "Update User";
            }
            else
                MessageBox.Show("The operation was Falied");

        }

        private void ctrlEmployeeFilter1_Load(object sender, EventArgs e)
        {
            
        }
        void PermissionsIDDataBack(object sender,int PermissionsID)
        {
            _User.PermissionsID = PermissionsID;
        }
        private void llPermissions_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddEditPermissions frm = new frmAddEditPermissions((_Mode==enMode.Update)?_User.PermissionsID:-1);
            frm.DataBack += PermissionsIDDataBack;
            frm.ShowDialog();
        }
    }
}
