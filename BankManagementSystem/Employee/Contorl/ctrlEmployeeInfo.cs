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
using BankManagementSystem.GlobleClass;
namespace BankManagementSystem.Employee.Contorl
{
    public partial class ctrlEmployeeInfo : UserControl
    {
        public ctrlEmployeeInfo()
        {
            InitializeComponent();
        }
        public clsEmployee EmployeeInfo;
        public void DefaultCard()
        {
            tbWorkType.Clear();
            lbEmployeeID.Text = "????";
            lbCreatedBy.Text = "????";
            lbSalary.Text = "????";
            ctrlPersonCard1.DefaultCard();
        }
        void _FillData()
        {

            ctrlPersonCard1.LoadPersonInfo(EmployeeInfo.PersonID);
            tbWorkType.Text = EmployeeInfo.WorkType;
            lbEmployeeID.Text = EmployeeInfo.EmployeeID.ToString();
            lbCreatedBy.Text = clsUser.Find(EmployeeInfo.CreatedByUserID).Username;
            lbSalary.Text = EmployeeInfo.Salary.ToString();
        }
        public void LoadEmployeeData(int EmployeeID)
        {
            EmployeeInfo = clsEmployee.Find(EmployeeID);
            if (EmployeeInfo == null)
            {
                MessageBox.Show("Employee is not Found");
                DefaultCard();
                llEditEmplyee.Enabled = false;
                return;
            }
            llEditEmplyee.Enabled = true;

            _FillData();
        }
        public void LoadEmployeeData(string NationalNumber)
        {
            EmployeeInfo = clsEmployee.Find( NationalNumber);
            if (EmployeeInfo == null)
            {
                MessageBox.Show("Employee is not Found");
                DefaultCard();
                llEditEmplyee.Enabled = false;

                return;
            }
            llEditEmplyee.Enabled = true;

            _FillData();
        }
        public void LoadEmployeeDataByPersonID(int PersonID)
        {
            EmployeeInfo = clsEmployee.FindByPersonID(PersonID);
            if (EmployeeInfo == null)
            {
                MessageBox.Show("Employee is not Found");
                DefaultCard();
                llEditEmplyee.Enabled = false ;

                return;
            }
            llEditEmplyee.Enabled = true;

            _FillData();
        }

        private void llEditEmplyee_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (((clsGloble.CurrentUser.PermissionsInfo.PermissionsForUser) & Convert.ToByte(clsPermissions.enPermissonsForUser.UpdateUser))
                        != Convert.ToByte(clsPermissions.enPermissonsForUser.UpdateUser))
            {
                MessageBox.Show("do not have Permissions you should reviews the admin");
                return;
            }
            frmAddEditEmployee frm = new frmAddEditEmployee(EmployeeInfo.EmployeeID);
            frm.ShowDialog();
            LoadEmployeeData(EmployeeInfo.EmployeeID);

        }

        private void ctrlPersonCard1_Load(object sender, EventArgs e)
        {

        }
    }
}
