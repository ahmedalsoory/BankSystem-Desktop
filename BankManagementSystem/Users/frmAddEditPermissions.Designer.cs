namespace BankManagementSystem.Users
{
    partial class frmAddEditPermissions
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbDeleteClient = new System.Windows.Forms.CheckBox();
            this.ckbUpdateClient = new System.Windows.Forms.CheckBox();
            this.ckbAddNewClient = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ckbDeleteUser = new System.Windows.Forms.CheckBox();
            this.ckbUpdateUser = new System.Windows.Forms.CheckBox();
            this.ckbAddNewUser = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ckbRenewVisa = new System.Windows.Forms.CheckBox();
            this.ckbOpenBankAccount = new System.Windows.Forms.CheckBox();
            this.ckbReplaceVisa = new System.Windows.Forms.CheckBox();
            this.ckbVersionVisaFirstTime = new System.Windows.Forms.CheckBox();
            this.ckbChequeBookIssuance = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ckbDeleteEmplyee = new System.Windows.Forms.CheckBox();
            this.ckbUpdateEmplyee = new System.Windows.Forms.CheckBox();
            this.ckbaAddNewEmplyees = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.ckbLogRegistersList = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.ckbTransactionRecord = new System.Windows.Forms.CheckBox();
            this.chkTransfer = new System.Windows.Forms.CheckBox();
            this.ckbWithdraw = new System.Windows.Forms.CheckBox();
            this.ckbDeposit = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbDeleteClient);
            this.groupBox1.Controls.Add(this.ckbUpdateClient);
            this.groupBox1.Controls.Add(this.ckbAddNewClient);
            this.groupBox1.Location = new System.Drawing.Point(12, 201);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client";
            // 
            // ckbDeleteClient
            // 
            this.ckbDeleteClient.AutoSize = true;
            this.ckbDeleteClient.Location = new System.Drawing.Point(6, 135);
            this.ckbDeleteClient.Name = "ckbDeleteClient";
            this.ckbDeleteClient.Size = new System.Drawing.Size(105, 21);
            this.ckbDeleteClient.TabIndex = 2;
            this.ckbDeleteClient.Tag = "4";
            this.ckbDeleteClient.Text = "Delete Client";
            this.ckbDeleteClient.UseVisualStyleBackColor = true;
            this.ckbDeleteClient.CheckedChanged += new System.EventHandler(this.ckbPermissionsClient);
            // 
            // ckbUpdateClient
            // 
            this.ckbUpdateClient.AutoSize = true;
            this.ckbUpdateClient.Location = new System.Drawing.Point(6, 90);
            this.ckbUpdateClient.Name = "ckbUpdateClient";
            this.ckbUpdateClient.Size = new System.Drawing.Size(111, 21);
            this.ckbUpdateClient.TabIndex = 1;
            this.ckbUpdateClient.Tag = "2";
            this.ckbUpdateClient.Text = "Update Client";
            this.ckbUpdateClient.UseVisualStyleBackColor = true;
            this.ckbUpdateClient.CheckedChanged += new System.EventHandler(this.ckbPermissionsClient);
            // 
            // ckbAddNewClient
            // 
            this.ckbAddNewClient.AutoSize = true;
            this.ckbAddNewClient.Location = new System.Drawing.Point(6, 41);
            this.ckbAddNewClient.Name = "ckbAddNewClient";
            this.ckbAddNewClient.Size = new System.Drawing.Size(121, 21);
            this.ckbAddNewClient.TabIndex = 0;
            this.ckbAddNewClient.Tag = "1";
            this.ckbAddNewClient.Text = "Add New Client";
            this.ckbAddNewClient.UseVisualStyleBackColor = true;
            this.ckbAddNewClient.CheckedChanged += new System.EventHandler(this.ckbPermissionsClient);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ckbDeleteUser);
            this.groupBox2.Controls.Add(this.ckbUpdateUser);
            this.groupBox2.Controls.Add(this.ckbAddNewUser);
            this.groupBox2.Location = new System.Drawing.Point(229, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 185);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User";
            // 
            // ckbDeleteUser
            // 
            this.ckbDeleteUser.AutoSize = true;
            this.ckbDeleteUser.Location = new System.Drawing.Point(6, 135);
            this.ckbDeleteUser.Name = "ckbDeleteUser";
            this.ckbDeleteUser.Size = new System.Drawing.Size(99, 21);
            this.ckbDeleteUser.TabIndex = 2;
            this.ckbDeleteUser.Tag = "4";
            this.ckbDeleteUser.Text = "Delete User";
            this.ckbDeleteUser.UseVisualStyleBackColor = true;
            this.ckbDeleteUser.CheckedChanged += new System.EventHandler(this.ckbPermissionsUser);
            // 
            // ckbUpdateUser
            // 
            this.ckbUpdateUser.AutoSize = true;
            this.ckbUpdateUser.Location = new System.Drawing.Point(6, 90);
            this.ckbUpdateUser.Name = "ckbUpdateUser";
            this.ckbUpdateUser.Size = new System.Drawing.Size(105, 21);
            this.ckbUpdateUser.TabIndex = 1;
            this.ckbUpdateUser.Tag = "2";
            this.ckbUpdateUser.Text = "Update User";
            this.ckbUpdateUser.UseVisualStyleBackColor = true;
            this.ckbUpdateUser.CheckedChanged += new System.EventHandler(this.ckbPermissionsUser);
            // 
            // ckbAddNewUser
            // 
            this.ckbAddNewUser.AutoSize = true;
            this.ckbAddNewUser.Location = new System.Drawing.Point(6, 41);
            this.ckbAddNewUser.Name = "ckbAddNewUser";
            this.ckbAddNewUser.Size = new System.Drawing.Size(115, 21);
            this.ckbAddNewUser.TabIndex = 0;
            this.ckbAddNewUser.Tag = "1";
            this.ckbAddNewUser.Text = "Add New User";
            this.ckbAddNewUser.UseVisualStyleBackColor = true;
            this.ckbAddNewUser.CheckedChanged += new System.EventHandler(this.ckbPermissionsUser);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ckbRenewVisa);
            this.groupBox3.Controls.Add(this.ckbOpenBankAccount);
            this.groupBox3.Controls.Add(this.ckbReplaceVisa);
            this.groupBox3.Controls.Add(this.ckbVersionVisaFirstTime);
            this.groupBox3.Controls.Add(this.ckbChequeBookIssuance);
            this.groupBox3.Location = new System.Drawing.Point(463, 201);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(189, 266);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Applications";
            // 
            // ckbRenewVisa
            // 
            this.ckbRenewVisa.AutoSize = true;
            this.ckbRenewVisa.Location = new System.Drawing.Point(6, 135);
            this.ckbRenewVisa.Name = "ckbRenewVisa";
            this.ckbRenewVisa.Size = new System.Drawing.Size(98, 21);
            this.ckbRenewVisa.TabIndex = 5;
            this.ckbRenewVisa.Tag = "8";
            this.ckbRenewVisa.Text = "Renew Visa";
            this.ckbRenewVisa.UseVisualStyleBackColor = true;
            this.ckbRenewVisa.CheckedChanged += new System.EventHandler(this.ckbPermissionsApplication);
            // 
            // ckbOpenBankAccount
            // 
            this.ckbOpenBankAccount.AutoSize = true;
            this.ckbOpenBankAccount.Location = new System.Drawing.Point(6, 222);
            this.ckbOpenBankAccount.Name = "ckbOpenBankAccount";
            this.ckbOpenBankAccount.Size = new System.Drawing.Size(152, 21);
            this.ckbOpenBankAccount.TabIndex = 4;
            this.ckbOpenBankAccount.Tag = "1";
            this.ckbOpenBankAccount.Text = "Open Bank Account";
            this.ckbOpenBankAccount.UseVisualStyleBackColor = true;
            this.ckbOpenBankAccount.CheckedChanged += new System.EventHandler(this.ckbPermissionsApplication);
            // 
            // ckbReplaceVisa
            // 
            this.ckbReplaceVisa.AutoSize = true;
            this.ckbReplaceVisa.Location = new System.Drawing.Point(6, 173);
            this.ckbReplaceVisa.Name = "ckbReplaceVisa";
            this.ckbReplaceVisa.Size = new System.Drawing.Size(104, 21);
            this.ckbReplaceVisa.TabIndex = 3;
            this.ckbReplaceVisa.Tag = "16";
            this.ckbReplaceVisa.Text = "Replace Visa";
            this.ckbReplaceVisa.UseVisualStyleBackColor = true;
            this.ckbReplaceVisa.CheckedChanged += new System.EventHandler(this.ckbPermissionsApplication);
            // 
            // ckbVersionVisaFirstTime
            // 
            this.ckbVersionVisaFirstTime.AutoSize = true;
            this.ckbVersionVisaFirstTime.Location = new System.Drawing.Point(6, 90);
            this.ckbVersionVisaFirstTime.Name = "ckbVersionVisaFirstTime";
            this.ckbVersionVisaFirstTime.Size = new System.Drawing.Size(163, 21);
            this.ckbVersionVisaFirstTime.TabIndex = 1;
            this.ckbVersionVisaFirstTime.Tag = "4";
            this.ckbVersionVisaFirstTime.Text = "Version Visa First Time";
            this.ckbVersionVisaFirstTime.UseVisualStyleBackColor = true;
            this.ckbVersionVisaFirstTime.CheckedChanged += new System.EventHandler(this.ckbPermissionsApplication);
            // 
            // ckbChequeBookIssuance
            // 
            this.ckbChequeBookIssuance.AutoSize = true;
            this.ckbChequeBookIssuance.Location = new System.Drawing.Point(6, 41);
            this.ckbChequeBookIssuance.Name = "ckbChequeBookIssuance";
            this.ckbChequeBookIssuance.Size = new System.Drawing.Size(169, 21);
            this.ckbChequeBookIssuance.TabIndex = 0;
            this.ckbChequeBookIssuance.Tag = "2";
            this.ckbChequeBookIssuance.Text = "Cheque Book Issuance";
            this.ckbChequeBookIssuance.UseVisualStyleBackColor = true;
            this.ckbChequeBookIssuance.CheckedChanged += new System.EventHandler(this.ckbPermissionsApplication);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ckbDeleteEmplyee);
            this.groupBox4.Controls.Add(this.ckbUpdateEmplyee);
            this.groupBox4.Controls.Add(this.ckbaAddNewEmplyees);
            this.groupBox4.Location = new System.Drawing.Point(12, 405);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(175, 185);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Emplyee";
            // 
            // ckbDeleteEmplyee
            // 
            this.ckbDeleteEmplyee.AutoSize = true;
            this.ckbDeleteEmplyee.Location = new System.Drawing.Point(6, 135);
            this.ckbDeleteEmplyee.Name = "ckbDeleteEmplyee";
            this.ckbDeleteEmplyee.Size = new System.Drawing.Size(130, 21);
            this.ckbDeleteEmplyee.TabIndex = 2;
            this.ckbDeleteEmplyee.Tag = "4";
            this.ckbDeleteEmplyee.Text = "Delete Emplyees";
            this.ckbDeleteEmplyee.UseVisualStyleBackColor = true;
            this.ckbDeleteEmplyee.CheckedChanged += new System.EventHandler(this.ckbPermissionsEmplyee);
            // 
            // ckbUpdateEmplyee
            // 
            this.ckbUpdateEmplyee.AutoSize = true;
            this.ckbUpdateEmplyee.Location = new System.Drawing.Point(6, 90);
            this.ckbUpdateEmplyee.Name = "ckbUpdateEmplyee";
            this.ckbUpdateEmplyee.Size = new System.Drawing.Size(136, 21);
            this.ckbUpdateEmplyee.TabIndex = 1;
            this.ckbUpdateEmplyee.Tag = "2";
            this.ckbUpdateEmplyee.Text = "Update Emplyees";
            this.ckbUpdateEmplyee.UseVisualStyleBackColor = true;
            this.ckbUpdateEmplyee.CheckedChanged += new System.EventHandler(this.ckbPermissionsEmplyee);
            // 
            // ckbaAddNewEmplyees
            // 
            this.ckbaAddNewEmplyees.AutoSize = true;
            this.ckbaAddNewEmplyees.Location = new System.Drawing.Point(6, 41);
            this.ckbaAddNewEmplyees.Name = "ckbaAddNewEmplyees";
            this.ckbaAddNewEmplyees.Size = new System.Drawing.Size(140, 21);
            this.ckbaAddNewEmplyees.TabIndex = 0;
            this.ckbaAddNewEmplyees.Tag = "1";
            this.ckbaAddNewEmplyees.Text = "Add New Emplyee";
            this.ckbaAddNewEmplyees.UseVisualStyleBackColor = true;
            this.ckbaAddNewEmplyees.CheckedChanged += new System.EventHandler(this.ckbPermissionsEmplyee);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.ckbLogRegistersList);
            this.groupBox5.Location = new System.Drawing.Point(466, 518);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(186, 90);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Log Registers";
            // 
            // ckbLogRegistersList
            // 
            this.ckbLogRegistersList.AutoSize = true;
            this.ckbLogRegistersList.Location = new System.Drawing.Point(6, 41);
            this.ckbLogRegistersList.Name = "ckbLogRegistersList";
            this.ckbLogRegistersList.Size = new System.Drawing.Size(174, 21);
            this.ckbLogRegistersList.TabIndex = 0;
            this.ckbLogRegistersList.Tag = "1";
            this.ckbLogRegistersList.Text = "Show Log Registers List";
            this.ckbLogRegistersList.UseVisualStyleBackColor = true;
            this.ckbLogRegistersList.CheckedChanged += new System.EventHandler(this.ckbLogRegistersList_CheckedChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.ckbTransactionRecord);
            this.groupBox6.Controls.Add(this.chkTransfer);
            this.groupBox6.Controls.Add(this.ckbWithdraw);
            this.groupBox6.Controls.Add(this.ckbDeposit);
            this.groupBox6.Location = new System.Drawing.Point(229, 405);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(175, 214);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Transaction";
            // 
            // ckbTransactionRecord
            // 
            this.ckbTransactionRecord.AutoSize = true;
            this.ckbTransactionRecord.Location = new System.Drawing.Point(7, 173);
            this.ckbTransactionRecord.Name = "ckbTransactionRecord";
            this.ckbTransactionRecord.Size = new System.Drawing.Size(149, 21);
            this.ckbTransactionRecord.TabIndex = 3;
            this.ckbTransactionRecord.Tag = "8";
            this.ckbTransactionRecord.Text = "Transaction Record";
            this.ckbTransactionRecord.UseVisualStyleBackColor = true;
            this.ckbTransactionRecord.CheckedChanged += new System.EventHandler(this.ckbPermissionsTransaction);
            // 
            // chkTransfer
            // 
            this.chkTransfer.AutoSize = true;
            this.chkTransfer.Location = new System.Drawing.Point(6, 135);
            this.chkTransfer.Name = "chkTransfer";
            this.chkTransfer.Size = new System.Drawing.Size(80, 21);
            this.chkTransfer.TabIndex = 2;
            this.chkTransfer.Tag = "4";
            this.chkTransfer.Text = "Transfer";
            this.chkTransfer.UseVisualStyleBackColor = true;
            this.chkTransfer.CheckedChanged += new System.EventHandler(this.ckbPermissionsTransaction);
            // 
            // ckbWithdraw
            // 
            this.ckbWithdraw.AutoSize = true;
            this.ckbWithdraw.Location = new System.Drawing.Point(6, 90);
            this.ckbWithdraw.Name = "ckbWithdraw";
            this.ckbWithdraw.Size = new System.Drawing.Size(89, 21);
            this.ckbWithdraw.TabIndex = 1;
            this.ckbWithdraw.Tag = "2";
            this.ckbWithdraw.Text = "Withdraw";
            this.ckbWithdraw.UseVisualStyleBackColor = true;
            this.ckbWithdraw.CheckedChanged += new System.EventHandler(this.ckbPermissionsTransaction);
            // 
            // ckbDeposit
            // 
            this.ckbDeposit.AutoSize = true;
            this.ckbDeposit.Location = new System.Drawing.Point(6, 41);
            this.ckbDeposit.Name = "ckbDeposit";
            this.ckbDeposit.Size = new System.Drawing.Size(76, 21);
            this.ckbDeposit.TabIndex = 0;
            this.ckbDeposit.Tag = "1";
            this.ckbDeposit.Text = "Deposit";
            this.ckbDeposit.UseVisualStyleBackColor = true;
            this.ckbDeposit.CheckedChanged += new System.EventHandler(this.ckbPermissionsTransaction);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 45);
            this.label1.TabIndex = 6;
            this.label1.Text = "Permissions";
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(539, 627);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 44);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(410, 626);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(113, 44);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmAddEditPermissions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 682);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAddEditPermissions";
            this.Text = "frmAddEditPermissions";
            this.Load += new System.EventHandler(this.frmAddEditPermissions_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbDeleteClient;
        private System.Windows.Forms.CheckBox ckbUpdateClient;
        private System.Windows.Forms.CheckBox ckbAddNewClient;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ckbDeleteUser;
        private System.Windows.Forms.CheckBox ckbUpdateUser;
        private System.Windows.Forms.CheckBox ckbAddNewUser;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox ckbVersionVisaFirstTime;
        private System.Windows.Forms.CheckBox ckbChequeBookIssuance;
        private System.Windows.Forms.CheckBox ckbRenewVisa;
        private System.Windows.Forms.CheckBox ckbOpenBankAccount;
        private System.Windows.Forms.CheckBox ckbReplaceVisa;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox ckbDeleteEmplyee;
        private System.Windows.Forms.CheckBox ckbUpdateEmplyee;
        private System.Windows.Forms.CheckBox ckbaAddNewEmplyees;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox ckbLogRegistersList;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox chkTransfer;
        private System.Windows.Forms.CheckBox ckbWithdraw;
        private System.Windows.Forms.CheckBox ckbDeposit;
        private System.Windows.Forms.CheckBox ckbTransactionRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}