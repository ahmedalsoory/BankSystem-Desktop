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
namespace BankManagementSystem.Client
{
    public partial class frmClientInfo : Form
    {
        int _ClientID=-1;
        public frmClientInfo(int ClientID)
        {
            InitializeComponent();
            _ClientID = ClientID ;
        }

        private void frmClientInfo_Load(object sender, EventArgs e)
        {
            if(clsClient.IsExist(_ClientID,clsClient.enExistByInt.ClientID))
            {
                ctrlClientInfo1.LoadClientInfo(_ClientID);
            }
            else
            {
                MessageBox.Show("Client Not Found");
                this.Close();
            }

        }
    }
}
