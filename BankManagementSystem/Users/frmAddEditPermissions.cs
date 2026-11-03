using System;
using System.Windows.Forms;
using Bank_Business;
namespace BankManagementSystem.Users
{
    public partial class frmAddEditPermissions : Form
    {

        public delegate void DataBackEventHandler(object sender, int PermissionsID);

        // Declare an event using the delegate
        public event DataBackEventHandler DataBack;
        bool _FillData = false;
        int _PermissionsID;
        clsPermissions _permissions;
        
        public frmAddEditPermissions(int PermissionsID = -1)
        {
            InitializeComponent();
            _PermissionsID = PermissionsID;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_permissions.Save())
            {
                MessageBox.Show("The operation was successful");
                DataBack?.Invoke(this, _permissions.PermissionsID);
                this.Close();
            }
            else
                MessageBox.Show("The operation was successful");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ckbPermissionsUser(object sender, EventArgs e)
        {
            if (_FillData)
            {
                CheckBox check = (CheckBox)sender;

                byte value = Convert.ToByte(check.Tag);

                if (check.Checked)
                    _permissions.PermissionsForUser += value;
                else
                    _permissions.PermissionsForUser -= value;
            }
        }
        private void ckbPermissionsClient(object sender, EventArgs e)
        {
            if (_FillData)
            {
                CheckBox check = (CheckBox)sender;

                byte value = Convert.ToByte(check.Tag);

                if (check.Checked)
                    _permissions.PermissionsForClient += value;
                else
                    _permissions.PermissionsForClient -= value;
            }
        }
        private void ckbPermissionsEmplyee(object sender, EventArgs e)
        {
            CheckBox check = (CheckBox)sender;

            byte value = Convert.ToByte(check.Tag);

            if (check.Checked)
                _permissions.PermissionsForEmployee += value;
            else
                _permissions.PermissionsForEmployee -= value;
        }

        private void ckbPermissionsTransaction(object sender, EventArgs e)
        {
            if (_FillData)
            {
                CheckBox check = (CheckBox)sender;

                byte value = Convert.ToByte(check.Tag);

                if (check.Checked)
                    _permissions.PermissionsForTransaction += value;
                else
                    _permissions.PermissionsForTransaction -= value;
            }
        }

        private void ckbPermissionsApplication(object sender, EventArgs e)
        {
            if (_FillData)
            {
                CheckBox check = (CheckBox)sender;

                byte value = Convert.ToByte(check.Tag);

                if (check.Checked)
                    _permissions.PermissionsForAppliaction += value;
                else
                    _permissions.PermissionsForAppliaction -= value;
            }
        }
        private void ckbLogRegistersList_CheckedChanged(object sender, EventArgs e)
        {
            if(_FillData)
            _permissions.PermissionsForLogRegisters = ckbLogRegistersList.Checked;
        }
        bool BitAnd(int Number1,int Number2)
        {
            return (Number1 & Number2) == Number2;
        }
        void _FillPermissions()
        {

            _permissions = clsPermissions.Find(_PermissionsID);
            ckbAddNewClient.Checked = BitAnd(_permissions.PermissionsForClient, Convert.ToByte(ckbAddNewClient.Tag));
            ckbUpdateClient.Checked= BitAnd(_permissions.PermissionsForClient, Convert.ToByte(ckbUpdateClient.Tag));
            ckbDeleteClient.Checked = BitAnd(_permissions.PermissionsForClient, Convert.ToByte(ckbDeleteClient.Tag));

            ckbaAddNewEmplyees.Checked = BitAnd(_permissions.PermissionsForEmployee, Convert.ToByte(ckbaAddNewEmplyees.Tag));
            ckbUpdateEmplyee.Checked = BitAnd(_permissions.PermissionsForEmployee, Convert.ToByte(ckbUpdateEmplyee.Tag));
            ckbDeleteEmplyee.Checked = BitAnd(_permissions.PermissionsForEmployee, Convert.ToByte(ckbDeleteEmplyee.Tag));

            ckbAddNewUser.Checked = BitAnd(_permissions.PermissionsForUser, Convert.ToByte(ckbAddNewUser.Tag));
            ckbUpdateUser.Checked = BitAnd(_permissions.PermissionsForUser, Convert.ToByte(ckbUpdateUser.Tag));
            ckbDeleteUser.Checked = BitAnd(_permissions.PermissionsForUser, Convert.ToByte(ckbDeleteUser.Tag));

            ckbLogRegistersList.Checked = _permissions.PermissionsForLogRegisters;

            ckbDeposit.Checked= BitAnd(_permissions.PermissionsForTransaction, Convert.ToByte(ckbDeposit.Tag));
            ckbWithdraw.Checked = BitAnd(_permissions.PermissionsForTransaction, Convert.ToByte(ckbWithdraw.Tag));
            ckbTransactionRecord.Checked = BitAnd(_permissions.PermissionsForTransaction, Convert.ToByte(ckbTransactionRecord.Tag));
            chkTransfer.Checked = BitAnd(_permissions.PermissionsForTransaction, Convert.ToByte(chkTransfer.Tag));

            ckbOpenBankAccount.Checked= BitAnd(_permissions.PermissionsForAppliaction, Convert.ToByte(ckbOpenBankAccount.Tag));
            ckbChequeBookIssuance.Checked = BitAnd(_permissions.PermissionsForAppliaction, Convert.ToByte(ckbChequeBookIssuance.Tag));
            ckbRenewVisa.Checked = BitAnd(_permissions.PermissionsForAppliaction, Convert.ToByte(ckbRenewVisa.Tag));
            ckbReplaceVisa.Checked = BitAnd(_permissions.PermissionsForAppliaction, Convert.ToByte(ckbReplaceVisa.Tag));
            ckbVersionVisaFirstTime.Checked = BitAnd(_permissions.PermissionsForAppliaction, Convert.ToByte(ckbVersionVisaFirstTime.Tag));

            _FillData = true;

        }

        private void frmAddEditPermissions_Load(object sender, EventArgs e)
        {
            _permissions = new clsPermissions();
            if (_PermissionsID != -1)
                _FillPermissions();
        }
    }
}
