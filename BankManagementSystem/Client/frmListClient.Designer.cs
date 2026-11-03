namespace BankManagementSystem.Client
{
    partial class frmListClient
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
            this.dgvClientList = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonalInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appliactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chequeBookIssuanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionVisaFirstTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceVisaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renewVisaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openBankAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withdrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lbReocrd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientList)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientList
            // 
            this.dgvClientList.AllowUserToAddRows = false;
            this.dgvClientList.AllowUserToDeleteRows = false;
            this.dgvClientList.AllowUserToOrderColumns = true;
            this.dgvClientList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvClientList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientList.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvClientList.Location = new System.Drawing.Point(12, 194);
            this.dgvClientList.Name = "dgvClientList";
            this.dgvClientList.ReadOnly = true;
            this.dgvClientList.RowHeadersWidth = 51;
            this.dgvClientList.RowTemplate.Height = 26;
            this.dgvClientList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientList.Size = new System.Drawing.Size(934, 372);
            this.dgvClientList.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonalInfoToolStripMenuItem,
            this.addNewClientToolStripMenuItem,
            this.updateClientToolStripMenuItem,
            this.deleteClientToolStripMenuItem,
            this.appliactionsToolStripMenuItem,
            this.transactionToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(227, 260);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // showPersonalInfoToolStripMenuItem
            // 
            this.showPersonalInfoToolStripMenuItem.Image = global::BankManagementSystem.Properties.Resources.client_info;
            this.showPersonalInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showPersonalInfoToolStripMenuItem.Name = "showPersonalInfoToolStripMenuItem";
            this.showPersonalInfoToolStripMenuItem.Size = new System.Drawing.Size(226, 38);
            this.showPersonalInfoToolStripMenuItem.Text = "Show Personal Info";
            this.showPersonalInfoToolStripMenuItem.Click += new System.EventHandler(this.showPersonalInfoToolStripMenuItem_Click);
            // 
            // addNewClientToolStripMenuItem
            // 
            this.addNewClientToolStripMenuItem.Image = global::BankManagementSystem.Properties.Resources.client_add;
            this.addNewClientToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewClientToolStripMenuItem.Name = "addNewClientToolStripMenuItem";
            this.addNewClientToolStripMenuItem.Size = new System.Drawing.Size(226, 38);
            this.addNewClientToolStripMenuItem.Text = "Add New Client";
            this.addNewClientToolStripMenuItem.Click += new System.EventHandler(this.addNewClientToolStripMenuItem_Click);
            // 
            // updateClientToolStripMenuItem
            // 
            this.updateClientToolStripMenuItem.Image = global::BankManagementSystem.Properties.Resources.client_refresh;
            this.updateClientToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.updateClientToolStripMenuItem.Name = "updateClientToolStripMenuItem";
            this.updateClientToolStripMenuItem.Size = new System.Drawing.Size(226, 38);
            this.updateClientToolStripMenuItem.Text = "Update Client";
            this.updateClientToolStripMenuItem.Click += new System.EventHandler(this.updateClientToolStripMenuItem_Click);
            // 
            // deleteClientToolStripMenuItem
            // 
            this.deleteClientToolStripMenuItem.Image = global::BankManagementSystem.Properties.Resources.client_close;
            this.deleteClientToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteClientToolStripMenuItem.Name = "deleteClientToolStripMenuItem";
            this.deleteClientToolStripMenuItem.Size = new System.Drawing.Size(226, 38);
            this.deleteClientToolStripMenuItem.Text = "Delete Client";
            this.deleteClientToolStripMenuItem.Click += new System.EventHandler(this.deleteClientToolStripMenuItem_Click);
            // 
            // appliactionsToolStripMenuItem
            // 
            this.appliactionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chequeBookIssuanceToolStripMenuItem,
            this.visaToolStripMenuItem,
            this.openBankAccountToolStripMenuItem});
            this.appliactionsToolStripMenuItem.Image = global::BankManagementSystem.Properties.Resources.services__1_;
            this.appliactionsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.appliactionsToolStripMenuItem.Name = "appliactionsToolStripMenuItem";
            this.appliactionsToolStripMenuItem.Size = new System.Drawing.Size(226, 38);
            this.appliactionsToolStripMenuItem.Text = "Appliactions";
            // 
            // chequeBookIssuanceToolStripMenuItem
            // 
            this.chequeBookIssuanceToolStripMenuItem.Image = global::BankManagementSystem.Properties.Resources.diary__1_;
            this.chequeBookIssuanceToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.chequeBookIssuanceToolStripMenuItem.Name = "chequeBookIssuanceToolStripMenuItem";
            this.chequeBookIssuanceToolStripMenuItem.Size = new System.Drawing.Size(251, 38);
            this.chequeBookIssuanceToolStripMenuItem.Text = "Cheque book issuance";
            this.chequeBookIssuanceToolStripMenuItem.Click += new System.EventHandler(this.chequeBookIssuanceToolStripMenuItem_Click);
            // 
            // visaToolStripMenuItem
            // 
            this.visaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionVisaFirstTimeToolStripMenuItem,
            this.replaceVisaToolStripMenuItem,
            this.renewVisaToolStripMenuItem});
            this.visaToolStripMenuItem.Image = global::BankManagementSystem.Properties.Resources.visa;
            this.visaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.visaToolStripMenuItem.Name = "visaToolStripMenuItem";
            this.visaToolStripMenuItem.Size = new System.Drawing.Size(251, 38);
            this.visaToolStripMenuItem.Text = "Visa";
            // 
            // versionVisaFirstTimeToolStripMenuItem
            // 
            this.versionVisaFirstTimeToolStripMenuItem.Image = global::BankManagementSystem.Properties.Resources.visa_add;
            this.versionVisaFirstTimeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.versionVisaFirstTimeToolStripMenuItem.Name = "versionVisaFirstTimeToolStripMenuItem";
            this.versionVisaFirstTimeToolStripMenuItem.Size = new System.Drawing.Size(251, 38);
            this.versionVisaFirstTimeToolStripMenuItem.Text = "Version Visa First Time";
            this.versionVisaFirstTimeToolStripMenuItem.Click += new System.EventHandler(this.versionVisaFirstTimeToolStripMenuItem_Click);
            // 
            // replaceVisaToolStripMenuItem
            // 
            this.replaceVisaToolStripMenuItem.Image = global::BankManagementSystem.Properties.Resources.visa_refresh;
            this.replaceVisaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.replaceVisaToolStripMenuItem.Name = "replaceVisaToolStripMenuItem";
            this.replaceVisaToolStripMenuItem.Size = new System.Drawing.Size(251, 38);
            this.replaceVisaToolStripMenuItem.Text = "Replace Visa";
            this.replaceVisaToolStripMenuItem.Click += new System.EventHandler(this.replaceVisaToolStripMenuItem_Click);
            // 
            // renewVisaToolStripMenuItem
            // 
            this.renewVisaToolStripMenuItem.Image = global::BankManagementSystem.Properties.Resources.visa_reload;
            this.renewVisaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.renewVisaToolStripMenuItem.Name = "renewVisaToolStripMenuItem";
            this.renewVisaToolStripMenuItem.Size = new System.Drawing.Size(251, 38);
            this.renewVisaToolStripMenuItem.Text = "Renew Visa";
            this.renewVisaToolStripMenuItem.Click += new System.EventHandler(this.renewVisaToolStripMenuItem_Click);
            // 
            // openBankAccountToolStripMenuItem
            // 
            this.openBankAccountToolStripMenuItem.Image = global::BankManagementSystem.Properties.Resources.paypal;
            this.openBankAccountToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.openBankAccountToolStripMenuItem.Name = "openBankAccountToolStripMenuItem";
            this.openBankAccountToolStripMenuItem.Size = new System.Drawing.Size(251, 38);
            this.openBankAccountToolStripMenuItem.Text = "Open Bank Account";
            this.openBankAccountToolStripMenuItem.Click += new System.EventHandler(this.openBankAccountToolStripMenuItem_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depositToolStripMenuItem,
            this.withdrawToolStripMenuItem,
            this.transferToolStripMenuItem});
            this.transactionToolStripMenuItem.Image = global::BankManagementSystem.Properties.Resources.bank_transfer;
            this.transactionToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(226, 38);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // depositToolStripMenuItem
            // 
            this.depositToolStripMenuItem.Image = global::BankManagementSystem.Properties.Resources.deposit;
            this.depositToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.depositToolStripMenuItem.Name = "depositToolStripMenuItem";
            this.depositToolStripMenuItem.Size = new System.Drawing.Size(236, 38);
            this.depositToolStripMenuItem.Text = "Deposit";
            this.depositToolStripMenuItem.Click += new System.EventHandler(this.depositToolStripMenuItem_Click);
            // 
            // withdrawToolStripMenuItem
            // 
            this.withdrawToolStripMenuItem.Image = global::BankManagementSystem.Properties.Resources.withdrawal;
            this.withdrawToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.withdrawToolStripMenuItem.Name = "withdrawToolStripMenuItem";
            this.withdrawToolStripMenuItem.Size = new System.Drawing.Size(236, 38);
            this.withdrawToolStripMenuItem.Text = "Withdraw";
            this.withdrawToolStripMenuItem.Click += new System.EventHandler(this.withdrawToolStripMenuItem_Click);
            // 
            // transferToolStripMenuItem
            // 
            this.transferToolStripMenuItem.Image = global::BankManagementSystem.Properties.Resources.bank_transaction__1_;
            this.transferToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.transferToolStripMenuItem.Name = "transferToolStripMenuItem";
            this.transferToolStripMenuItem.Size = new System.Drawing.Size(236, 38);
            this.transferToolStripMenuItem.Text = "Transfer";
            this.transferToolStripMenuItem.Click += new System.EventHandler(this.transferToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 569);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "#Record : ";
            // 
            // lbReocrd
            // 
            this.lbReocrd.AutoSize = true;
            this.lbReocrd.Location = new System.Drawing.Point(147, 580);
            this.lbReocrd.Name = "lbReocrd";
            this.lbReocrd.Size = new System.Drawing.Size(16, 17);
            this.lbReocrd.TabIndex = 2;
            this.lbReocrd.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(384, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "Client List";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BankManagementSystem.Properties.Resources.pipeline;
            this.pictureBox1.Location = new System.Drawing.Point(383, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnAdd
            // 
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::BankManagementSystem.Properties.Resources.client_add__2_;
            this.btnAdd.Location = new System.Drawing.Point(872, 115);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 73);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmListClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 617);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbReocrd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvClientList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmListClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmListClient";
            this.Load += new System.EventHandler(this.frmListClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientList)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbReocrd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showPersonalInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteClientToolStripMenuItem;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem appliactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chequeBookIssuanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openBankAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionVisaFirstTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceVisaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renewVisaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withdrawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferToolStripMenuItem;
    }
}