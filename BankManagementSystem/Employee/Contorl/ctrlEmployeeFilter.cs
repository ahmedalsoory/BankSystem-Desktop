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
namespace BankManagementSystem.Employee.Contorl
{
    public partial class ctrlEmployeeFilter : UserControl
    {
        int _EmployeeID;
        public ctrlEmployeeFilter()
        {
            InitializeComponent();
        }
        public clsEmployee EmployeeInfo { get
            { return ctrlEmployeeInfo1.EmployeeInfo; } }
            
        public bool FilterEnable {
            set { gbFilter.Enabled = value; }
        }
       public class CoustemEventArgs : EventArgs
        {
            public int EmployeeID;
            public CoustemEventArgs(int EmployeeID)
            {
                this.EmployeeID = EmployeeID;
            }
        }

        public event EventHandler<CoustemEventArgs> OnEmployeeSelected;
        
        protected virtual void RaiseOnEmployeeSelected(CoustemEventArgs e)
        {
            OnEmployeeSelected?.Invoke(this, e);
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            switch (cbFilter.Text)
            {
                case "Employee ID":
                    ctrlEmployeeInfo1.LoadEmployeeData(Convert.ToInt32(tbFilter.Text));
                    break;
                case "Person ID":
                    ctrlEmployeeInfo1.LoadEmployeeDataByPersonID(Convert.ToInt32(tbFilter.Text));
                    break;
                case "National Number":
                    ctrlEmployeeInfo1.LoadEmployeeData(tbFilter.Text);
                    break;
            }
            if (EmployeeInfo != null && OnEmployeeSelected != null)
                RaiseOnEmployeeSelected(new CoustemEventArgs(EmployeeInfo.EmployeeID));


        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
       {
            if (cbFilter.Text != "National Number")
                e.Handled = ! char.IsDigit(e.KeyChar) && ! char.IsControl(e.KeyChar);
        }

        private void ctrlEmployeeFilter_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0;
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFilter.Clear();
        }
        public void LoadDataByEmployeeID(int EmployeeID)
        {
            ctrlEmployeeInfo1.LoadEmployeeData(EmployeeID);
            tbFilter.Text = EmployeeID.ToString();
            FilterEnable = false;
            if (EmployeeInfo != null && OnEmployeeSelected != null)
                RaiseOnEmployeeSelected(new CoustemEventArgs(EmployeeInfo.EmployeeID));
        }

        private void ctrlEmployeeInfo1_Load(object sender, EventArgs e)
        {

        }
        private void DataBack(object sender, int EmployeeID)
        {
            LoadDataByEmployeeID(EmployeeID);
            ctrlEmployeeInfo1.EmployeeInfo = clsEmployee.Find(EmployeeID);


        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddEditEmployee frm = new frmAddEditEmployee();
            frm.DataBack += DataBack;
            frm.ShowDialog();
        }

        private void gbFilter_Enter(object sender, EventArgs e)
        {

        }
    }
}
