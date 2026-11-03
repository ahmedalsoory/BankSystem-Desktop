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
using BankManagementSystem.People;
using BankManagementSystem.Properties;

namespace BankManagementSystem.Client
{
    public partial class frmAddEditClient : Form
    {
        enum enMode { AddNew=0,Update=1}
        struct GlobleVarible
        {
            public enMode _Mode;
            public int _ClientID;
            public clsClient _Client;
        }

        GlobleVarible _GlobleVarible; 
        
        public frmAddEditClient(int ClientID=-1)
        {
            InitializeComponent();
            _GlobleVarible._ClientID = ClientID;
            _GlobleVarible._Mode = (_GlobleVarible._ClientID == -1) ? enMode.AddNew : enMode.Update;

        }
        void _LoadData()
        {
            
            tbFirstName.Text = _GlobleVarible._Client.FirstName;
            tbSecondName.Text = _GlobleVarible._Client.SecondName;
            tbThirdName.Text = _GlobleVarible._Client.ThirdName;
            tbLastName.Text = _GlobleVarible._Client.LastName;
            tbPhone.Text = _GlobleVarible._Client.Phone;
            tbNationalNumber.Text = _GlobleVarible._Client.NationalNumber;
            dtpDateOfBirth.Value = _GlobleVarible._Client.DateOfBirth;
            if (_GlobleVarible._Client.Gendor == clsClient.enGendor.Female) {
                rbFemale.Checked = true;
                pbGendor.Image = Resources.woman;
            }
            else
            {
                rbMale.Checked = true;
                pbGendor.Image = Resources.administrator;
            }
        }
        void _FillData()
        {
            _GlobleVarible._Client.FirstName = tbFirstName.Text;
            _GlobleVarible._Client.SecondName = tbSecondName.Text;
            _GlobleVarible._Client.ThirdName = tbThirdName.Text;
            _GlobleVarible._Client.LastName = tbLastName.Text;
            _GlobleVarible._Client.NationalNumber = tbNationalNumber.Text;
            _GlobleVarible._Client.Phone = tbPhone.Text;
            _GlobleVarible._Client.UserID = 2;
            _GlobleVarible._Client.DateOfBirth = dtpDateOfBirth.Value;
            if (rbMale.Checked)
                _GlobleVarible._Client.Gendor =clsClient.enGendor.Female;
            else
                _GlobleVarible._Client.Gendor = clsClient.enGendor.Male;

        }

        void _CheckForPermissions()
        {
            if (_GlobleVarible._Mode == enMode.AddNew)
            {


                if (((clsGloble.CurrentUser.PermissionsInfo.PermissionsForClient) & Convert.ToByte(clsPermissions.enPermissonsForClient.UpdateClient))
                        != Convert.ToByte(clsPermissions.enPermissonsForClient.UpdateClient))
                {
                    MessageBox.Show("do not have Permissions you should reviews the admin");
                    this.Close();
                }
            }
            else
            {
                if (((clsGloble.CurrentUser.PermissionsInfo.PermissionsForClient) & Convert.ToByte(clsPermissions.enPermissonsForClient.AddClient))
                   != Convert.ToByte(clsPermissions.enPermissonsForClient.AddClient))
                {
                    MessageBox.Show("do not have Permissions you should reviews the admin");
                    this.Close();
                }
            }
        }
        private void frmAddEditClient_Load(object sender, EventArgs e)
        {
            if (_GlobleVarible._Mode == enMode.Update)
            {
                
                this.Text = lbTitle.Text = "Update New Client";
                _GlobleVarible._Client = clsClient.Find(_GlobleVarible._ClientID);
                _GlobleVarible._Mode = enMode.Update;
                _LoadData();
            }
            else
            {
              
                _GlobleVarible._Client = new clsClient();
                lbTitle.Text = this.Text = "Add New Client";
                _GlobleVarible._Mode = enMode.AddNew;

            }
        }

        private void rbMale_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMale.Checked)
            {
                rbMale.Checked = true;
                pbGendor.Image = Resources.administrator;
            }
            else
            {
                rbFemale.Checked = true;
                pbGendor.Image = Resources.woman;
            }
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
                errorProvider1.SetError(text, null) ;



        }

        bool _IsInformationAvailable()
        {

            clsPerson person = clsPerson.Find(tbNationalNumber.Text);

            if (person != null)
            {
                if (_GlobleVarible._Mode == enMode.AddNew)
                {
                    _GlobleVarible._Client.PersonID = person.PersonID;
                    clsPerson person1 = _GlobleVarible._Client;

                    if (!person.Equals( person1))
                    {
                        if (MessageBox.Show("The person with this national number exists but there is mismatched information do you want to " +
                             "see the saved information", "", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                        {
                            return false;
                        }
                       
                        frmPersonInfo frm = new frmPersonInfo(person.PersonID, true);
                        frm.ShowDialog();
                        if (!frm.IsCorrectionOfInformation) return false;
                        tbFirstName.Text = person.FirstName;
                        tbSecondName.Text = person.SecondName;
                        tbThirdName.Text = person.ThirdName;
                        tbLastName.Text = person.LastName;
                        tbPhone.Text = person.Phone;
                        tbNationalNumber.Text = person.NationalNumber;
                        dtpDateOfBirth.Value = person.DateOfBirth;
                        if (person.Gendor == clsPerson.enGendor.Female)
                        {
                            rbFemale.Checked = true;
                            pbGendor.Image = Resources.woman;
                        }
                        else
                        {
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


            if (_GlobleVarible._Client.Save())
            {
                MessageBox.Show("The operation was successful");
                this.Text = lbTitle.Text = "Update Client";
                _GlobleVarible._Mode = enMode.Update;
            }
            else
                MessageBox.Show("The operation was Faild");
            

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

            

            if (clsClient.IsExist(tbNationalNumber.Text,clsClient.enExistByString.NationalNumber) && _GlobleVarible._Client.NationalNumber != tbNationalNumber.Text)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbNationalNumber, "This National Number is Used ");
            }
            else
                errorProvider1.SetError(tbNationalNumber, null);



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
