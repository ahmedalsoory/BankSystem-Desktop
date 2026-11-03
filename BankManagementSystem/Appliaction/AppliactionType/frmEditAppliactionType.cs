using System;
using System.ComponentModel;
using System.Windows.Forms;
using Bank_Business;
namespace BankManagementSystem.Appliaction.AppliactionType
{
    public partial class frmEditAppliactionType : Form
    {
        byte _AppliactionTypeID;
        clsApplicationType _AppliationType;
        public frmEditAppliactionType(byte AppliactionTypeID)
        {
            InitializeComponent();
            _AppliactionTypeID = AppliactionTypeID;
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {

                MessageBox.Show("Some fileds are noy valide!, put thhe mouse over the red icon(s) to see the erro",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            _AppliationType.ApplicationName = tbAppliactionName.Text;
            _AppliationType.ApplicationFees = Convert.ToSingle(tbAppliactionFees.Text);
            if (_AppliationType.Save())
                MessageBox.Show("The operation was successful ");
            else
                MessageBox.Show("The operation was Failed ");

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditAppliactionType_Load(object sender, EventArgs e)
        {
             _AppliationType = clsApplicationType.Find(_AppliactionTypeID);
            if (_AppliationType == null)
            {
                MessageBox.Show("Aplliaction Type is not Found");
                this.Close();
            }
            lbID.Text = _AppliationType.ApplicationTypeID.ToString();
            tbAppliactionFees.Text = _AppliationType.ApplicationFees.ToString();
            tbAppliactionName.Text = _AppliationType.ApplicationName;
        }

        private void tbAppliactionFees_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
