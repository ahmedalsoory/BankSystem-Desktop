namespace BankManagementSystem.Transaction
{
    partial class frmTransfer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpClientSoures = new System.Windows.Forms.TabPage();
            this.ctrlBankAccountFilterSoures = new BankManagementSystem.Appliaction.Control.ctrlBankAccountFilter();
            this.tpClientDestination = new System.Windows.Forms.TabPage();
            this.ctrlBankAccountFilterDestionstion = new BankManagementSystem.Appliaction.Control.ctrlBankAccountFilter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tpClientSoures.SuspendLayout();
            this.tpClientDestination.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Transfer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Amount";
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(130, 62);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(192, 24);
            this.tbAmount.TabIndex = 4;
            this.tbAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAmount_KeyPress);
            this.tbAmount.Validating += new System.ComponentModel.CancelEventHandler(this.tbAmount_Validating);
            // 
            // btnTransfer
            // 
            this.btnTransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransfer.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransfer.Image = global::BankManagementSystem.Properties.Resources.return_on_investment;
            this.btnTransfer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransfer.Location = new System.Drawing.Point(607, 571);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(184, 53);
            this.btnTransfer.TabIndex = 5;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(437, 571);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(164, 53);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbAmount);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 538);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Amount";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpClientSoures);
            this.tabControl1.Controls.Add(this.tpClientDestination);
            this.tabControl1.Location = new System.Drawing.Point(12, 71);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(779, 461);
            this.tabControl1.TabIndex = 10;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tpClientSoures
            // 
            this.tpClientSoures.Controls.Add(this.ctrlBankAccountFilterSoures);
            this.tpClientSoures.Location = new System.Drawing.Point(4, 25);
            this.tpClientSoures.Name = "tpClientSoures";
            this.tpClientSoures.Padding = new System.Windows.Forms.Padding(3);
            this.tpClientSoures.Size = new System.Drawing.Size(771, 432);
            this.tpClientSoures.TabIndex = 0;
            this.tpClientSoures.Text = "Client Soures";
            this.tpClientSoures.UseVisualStyleBackColor = true;
            // 
            // ctrlBankAccountFilterSoures
            // 
            this.ctrlBankAccountFilterSoures.Location = new System.Drawing.Point(22, 17);
            this.ctrlBankAccountFilterSoures.Name = "ctrlBankAccountFilterSoures";
            this.ctrlBankAccountFilterSoures.Size = new System.Drawing.Size(709, 373);
            this.ctrlBankAccountFilterSoures.TabIndex = 0;
            this.ctrlBankAccountFilterSoures.OnClientSelected += new System.EventHandler<BankManagementSystem.Appliaction.Control.ctrlBankAccountFilter.CoustemEventArgs>(this.ctrlBankAccountFilterSoures_OnClientSelected);
            // 
            // tpClientDestination
            // 
            this.tpClientDestination.Controls.Add(this.ctrlBankAccountFilterDestionstion);
            this.tpClientDestination.Location = new System.Drawing.Point(4, 25);
            this.tpClientDestination.Name = "tpClientDestination";
            this.tpClientDestination.Padding = new System.Windows.Forms.Padding(3);
            this.tpClientDestination.Size = new System.Drawing.Size(771, 432);
            this.tpClientDestination.TabIndex = 1;
            this.tpClientDestination.Text = "ClientDestination";
            this.tpClientDestination.UseVisualStyleBackColor = true;
            // 
            // ctrlBankAccountFilterDestionstion
            // 
            this.ctrlBankAccountFilterDestionstion.Location = new System.Drawing.Point(22, 21);
            this.ctrlBankAccountFilterDestionstion.Name = "ctrlBankAccountFilterDestionstion";
            this.ctrlBankAccountFilterDestionstion.Size = new System.Drawing.Size(709, 373);
            this.ctrlBankAccountFilterDestionstion.TabIndex = 0;
            this.ctrlBankAccountFilterDestionstion.OnClientSelected += new System.EventHandler<BankManagementSystem.Appliaction.Control.ctrlBankAccountFilter.CoustemEventArgs>(this.ctrlBankAccountFilterDestionstion_OnClientSelected);
            // 
            // frmTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 650);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnTransfer);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTransfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmTransfer";
            this.Load += new System.EventHandler(this.frmTransfer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tpClientSoures.ResumeLayout(false);
            this.tpClientDestination.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpClientSoures;
        private Appliaction.Control.ctrlBankAccountFilter ctrlBankAccountFilterSoures;
        private System.Windows.Forms.TabPage tpClientDestination;
        private Appliaction.Control.ctrlBankAccountFilter ctrlBankAccountFilterDestionstion;
    }
}