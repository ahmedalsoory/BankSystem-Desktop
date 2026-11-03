using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankManagementSystem.GlobleClass;
using System.Windows.Forms;
using Bank_Business;
using BankManagementSystem.People;
using BankManagementSystem.Properties;

namespace BankManagementSystem.Employee
{
    public partial class frmAddEditEmployee : Form
    {
        enum enMode { AddNew=0,Update=1}
        public delegate void DataBackEventHandler(object sender, int EmployeeID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;
        struct GlobleVarible
        {
            public int EmployeeID;
            public clsEmployee Employee;
            public enMode Mode;

        }
        GlobleVarible _GlobleVarible;
        public frmAddEditEmployee(int EmployeeID=-1)
        {

            InitializeComponent();
            _GlobleVarible.EmployeeID = EmployeeID;
            _GlobleVarible.Mode = (EmployeeID == -1) ? enMode.AddNew : enMode.Update;
        }

        private void tbEmptyString(object sender, CancelEventArgs e)
        {
            TextBox text = (TextBox)sender;
            if (string.IsNullOrEmpty(text.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(text, "This field should not be empty");
            }
            else
                errorProvider1.SetError(text, null);



        }
        void _LoadData()
        {
            lbID.Text = _GlobleVarible.Employee.EmployeeID.ToString();
            tbFirstName.Text = _GlobleVarible.Employee.FirstName;
            tbSecondName.Text = _GlobleVarible.Employee.SecondName;
            tbThirdName.Text = _GlobleVarible.Employee.ThirdName;
            tbLastName.Text = _GlobleVarible.Employee.LastName;
            tbNationalNumber.Text = _GlobleVarible.Employee.NationalNumber;
            tbPhone.Text = _GlobleVarible.Employee.Phone;
            tbSalary.Text = _GlobleVarible.Employee.Salary.ToString();
            tbWorkType.Text = _GlobleVarible.Employee.WorkType;
            dtpDateOfBirth.Value = _GlobleVarible.Employee.DateOfBirth;
            if (_GlobleVarible.Employee.Gendor == clsPerson.enGendor.Male)
                rbMale.Checked = true;
            else
                rbFemale.Checked = true;



        }
        void _FillData()
        {
            _GlobleVarible.Employee.FirstName = tbFirstName.Text;
            _GlobleVarible.Employee.SecondName = tbSecondName.Text;
            _GlobleVarible.Employee.ThirdName = tbThirdName.Text;
            _GlobleVarible.Employee.LastName = tbLastName.Text;
            _GlobleVarible.Employee.NationalNumber = tbNationalNumber.Text;
            _GlobleVarible.Employee.Phone = tbPhone.Text;
            _GlobleVarible.Employee.Salary = Convert.ToSingle( tbSalary.Text);
            _GlobleVarible.Employee.DateOfBirth = dtpDateOfBirth.Value;
            _GlobleVarible.Employee.CreatedByUserID = clsGloble.CurrentUser.UserID;
            if (rbMale.Checked)
                _GlobleVarible.Employee.Gendor = clsPerson.enGendor.Male;
            else
                _GlobleVarible.Employee.Gendor = clsPerson.enGendor.Female;
            _GlobleVarible.Employee.WorkType = tbWorkType.Text;


        }
        private void tbNationalNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbNationalNumber.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbNationalNumber, "This field should not be empty");

            }
            else
                errorProvider1.SetError(tbNationalNumber, null);



            //if (.IsExist(tbNationalNumber.Text) && _GlobleVarible._Client.NationalNumber != tbNationalNumber.Text)
            //{
            //    e.Cancel = true;
            //    errorProvider1.SetError(tbNationalNumber, "This National Number is Used ");
            //}
            //else
            //    errorProvider1.SetError(tbNationalNumber, null);



        }
        private void frmAddEditEmployee_Load(object sender, EventArgs e)
        {
            if (_GlobleVarible.Mode == enMode.Update)
            {
                _GlobleVarible.Employee = clsEmployee.Find(_GlobleVarible.EmployeeID,true);
                _LoadData();
                this.Text = lbTitle.Text = "Update Employee";
               

            }
            else
            {
                _GlobleVarible.Employee = new clsEmployee() ;
                this.Text = lbTitle.Text = "Add New Employee";


            }
        }

        private void tbSalary_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbSalary.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbSalary, "This field should not be empty");
                return;

            }
            else
                errorProvider1.SetError(tbSalary, null);


            if (!clsValidatoin.IsFloatNumber(tbSalary.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbSalary, "This field must be a number ");
            }
            else
                errorProvider1.SetError(tbSalary, null); 
        }
        bool _IsInformationAvailable()
        {

            clsPerson person = clsPerson.Find(tbNationalNumber.Text);

            if (person != null)
            {
                if (_GlobleVarible.Mode == enMode.AddNew)
                {
                    _GlobleVarible.Employee.PersonID = person.PersonID;
                    clsPerson person1 =(clsPerson) _GlobleVarible.Employee;

                    if (!person.Equals(person1))
                    {
                        if (MessageBox.Show("The person with this national number exists but there is mismatched information do you want to " +
                             "see the saved information", "", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                        {
                            return false;
                        }

                        frmPersonInfo frm = new frmPersonInfo(person.PersonID, true);
                        frm.ShowDialog();
                        if (!frm.IsCorrectionOfInformation) return false;
                        tbFirstName.Text=_GlobleVarible.Employee.FirstName = person.FirstName;
                        tbSecondName.Text = _GlobleVarible.Employee .SecondName= person.SecondName;
                        tbThirdName.Text = _GlobleVarible.Employee.ThirdName = person.ThirdName;
                        tbLastName.Text = _GlobleVarible.Employee.LastName = person.LastName;
                        tbPhone.Text = _GlobleVarible.Employee .Phone= person.Phone;
                        tbNationalNumber.Text = _GlobleVarible.Employee.NationalNumber = person.NationalNumber;
                        dtpDateOfBirth.Value = _GlobleVarible.Employee .DateOfBirth= person.DateOfBirth;
                        if (person.Gendor == clsPerson.enGendor.Female)
                        {
                            _GlobleVarible.Employee.Gendor = clsPerson.enGendor.Female;
                            rbFemale.Checked = true;
                            pbGendor.Image = Resources.woman;
                        }
                        else
                        {
                            _GlobleVarible.Employee.Gendor = clsPerson.enGendor.Male;

                            rbMale.Checked = true;
                            pbGendor.Image = Resources.administrator;
                        }
                    }



                }

            }



            return true;
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

            if (!_IsInformationAvailable()) return;


            if (_GlobleVarible.Employee.Save())
            {
                MessageBox.Show("The operation was successful");
                this.Text = lbTitle.Text = "Update Employee";
                lbID.Text = _GlobleVarible.Employee.EmployeeID.ToString();

            }
            else
                MessageBox.Show("The operation was Failed");

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAddEditEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataBack?.Invoke(this, _GlobleVarible.Employee.EmployeeID);

        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMale.Checked)
                pbGendor.Image = Resources.man;
            else
                pbGendor.Image = Resources.woman__1_;

        }
    }
}
