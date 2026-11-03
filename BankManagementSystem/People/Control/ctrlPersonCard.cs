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
using BankManagementSystem.Properties;

namespace BankManagementSystem.People.Control
{
    public partial class ctrlPersonCard : UserControl
    {
        public ctrlPersonCard()
        {
            InitializeComponent();
        }
        public void DefaultCard()
        {
            lbPersonID.Text = "N/A";
            lbName.Text = "[????]";
            lbDateOfBirth.Text = "[????/??/??]";
            lbNationalNumber.Text = "[????]";
            lbPhone.Text = "[????]";
            lbGendor.Text = "[????]";
            PersonInfo = null;
        }
        public clsPerson PersonInfo;
        public void LoadPersonInfo(int PersonID)
        {
           // clsEmployee.Find(2);
            clsPerson Person = clsPerson.Find(PersonID);
            if (Person is null)
            {
                MessageBox.Show("Person Not Found");
                DefaultCard();
                return;
            }
            PersonInfo = Person;
            lbPersonID.Text = PersonID.ToString();
            lbName.Text = Person.FullName;
            lbPhone.Text = Person.Phone;
            lbDateOfBirth.Text = Person.DateOfBirth.ToString("yyyy/MM/dd");
            lbNationalNumber.Text = Person.NationalNumber;
            if (Person.Gendor == clsPerson.enGendor.Female)
            {
                lbGendor.Text = "Female";
                pbGendor.Image = Resources.woman;
            }
            else
            {
                lbGendor.Text = "Male";
                pbGendor.Image = Resources.user;
            }




        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
