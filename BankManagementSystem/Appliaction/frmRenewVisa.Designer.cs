namespace BankManagementSystem.Appliaction
{
    partial class frmRenewVisa
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
            this.btnRenew = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ctrlFilterClient1 = new BankManagementSystem.Appliaction.Control.ctrlFilterClient();
            this.ctrlVisaInfo1 = new BankManagementSystem.Appliaction.Control.ctrlVisaInfo();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Renew Visa";
            // 
            // btnRenew
            // 
            this.btnRenew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRenew.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRenew.Location = new System.Drawing.Point(628, 519);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(119, 46);
            this.btnRenew.TabIndex = 2;
            this.btnRenew.Text = "Renew";
            this.btnRenew.UseVisualStyleBackColor = true;
            this.btnRenew.Click += new System.EventHandler(this.btnRenew_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(503, 519);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ctrlFilterClient1
            // 
            this.ctrlFilterClient1.Location = new System.Drawing.Point(12, 111);
            this.ctrlFilterClient1.Name = "ctrlFilterClient1";
            this.ctrlFilterClient1.Size = new System.Drawing.Size(612, 67);
            this.ctrlFilterClient1.TabIndex = 4;
            this.ctrlFilterClient1.OnClientSelected += new System.EventHandler<BankManagementSystem.Appliaction.Control.ctrlFilterClient.ClientSelectedEventArgs>(this.ctrlFilterClient1_OnClientSelected);
            // 
            // ctrlVisaInfo1
            // 
            this.ctrlVisaInfo1.Location = new System.Drawing.Point(12, 199);
            this.ctrlVisaInfo1.Name = "ctrlVisaInfo1";
            this.ctrlVisaInfo1.Size = new System.Drawing.Size(735, 305);
            this.ctrlVisaInfo1.TabIndex = 1;
            // 
            // frmRenewVisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 590);
            this.Controls.Add(this.ctrlFilterClient1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRenew);
            this.Controls.Add(this.ctrlVisaInfo1);
            this.Controls.Add(this.label1);
            this.Name = "frmRenewVisa";
            this.Text = "frmRenewVisa";
            this.Load += new System.EventHandler(this.frmRenewVisa_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Control.ctrlVisaInfo ctrlVisaInfo1;
        private System.Windows.Forms.Button btnRenew;
        private System.Windows.Forms.Button button1;
        private Control.ctrlFilterClient ctrlFilterClient1;
    }
}