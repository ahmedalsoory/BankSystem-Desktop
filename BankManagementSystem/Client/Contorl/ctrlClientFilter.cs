using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagementSystem.Client.Contorl
{
    public partial class ctrlClientFilter : UserControl
    {
        public ctrlClientFilter()
        {
            InitializeComponent();
        }

        private void tbFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cbFilter.Text != "Account Number")
                e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string Text = tbFilter.Text;
            switch (cbFilter.Text)
            {
                case "Client ID":
                    ctrlClientInfo1.LoadClientInfo(Convert.ToInt32(Text));
                    break;
                case "Person ID":
                    ctrlClientInfo1.LoadClientInfoByPersonID(Convert.ToInt32(Text));
                    break;
                case "Account Number":
                    ctrlClientInfo1.LoadClientInfo(Text);
                    break;
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbFilter.Clear();
        }
    }
}
