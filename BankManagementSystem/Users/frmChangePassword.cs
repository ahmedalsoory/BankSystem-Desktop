using System;
using System.ComponentModel;
using System.Windows.Forms;
using BankManagementSystem.Users;
using BankManagementSystem.GlobleClass;
using Bank_Business;
namespace BankManagementSystem.Users
{
    public partial class frmChangePassword : Form
    {
        int _UserID;
        clsUser _User;
        public frmChangePassword(int UserID=-1)
        {
            InitializeComponent();
            _UserID = UserID;
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            if (_UserID == -1)
            {
                lbUserID.Text = clsGloble.CurrentUser.UserID.ToString();
            }
            else
            {


                if (!clsUser.isExist(_UserID))
                {
                    MessageBox.Show("User Not Found");
                    this.Close();
                }
                lbUserID.Text = _UserID.ToString();
                _User = clsUser.Find(_UserID);
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
            if (_User == null)
            {
                if (clsGloble.CurrentUser.ChangePassword(tbNewPassword.Text))               
                    MessageBox.Show("The operation was successful");
                else
                    MessageBox.Show("The operation was Falied");
            }
            else
            {
                if (_User.ChangePassword(tbNewPassword.Text))
                {
                    MessageBox.Show("The operation was successful");
                }
                else
                    MessageBox.Show("The operation was Falied");
            }
            
        }


        private void llUserInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmUserInfo frm = new frmUserInfo(_UserID);
            frm.ShowDialog();
        }

        private void tb_EmptyString(object sender, CancelEventArgs e)
        {
            TextBox text = (TextBox)sender;
            if (string.IsNullOrEmpty(text.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(text, "This field should not be empty");
                return;
            }
            else
                errorProvider1.SetError(text, null);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void tbOldPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbOldPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbOldPassword, "This field should not be empty");
                return;
            }
            else
                errorProvider1.SetError(tbOldPassword, null);

            if (_User.Password != tbOldPassword.Text)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbOldPassword, "Password does not match");
            }
            else
                errorProvider1.SetError(tbOldPassword, null);

        }

        private void tbConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbConfirmPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbConfirmPassword, "This field should not be empty");
                return;
            }
            else
                errorProvider1.SetError(tbConfirmPassword, null);

            if (tbNewPassword.Text != tbConfirmPassword.Text)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbConfirmPassword, "New Password AND ConfirmPassword does not match");
            }
            else
                errorProvider1.SetError(tbConfirmPassword, null);

        }
    }
}
