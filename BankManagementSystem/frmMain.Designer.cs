namespace BankManagementSystem
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emplyeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logRegistersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appliactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chequeBookIssuanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.versionVisaFirstTimeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceVisaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeVisaPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renewVisaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openBankAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mangeAppliactionTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withdrawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem,
            this.emplyeesToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.accountSettingsToolStripMenuItem,
            this.logRegistersToolStripMenuItem,
            this.appliactionToolStripMenuItem,
            this.transactionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(13, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1600, 74);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Image = global::BankManagementSystem.Properties.Resources.client__1_;
            this.clientToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(178, 68);
            this.clientToolStripMenuItem.Text = "Clients";
            this.clientToolStripMenuItem.Click += new System.EventHandler(this.clientToolStripMenuItem_Click);
            // 
            // emplyeesToolStripMenuItem
            // 
            this.emplyeesToolStripMenuItem.Image = global::BankManagementSystem.Properties.Resources.administrator__3_;
            this.emplyeesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.emplyeesToolStripMenuItem.Name = "emplyeesToolStripMenuItem";
            this.emplyeesToolStripMenuItem.Size = new System.Drawing.Size(212, 68);
            this.emplyeesToolStripMenuItem.Text = "Emplyees";
            this.emplyeesToolStripMenuItem.Click += new System.EventHandler(this.emplyeesToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Image = global::BankManagementSystem.Properties.Resources.businessman;
            this.usersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(163, 68);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // accountSettingsToolStripMenuItem
            // 
            this.accountSettingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userInfoToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.accountSettingsToolStripMenuItem.Image = global::BankManagementSystem.Properties.Resources.settings;
            this.accountSettingsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.accountSettingsToolStripMenuItem.Name = "accountSettingsToolStripMenuItem";
            this.accountSettingsToolStripMenuItem.Size = new System.Drawing.Size(303, 68);
            this.accountSettingsToolStripMenuItem.Text = "Account Settings";
            // 
            // userInfoToolStripMenuItem
            // 
            this.userInfoToolStripMenuItem.Image = global::BankManagementSystem.Properties.Resources.user_info;
            this.userInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.userInfoToolStripMenuItem.Name = "userInfoToolStripMenuItem";
            this.userInfoToolStripMenuItem.Size = new System.Drawing.Size(337, 42);
            this.userInfoToolStripMenuItem.Text = "User Info";
            this.userInfoToolStripMenuItem.Click += new System.EventHandler(this.userInfoToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Image = global::BankManagementSystem.Properties.Resources.password;
            this.changePasswordToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(337, 42);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = global::BankManagementSystem.Properties.Resources._switch;
            this.logoutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(337, 42);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // logRegistersToolStripMenuItem
            // 
            this.logRegistersToolStripMenuItem.Image = global::BankManagementSystem.Properties.Resources.allow_list;
            this.logRegistersToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.logRegistersToolStripMenuItem.Name = "logRegistersToolStripMenuItem";
            this.logRegistersToolStripMenuItem.Size = new System.Drawing.Size(260, 68);
            this.logRegistersToolStripMenuItem.Text = "Log Registers";
            this.logRegistersToolStripMenuItem.Click += new System.EventHandler(this.logRegistersToolStripMenuItem_Click);
            // 
            // appliactionToolStripMenuItem
            // 
            this.appliactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chequeBookIssuanceToolStripMenuItem,
            this.visaToolStripMenuItem,
            this.openBankAccountToolStripMenuItem,
            this.mangeAppliactionTypesToolStripMenuItem});
            this.appliactionToolStripMenuItem.Image = global::BankManagementSystem.Properties.Resources.services;
            this.appliactionToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.appliactionToolStripMenuItem.Name = "appliactionToolStripMenuItem";
            this.appliactionToolStripMenuItem.Size = new System.Drawing.Size(234, 68);
            this.appliactionToolStripMenuItem.Text = "Appliaction";
            this.appliactionToolStripMenuItem.Click += new System.EventHandler(this.appliactionToolStripMenuItem_Click);
            // 
            // chequeBookIssuanceToolStripMenuItem
            // 
            this.chequeBookIssuanceToolStripMenuItem.Image = global::BankManagementSystem.Properties.Resources.diary;
            this.chequeBookIssuanceToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.chequeBookIssuanceToolStripMenuItem.Name = "chequeBookIssuanceToolStripMenuItem";
            this.chequeBookIssuanceToolStripMenuItem.Size = new System.Drawing.Size(445, 44);
            this.chequeBookIssuanceToolStripMenuItem.Text = "Cheque book issuance";
            this.chequeBookIssuanceToolStripMenuItem.Click += new System.EventHandler(this.chequeBookIssuanceToolStripMenuItem_Click);
            // 
            // visaToolStripMenuItem
            // 
            this.visaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.versionVisaFirstTimeToolStripMenuItem,
            this.replaceVisaToolStripMenuItem,
            this.changeVisaPasswordToolStripMenuItem,
            this.renewVisaToolStripMenuItem});
            this.visaToolStripMenuItem.Image = global::BankManagementSystem.Properties.Resources.visa;
            this.visaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.visaToolStripMenuItem.Name = "visaToolStripMenuItem";
            this.visaToolStripMenuItem.Size = new System.Drawing.Size(445, 44);
            this.visaToolStripMenuItem.Text = "Visa";
            // 
            // versionVisaFirstTimeToolStripMenuItem
            // 
            this.versionVisaFirstTimeToolStripMenuItem.Image = global::BankManagementSystem.Properties.Resources.visa_add;
            this.versionVisaFirstTimeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.versionVisaFirstTimeToolStripMenuItem.Name = "versionVisaFirstTimeToolStripMenuItem";
            this.versionVisaFirstTimeToolStripMenuItem.Size = new System.Drawing.Size(398, 42);
            this.versionVisaFirstTimeToolStripMenuItem.Text = "Version Visa First Time";
            this.versionVisaFirstTimeToolStripMenuItem.Click += new System.EventHandler(this.versionVisaFirstTimeToolStripMenuItem_Click);
            // 
            // replaceVisaToolStripMenuItem
            // 
            this.replaceVisaToolStripMenuItem.Image = global::BankManagementSystem.Properties.Resources.visa_refresh;
            this.replaceVisaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.replaceVisaToolStripMenuItem.Name = "replaceVisaToolStripMenuItem";
            this.replaceVisaToolStripMenuItem.Size = new System.Drawing.Size(398, 42);
            this.replaceVisaToolStripMenuItem.Text = "Replace Visa";
            this.replaceVisaToolStripMenuItem.Click += new System.EventHandler(this.replaceVisaToolStripMenuItem_Click);
            // 
            // changeVisaPasswordToolStripMenuItem
            // 
            this.changeVisaPasswordToolStripMenuItem.Image = global::BankManagementSystem.Properties.Resources.password;
            this.changeVisaPasswordToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.changeVisaPasswordToolStripMenuItem.Name = "changeVisaPasswordToolStripMenuItem";
            this.changeVisaPasswordToolStripMenuItem.Size = new System.Drawing.Size(398, 42);
            this.changeVisaPasswordToolStripMenuItem.Text = "Change Visa Password";
            // 
            // renewVisaToolStripMenuItem
            // 
            this.renewVisaToolStripMenuItem.Image = global::BankManagementSystem.Properties.Resources.visa_reload;
            this.renewVisaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.renewVisaToolStripMenuItem.Name = "renewVisaToolStripMenuItem";
            this.renewVisaToolStripMenuItem.Size = new System.Drawing.Size(398, 42);
            this.renewVisaToolStripMenuItem.Text = "Renew Visa";
            this.renewVisaToolStripMenuItem.Click += new System.EventHandler(this.renewVisaToolStripMenuItem_Click);
            // 
            // openBankAccountToolStripMenuItem
            // 
            this.openBankAccountToolStripMenuItem.Image = global::BankManagementSystem.Properties.Resources.paypal;
            this.openBankAccountToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.openBankAccountToolStripMenuItem.Name = "openBankAccountToolStripMenuItem";
            this.openBankAccountToolStripMenuItem.Size = new System.Drawing.Size(445, 44);
            this.openBankAccountToolStripMenuItem.Text = "Open Bank Account";
            this.openBankAccountToolStripMenuItem.Click += new System.EventHandler(this.openBankAccountToolStripMenuItem_Click);
            // 
            // mangeAppliactionTypesToolStripMenuItem
            // 
            this.mangeAppliactionTypesToolStripMenuItem.Image = global::BankManagementSystem.Properties.Resources.services_config;
            this.mangeAppliactionTypesToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.mangeAppliactionTypesToolStripMenuItem.Name = "mangeAppliactionTypesToolStripMenuItem";
            this.mangeAppliactionTypesToolStripMenuItem.Size = new System.Drawing.Size(445, 44);
            this.mangeAppliactionTypesToolStripMenuItem.Text = "Mange Appliaction Types ";
            this.mangeAppliactionTypesToolStripMenuItem.Click += new System.EventHandler(this.mangeAppliactionTypesToolStripMenuItem_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.depositToolStripMenuItem,
            this.withdrawToolStripMenuItem,
            this.transferToolStripMenuItem,
            this.transactionRecordToolStripMenuItem});
            this.transactionToolStripMenuItem.Image = global::BankManagementSystem.Properties.Resources.bank_transaction__2_;
            this.transactionToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(235, 68);
            this.transactionToolStripMenuItem.Text = "Transaction";
            // 
            // depositToolStripMenuItem
            // 
            this.depositToolStripMenuItem.Image = global::BankManagementSystem.Properties.Resources.deposit;
            this.depositToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.depositToolStripMenuItem.Name = "depositToolStripMenuItem";
            this.depositToolStripMenuItem.Size = new System.Drawing.Size(354, 42);
            this.depositToolStripMenuItem.Text = "Deposit";
            this.depositToolStripMenuItem.Click += new System.EventHandler(this.depositToolStripMenuItem_Click);
            // 
            // withdrawToolStripMenuItem
            // 
            this.withdrawToolStripMenuItem.Image = global::BankManagementSystem.Properties.Resources.withdrawal;
            this.withdrawToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.withdrawToolStripMenuItem.Name = "withdrawToolStripMenuItem";
            this.withdrawToolStripMenuItem.Size = new System.Drawing.Size(354, 42);
            this.withdrawToolStripMenuItem.Text = "Withdraw";
            this.withdrawToolStripMenuItem.Click += new System.EventHandler(this.withdrawToolStripMenuItem_Click);
            // 
            // transferToolStripMenuItem
            // 
            this.transferToolStripMenuItem.Image = global::BankManagementSystem.Properties.Resources.bank_transaction__1_;
            this.transferToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.transferToolStripMenuItem.Name = "transferToolStripMenuItem";
            this.transferToolStripMenuItem.Size = new System.Drawing.Size(354, 42);
            this.transferToolStripMenuItem.Text = "Transfer";
            this.transferToolStripMenuItem.Click += new System.EventHandler(this.transferToolStripMenuItem_Click);
            // 
            // transactionRecordToolStripMenuItem
            // 
            this.transactionRecordToolStripMenuItem.Image = global::BankManagementSystem.Properties.Resources.paper__1_;
            this.transactionRecordToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.transactionRecordToolStripMenuItem.Name = "transactionRecordToolStripMenuItem";
            this.transactionRecordToolStripMenuItem.Size = new System.Drawing.Size(354, 42);
            this.transactionRecordToolStripMenuItem.Text = "Transaction Record";
            this.transactionRecordToolStripMenuItem.Click += new System.EventHandler(this.transactionRecordToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::BankManagementSystem.Properties.Resources.bank__1_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 74);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1600, 655);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 729);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emplyeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logRegistersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appliactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chequeBookIssuanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem versionVisaFirstTimeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceVisaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeVisaPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openBankAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mangeAppliactionTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renewVisaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withdrawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionRecordToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem accountSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}