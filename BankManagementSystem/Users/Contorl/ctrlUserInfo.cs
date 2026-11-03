using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank_Business;
namespace BankManagementSystem.Users.Contorl
{
    public partial class ctrlUserInfo : UserControl
    {
        public ctrlUserInfo()
        {
            InitializeComponent();
        }
        public void LoadUserInfo(int UserID)
        {
            clsUser user = clsUser.Find(UserID);
            if (user == null)
            {
                MessageBox.Show("User Not Found");
                return;
            }
            ctrlEmployeeInfo1.LoadEmployeeData(user.EmployeeID);
            lbUserID.Text = UserID.ToString();
            lbUsername.Text = user.Username;
            lbIsActive.Text = (user.IsActive) ? "Yes" : "No";
        }
        public void DefaultCard()
        {
            ctrlEmployeeInfo1.DefaultCard();
            lbUserID.Text = "[????]";
            lbUsername.Text = "[????]";
            lbIsActive.Text = "[????]";

        }
        private void ctrlUserInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
