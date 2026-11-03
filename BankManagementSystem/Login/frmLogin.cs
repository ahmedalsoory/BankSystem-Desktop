using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankManagementSystem.Properties;
using System.Windows.Forms;
using BankManagementSystem.GlobleClass;
using Bank_Business;
namespace BankManagementSystem.Login
{
    public partial class frmLogin : Form
    {
        byte _LoginAttempts = 3;
        public frmLogin()
        {
            InitializeComponent();
        }


        private void pbShowPasswprd_Click(object sender, EventArgs e)
        {
            if(tbPassword.PasswordChar==default)
            {
                pbShowPasswprd.Image = Resources.eye_closed;
                tbPassword.PasswordChar = '*';
            }
            else
            {
                pbShowPasswprd.Image = Resources.eye_open;
                tbPassword.PasswordChar=default;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are noy valide!, put thhe mouse over the red icon(s) to see the erro",
                 "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            _LoginAttempts--;


            if (_LoginAttempts == 0)
            {
                MessageBox.Show("I have exhausted the allowed adapters the application will close");
                clsutil.EventLoggerEx("Login attempts have been taken advantage",System.Diagnostics.EventLogEntryType.Warning);
                this.Close();
            }
            clsGloble.CurrentUser = clsUser.Find(tbUsername.Text.Trim(), tbPassword.Text.Trim(),PermissionsData:true);

            if (clsGloble.CurrentUser == null)
            {
                MessageBox.Show("Invalid Username Or Password");
                lbWorbgLogin.Visible = true;
                lbWorbgLogin.Text = $"You still have {_LoginAttempts} tryes";

                return;
            }

            clsLogins login = new clsLogins();
            login.LoginDate = DateTime.Now;
            login.LoginUser = clsGloble.CurrentUser.UserID;
            
            this.Hide();
            frmMain frm = new frmMain();
            frm.ShowDialog();
            login.LogoutDate = DateTime.Now;
            if (!login.Save()) 
                clsutil.EventLoggerEx("An error occurred that did not save your login data ", System.Diagnostics.EventLogEntryType.Warning);
            this.Show();
            _LoginAttempts = 3;
            lbWorbgLogin.Visible = false;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_stringEmpty(object sender, CancelEventArgs e)
        {
            TextBox text = (TextBox)sender;
            if (string.IsNullOrEmpty(text.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(text, "This field should not be empty");
            }
             else
                errorProvider1.SetError(text, null);

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
