namespace BankManagementSystem.Appliaction
{
    partial class frmAppliactionList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvAppliactionList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbRecord = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.tbFilter = new System.Windows.Forms.TextBox();
            this.cbApplicationStatus = new System.Windows.Forms.ComboBox();
            this.cbApplicationType = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonalInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAppliactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chequeBookIssuanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frmOpenBankAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueVisaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppliactionList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAppliactionList
            // 
            this.dgvAppliactionList.AllowUserToAddRows = false;
            this.dgvAppliactionList.AllowUserToDeleteRows = false;
            this.dgvAppliactionList.AllowUserToOrderColumns = true;
            this.dgvAppliactionList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvAppliactionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppliactionList.Location = new System.Drawing.Point(13, 203);
            this.dgvAppliactionList.Name = "dgvAppliactionList";
            this.dgvAppliactionList.ReadOnly = true;
            this.dgvAppliactionList.RowHeadersWidth = 51;
            this.dgvAppliactionList.RowTemplate.Height = 26;
            this.dgvAppliactionList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppliactionList.Size = new System.Drawing.Size(1119, 431);
            this.dgvAppliactionList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(405, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Application List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 657);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "#Record : ";
            // 
            // lbRecord
            // 
            this.lbRecord.AutoSize = true;
            this.lbRecord.Location = new System.Drawing.Point(121, 662);
            this.lbRecord.Name = "lbRecord";
            this.lbRecord.Size = new System.Drawing.Size(16, 17);
            this.lbRecord.TabIndex = 3;
            this.lbRecord.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Filter by : ";
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "None",
            "Application ID",
            "Client Name",
            "Application Type",
            "Application Status"});
            this.cbFilterBy.Location = new System.Drawing.Point(114, 170);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(166, 24);
            this.cbFilterBy.TabIndex = 5;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // tbFilter
            // 
            this.tbFilter.Location = new System.Drawing.Point(298, 170);
            this.tbFilter.Name = "tbFilter";
            this.tbFilter.Size = new System.Drawing.Size(197, 24);
            this.tbFilter.TabIndex = 6;
            this.tbFilter.TextChanged += new System.EventHandler(this.tbFilter_TextChanged);
            this.tbFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFilter_KeyPress);
            // 
            // cbApplicationStatus
            // 
            this.cbApplicationStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbApplicationStatus.FormattingEnabled = true;
            this.cbApplicationStatus.Items.AddRange(new object[] {
            "All",
            "New",
            "Cancelled",
            "Completed"});
            this.cbApplicationStatus.Location = new System.Drawing.Point(329, 170);
            this.cbApplicationStatus.Name = "cbApplicationStatus";
            this.cbApplicationStatus.Size = new System.Drawing.Size(166, 24);
            this.cbApplicationStatus.TabIndex = 7;
            this.cbApplicationStatus.SelectedIndexChanged += new System.EventHandler(this.cbApplicationStatus_SelectedIndexChanged);
            this.cbApplicationStatus.VisibleChanged += new System.EventHandler(this.cb_VisibleChanged);
            // 
            // cbApplicationType
            // 
            this.cbApplicationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbApplicationType.FormattingEnabled = true;
            this.cbApplicationType.Items.AddRange(new object[] {
            "All",
            "Open Bank Account",
            "Cheque Book Issuance",
            "Version Visa First Time",
            "Replace Visa For Lost",
            "Replace Visa For Damage"});
            this.cbApplicationType.Location = new System.Drawing.Point(329, 170);
            this.cbApplicationType.Name = "cbApplicationType";
            this.cbApplicationType.Size = new System.Drawing.Size(166, 24);
            this.cbApplicationType.TabIndex = 8;
            this.cbApplicationType.SelectedIndexChanged += new System.EventHandler(this.cbApplicationType_SelectedIndexChanged);
            this.cbApplicationType.VisibleChanged += new System.EventHandler(this.cb_VisibleChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonalInfoToolStripMenuItem,
            this.cancelToolStripMenuItem,
            this.addAppliactionToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 104);
            // 
            // showPersonalInfoToolStripMenuItem
            // 
            this.showPersonalInfoToolStripMenuItem.Name = "showPersonalInfoToolStripMenuItem";
            this.showPersonalInfoToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.showPersonalInfoToolStripMenuItem.Text = "Show Personal Info";
            this.showPersonalInfoToolStripMenuItem.Click += new System.EventHandler(this.showPersonalInfoToolStripMenuItem_Click);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.cancelToolStripMenuItem.Text = "Cancel ";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // addAppliactionToolStripMenuItem
            // 
            this.addAppliactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chequeBookIssuanceToolStripMenuItem,
            this.frmOpenBankAccountToolStripMenuItem,
            this.issueVisaToolStripMenuItem});
            this.addAppliactionToolStripMenuItem.Name = "addAppliactionToolStripMenuItem";
            this.addAppliactionToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.addAppliactionToolStripMenuItem.Text = "Add Appliaction";
            // 
            // chequeBookIssuanceToolStripMenuItem
            // 
            this.chequeBookIssuanceToolStripMenuItem.Name = "chequeBookIssuanceToolStripMenuItem";
            this.chequeBookIssuanceToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.chequeBookIssuanceToolStripMenuItem.Text = "Cheque Book Issuance";
            // 
            // frmOpenBankAccountToolStripMenuItem
            // 
            this.frmOpenBankAccountToolStripMenuItem.Name = "frmOpenBankAccountToolStripMenuItem";
            this.frmOpenBankAccountToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.frmOpenBankAccountToolStripMenuItem.Text = "Open Bank Account";
            // 
            // issueVisaToolStripMenuItem
            // 
            this.issueVisaToolStripMenuItem.Name = "issueVisaToolStripMenuItem";
            this.issueVisaToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.issueVisaToolStripMenuItem.Text = "Issue Visa";
            // 
            // frmAppliactionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 722);
            this.Controls.Add(this.cbApplicationType);
            this.Controls.Add(this.cbApplicationStatus);
            this.Controls.Add(this.tbFilter);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbRecord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAppliactionList);
            this.Name = "frmAppliactionList";
            this.Text = "frmAppliactionList";
            this.Load += new System.EventHandler(this.frmAppliactionList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppliactionList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAppliactionList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbRecord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.TextBox tbFilter;
        private System.Windows.Forms.ComboBox cbApplicationStatus;
        private System.Windows.Forms.ComboBox cbApplicationType;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showPersonalInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAppliactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chequeBookIssuanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frmOpenBankAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueVisaToolStripMenuItem;
    }
}