using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankManagementSystem.GlobleClass;
using Bank_Business;
namespace BankManagementSystem.Employee
{
    public partial class frmListEmployee : Form
    {
        static DataTable _dtAllEmployees = clsEmployee.GetAllData();
        DataTable _dtEmplyees= _dtAllEmployees.DefaultView.ToTable(false, "EmployeeID", "PersonID", "FirstName"
                                                       , "SecondName", "ThirdName", "LastName", "WorkType", "Salary");
        public frmListEmployee()
        {
            InitializeComponent();
        }
        void _RefreshEmplyeeList()
        {
            _dtAllEmployees = clsEmployee.GetAllData();
            _dtEmplyees = _dtAllEmployees.DefaultView.ToTable(false, "EmployeeID", "PersonID", "FirstName"
                                                          , "SecondName", "ThirdName", "LastName", "WorkType", "Salary");

            dgvEmployeeList.DataSource = _dtEmplyees;
            lbReocrd.Text = dgvEmployeeList.Rows.Count.ToString();
        }

        private void frmListEmployee_Load(object sender, EventArgs e)
        {
            dgvEmployeeList.DataSource = _dtAllEmployees;

            if (dgvEmployeeList.Rows.Count > 0)
            {
                dgvEmployeeList.Columns[0].HeaderText = "Employee ID.";
                dgvEmployeeList.Columns[0].Width = 100;
                dgvEmployeeList.Columns[1].HeaderText = "Person ID";
                dgvEmployeeList.Columns[1].Width = 100;
                dgvEmployeeList.Columns[2].HeaderText = "First Name";
                dgvEmployeeList.Columns[2].Width = 120;
                dgvEmployeeList.Columns[3].HeaderText = "Second Name";
                dgvEmployeeList.Columns[3].Width = 140;
                dgvEmployeeList.Columns[4].HeaderText = "Third Name";
                dgvEmployeeList.Columns[4].Width = 120;
                dgvEmployeeList.Columns[5].HeaderText = "Last Name";
                dgvEmployeeList.Columns[5].Width = 120;
                dgvEmployeeList.Columns[5].HeaderText = "Work Type";
                dgvEmployeeList.Columns[5].Width = 120;
                dgvEmployeeList.Columns[5].HeaderText = "Salary";
                dgvEmployeeList.Columns[5].Width = 120;
            }
            lbReocrd.Text = dgvEmployeeList.Rows.Count.ToString();

        }

        private void showEmployeeInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployeeInfo frm = new frmEmployeeInfo((int)dgvEmployeeList.SelectedRows[0].Cells[0].Value);
            frm.ShowDialog();
            _RefreshEmplyeeList();

        }

        private void addNewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (((clsGloble.CurrentUser.PermissionsInfo.PermissionsForUser) & Convert.ToByte(clsPermissions.enPermissonsForUser.AddUser))
!= Convert.ToByte(clsPermissions.enPermissonsForUser.AddUser))
            {
                MessageBox.Show("do not have Permissions you should reviews the admin");
                return;
            }
            frmAddEditEmployee frm = new frmAddEditEmployee();
            frm.ShowDialog();
            _RefreshEmplyeeList();

        }

        private void updateEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (((clsGloble.CurrentUser.PermissionsInfo.PermissionsForUser) & Convert.ToByte(clsPermissions.enPermissonsForUser.UpdateUser))
!= Convert.ToByte(clsPermissions.enPermissonsForUser.UpdateUser))
            {
                MessageBox.Show("do not have Permissions you should reviews the admin");
                return;
            }
            frmAddEditEmployee frm = new frmAddEditEmployee((int)dgvEmployeeList.SelectedRows[0].Cells[0].Value);
            frm.ShowDialog();
            _RefreshEmplyeeList();
        }

        private void deleteEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (((clsGloble.CurrentUser.PermissionsInfo.PermissionsForUser) & Convert.ToByte(clsPermissions.enPermissonsForUser.DeleteUser))
                    != Convert.ToByte(clsPermissions.enPermissonsForUser.DeleteUser))
            {
                MessageBox.Show("do not have Permissions you should reviews the admin");
                return;
            }

            if (MessageBox.Show("Are you sure delete this Employee", "Delete Employee", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                == DialogResult.Cancel) return;
            int EmployeeID = (int)dgvEmployeeList.SelectedRows[0].Cells[0].Value;
            int PersonID= (int)dgvEmployeeList.SelectedRows[0].Cells[1].Value;
            if (!clsEmployee.Delete(EmployeeID))
            {
                MessageBox.Show("Employee Delete Falied");
                return;
            }

            if(clsGloble.IsPersonExistAnySubClasses(clsGloble.enSubClasses.Employee, PersonID))
            {
                MessageBox.Show("Employee Delete Seccued");
            }
            else
            {
                if (clsPerson.Delete(PersonID))
                    MessageBox.Show("Employee Deleted Seccued");
                else
                    MessageBox.Show("Employee Deleted Failed");
            }
            _RefreshEmplyeeList();
            

        }

    }
}
