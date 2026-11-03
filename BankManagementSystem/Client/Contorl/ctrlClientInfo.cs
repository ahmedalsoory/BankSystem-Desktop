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
namespace BankManagementSystem.Client.Contorl
{
    public partial class ctrlClientInfo : UserControl
    {
        public ctrlClientInfo()
        {
            InitializeComponent();
        }
        public clsClient ClientInfo;
        public void DefaultCard()
        {
            ctrlPersonCard1.DefaultCard();
            lbClientID.Text = "N/A";
            lbCreatedBy.Text = "N/A";
        }
        public void LoadClientInfoByPersonID(int PersonID)
        {
             ClientInfo = clsClient.FindByPersonID(PersonID);
            if (ClientInfo is null)
            {
                MessageBox.Show("Client Not Found");
                DefaultCard();
                ClientInfo = null;
                return;
            }
            ctrlPersonCard1.LoadPersonInfo(ClientInfo.PersonID);
            lbClientID.Text = PersonID.ToString();
            lbCreatedBy.Text = ClientInfo.UserInfo.Username;

        }
        public void LoadClientInfo(int ClientID)
        {
             ClientInfo = clsClient.Find(ClientID);
            if (ClientInfo is null)
            {
                MessageBox.Show("Client Not Found");
                DefaultCard();
                ClientInfo = null;
                return;
            }
            ctrlPersonCard1.LoadPersonInfo(ClientInfo.PersonID);
            lbClientID.Text = ClientID.ToString();
            lbCreatedBy.Text = ClientInfo.UserInfo.Username;

        }

        public void LoadClientInfo(string AccountNumber)
        {
             ClientInfo = clsClient.Find(AccountNumber);
            if (ClientInfo is null)
            {
                MessageBox.Show("Client Not Found");
                DefaultCard();
                ClientInfo = null;
                return;
            }
            ctrlPersonCard1.LoadPersonInfo(ClientInfo.PersonID);
            lbClientID.Text = ClientInfo.ClientID.ToString();
            lbCreatedBy.Text = ClientInfo.UserInfo.Username;
        }

        private void ctrlPersonCard1_Load(object sender, EventArgs e)
        {

        }
    }
}
