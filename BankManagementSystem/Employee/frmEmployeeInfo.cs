using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagementSystem.Employee
{
    public partial class frmEmployeeInfo : Form
    {
        int _EmployeeID;
        public frmEmployeeInfo(int EmployeeID)
        {
            InitializeComponent();
            _EmployeeID = EmployeeID;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEmployeeInfo_Load(object sender, EventArgs e)
        {
            ctrlEmployeeInfo1.LoadEmployeeData(_EmployeeID);
        }
    }
}
