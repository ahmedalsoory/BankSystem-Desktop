using System;
using System.Data;
using System.Windows.Forms;
using BankManagementSystem.Client;
using BankManagementSystem.Users;
using Bank_Business;
namespace BankManagementSystem.Transaction
{
    public partial class frmTransactionRecord : Form
    {
        static DataTable _dtAllTransactionRecord = clsAccountTransactions.GetAllData();
        DataTable _dtTransactionRecord = _dtAllTransactionRecord.DefaultView.ToTable(false,
            "AccountTransactionID", "TransactionType", "TransactionDate",
            "Amont", "CreatedByUserID", "ClientAccountTransaction", "ClientAccountdestination"
            );
        public frmTransactionRecord()
        {
            InitializeComponent();
        }
        void _LoadFullData()
        {
            _dtTransactionRecord.DefaultView.RowFilter = "";
            lbRecord.Text = dgvTransactionRecord.Rows.Count.ToString();
        }
        private void frmTransactionRecord_Load(object sender, EventArgs e)
        {
            dgvTransactionRecord.DataSource = _dtTransactionRecord;
            cbFilter.SelectedIndex = 0;
        }

        private void tbFilter_TextChanged(object sender, EventArgs e)
        {
            if(cbFilter.Text=="None" || string.IsNullOrEmpty(tbFilter.Text.Trim()))
            {
                _LoadFullData();
                return;
            }


            string FilterCloumn = "";
            switch (cbFilter.Text)
            {
                case "Account Transaction ID":
                    FilterCloumn = "AccountTransactionID";
                    break;

                case "Created By User ID":
                    FilterCloumn = "CreatedByUserID";
                    break;

                case "Client Account Transaction":
                    FilterCloumn = "ClientAccountTransaction";
                    break;

                case "Client Account destination":
                    FilterCloumn = "ClientAccountdestination";
                    break;
            }
            _dtTransactionRecord.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterCloumn, tbFilter.Text.Trim());


        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.Text == "None")
            {
                _LoadFullData();
            }
            tbFilter.Visible = (cbFilter.Text != "None" && cbFilter.Text != "Transaction Type");
            cbTransactionType.Visible = (cbFilter.Text == "Transaction Type");
            tbFilter.Clear();
        }

        private void cbTransactionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTransactionType.Text == "All")
            {
                _LoadFullData();
                return;
            }
            _dtTransactionRecord.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", "TransactionType", cbTransactionType.Text);
            lbRecord.Text = dgvTransactionRecord.Rows.Count.ToString();

        }

        private void cbTransactionType_VisibleChanged(object sender, EventArgs e)
        {
            if (cbTransactionType.Visible)
                cbTransactionType.SelectedIndex = 0;
        }

        private void showSouresClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientInfo frm = new frmClientInfo(
                Convert.ToInt32(dgvTransactionRecord.SelectedRows[0].Cells[5].Value));
            frm.ShowDialog();
        }

        private void showDestinationClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientInfo frm = new frmClientInfo(
              Convert.ToInt32(dgvTransactionRecord.SelectedRows[0].Cells[6].Value));
            frm.ShowDialog();

        }

        private void showUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserInfo frm = new frmUserInfo(
              Convert.ToInt32(dgvTransactionRecord.SelectedRows[0].Cells[4].Value));
            frm.ShowDialog();

        }

        private void contextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            showDestinationClientToolStripMenuItem.Enabled =
                !(string.IsNullOrEmpty(dgvTransactionRecord.SelectedRows[0].Cells[6].Value.ToString()));
        }
    }
}
