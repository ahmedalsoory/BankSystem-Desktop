namespace BankManagementSystem.Appliaction
{
    partial class frmReplaceVisa
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
            this.label1 = new System.Windows.Forms.Label();
            this.ctrlApplicationInfo1 = new BankManagementSystem.Appliaction.Control.ctrlApplicationInfo();
            this.gbReplaceFor = new System.Windows.Forms.GroupBox();
            this.rbDamage = new System.Windows.Forms.RadioButton();
            this.rbLost = new System.Windows.Forms.RadioButton();
            this.ctrlFilterClient1 = new BankManagementSystem.Appliaction.Control.ctrlFilterClient();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbReplaceFor.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Replace Visa";
            // 
            // ctrlApplicationInfo1
            // 
            this.ctrlApplicationInfo1.Location = new System.Drawing.Point(18, 194);
            this.ctrlApplicationInfo1.Name = "ctrlApplicationInfo1";
            this.ctrlApplicationInfo1.Size = new System.Drawing.Size(792, 280);
            this.ctrlApplicationInfo1.TabIndex = 1;
            // 
            // gbReplaceFor
            // 
            this.gbReplaceFor.Controls.Add(this.rbDamage);
            this.gbReplaceFor.Controls.Add(this.rbLost);
            this.gbReplaceFor.Location = new System.Drawing.Point(634, 82);
            this.gbReplaceFor.Name = "gbReplaceFor";
            this.gbReplaceFor.Size = new System.Drawing.Size(176, 122);
            this.gbReplaceFor.TabIndex = 2;
            this.gbReplaceFor.TabStop = false;
            this.gbReplaceFor.Text = "Replace For";
            // 
            // rbDamage
            // 
            this.rbDamage.AutoSize = true;
            this.rbDamage.Location = new System.Drawing.Point(8, 73);
            this.rbDamage.Name = "rbDamage";
            this.rbDamage.Size = new System.Drawing.Size(155, 21);
            this.rbDamage.TabIndex = 1;
            this.rbDamage.Tag = "5";
            this.rbDamage.Text = "Replace For Damage";
            this.rbDamage.UseVisualStyleBackColor = true;
            // 
            // rbLost
            // 
            this.rbLost.AutoSize = true;
            this.rbLost.Checked = true;
            this.rbLost.Location = new System.Drawing.Point(8, 37);
            this.rbLost.Name = "rbLost";
            this.rbLost.Size = new System.Drawing.Size(130, 21);
            this.rbLost.TabIndex = 0;
            this.rbLost.TabStop = true;
            this.rbLost.Tag = "4";
            this.rbLost.Text = "Replace For Lost";
            this.rbLost.UseVisualStyleBackColor = true;
            this.rbLost.CheckedChanged += new System.EventHandler(this.rbLost_CheckedChanged);
            // 
            // ctrlFilterClient1
            // 
            this.ctrlFilterClient1.Location = new System.Drawing.Point(6, 121);
            this.ctrlFilterClient1.Name = "ctrlFilterClient1";
            this.ctrlFilterClient1.Size = new System.Drawing.Size(612, 67);
            this.ctrlFilterClient1.TabIndex = 3;
            this.ctrlFilterClient1.OnClientSelected += new System.EventHandler<BankManagementSystem.Appliaction.Control.ctrlFilterClient.ClientSelectedEventArgs>(this.ctrlFilterClient1_OnClientSelected);
            // 
            // btnReplace
            // 
            this.btnReplace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReplace.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplace.Location = new System.Drawing.Point(705, 480);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(105, 43);
            this.btnReplace.TabIndex = 4;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(594, 480);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(105, 43);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmReplaceVisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 542);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.ctrlFilterClient1);
            this.Controls.Add(this.gbReplaceFor);
            this.Controls.Add(this.ctrlApplicationInfo1);
            this.Controls.Add(this.label1);
            this.Name = "frmReplaceVisa";
            this.Text = "frmReplaceVisa";
            this.Load += new System.EventHandler(this.frmReplaceVisa_Load);
            this.gbReplaceFor.ResumeLayout(false);
            this.gbReplaceFor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Control.ctrlApplicationInfo ctrlApplicationInfo1;
        private System.Windows.Forms.GroupBox gbReplaceFor;
        private System.Windows.Forms.RadioButton rbDamage;
        private System.Windows.Forms.RadioButton rbLost;
        private Control.ctrlFilterClient ctrlFilterClient1;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnClose;
    }
}