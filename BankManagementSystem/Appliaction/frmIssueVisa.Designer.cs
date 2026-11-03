namespace BankManagementSystem.Appliaction
{
    partial class frmIssueVisa
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
            this.btnIssue = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ctrlVisaInfo1 = new BankManagementSystem.Appliaction.Control.ctrlVisaInfo();
            this.ctrlFilterClient1 = new BankManagementSystem.Appliaction.Control.ctrlFilterClient();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Issue Visa";
            // 
            // btnIssue
            // 
            this.btnIssue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssue.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssue.Location = new System.Drawing.Point(641, 513);
            this.btnIssue.Name = "btnIssue";
            this.btnIssue.Size = new System.Drawing.Size(122, 51);
            this.btnIssue.TabIndex = 2;
            this.btnIssue.Text = "Issue";
            this.btnIssue.UseVisualStyleBackColor = true;
            this.btnIssue.Click += new System.EventHandler(this.btnIssue_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(501, 513);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(122, 51);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // ctrlVisaInfo1
            // 
            this.ctrlVisaInfo1.Location = new System.Drawing.Point(25, 178);
            this.ctrlVisaInfo1.Name = "ctrlVisaInfo1";
            this.ctrlVisaInfo1.Size = new System.Drawing.Size(738, 305);
            this.ctrlVisaInfo1.TabIndex = 1;
            // 
            // ctrlFilterClient1
            // 
            this.ctrlFilterClient1.Location = new System.Drawing.Point(25, 105);
            this.ctrlFilterClient1.Name = "ctrlFilterClient1";
            this.ctrlFilterClient1.Size = new System.Drawing.Size(612, 67);
            this.ctrlFilterClient1.TabIndex = 4;
            this.ctrlFilterClient1.OnClientSelected += new System.EventHandler<BankManagementSystem.Appliaction.Control.ctrlFilterClient.ClientSelectedEventArgs>(this.ctrlFilterClient1_OnClientSelected);
            this.ctrlFilterClient1.Load += new System.EventHandler(this.ctrlFilterClient1_Load);
            // 
            // frmIssueVisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 588);
            this.Controls.Add(this.ctrlFilterClient1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnIssue);
            this.Controls.Add(this.ctrlVisaInfo1);
            this.Controls.Add(this.label1);
            this.Name = "frmIssueVisa";
            this.Text = "Issue Visa";
            this.Load += new System.EventHandler(this.frmIssueVisa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Control.ctrlVisaInfo ctrlVisaInfo1;
        private System.Windows.Forms.Button btnIssue;
        private System.Windows.Forms.Button btnClose;
        private Control.ctrlFilterClient ctrlFilterClient1;
    }
}