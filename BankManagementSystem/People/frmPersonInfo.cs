using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankManagementSystem.People
{
    public partial class frmPersonInfo : Form
    {
        int _PersonID;
        bool _correctionOfInformationVisble = false;
        public bool IsCorrectionOfInformation = false;
        public frmPersonInfo(int PersonID, bool correctionOfInformationVisble = false)
        {
            InitializeComponent();
            _PersonID = PersonID;
            _correctionOfInformationVisble = correctionOfInformationVisble;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPersonInfo_Load(object sender, EventArgs e)
        {
            ctrlPersonCard1.LoadPersonInfo(_PersonID);
            correctionOfInformationToolStripMenuItem.Visible = _correctionOfInformationVisble;
        }

        private void correctionOfInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsCorrectionOfInformation = true;
            this.Close();
        }
    }
}
