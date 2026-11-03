namespace BankManagementSystem.Appliaction.Control
{
    partial class ctrlBankAccountFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrlBankAccountFilter));
            this.label1 = new System.Windows.Forms.Label();
            this.cbFilter = new System.Windows.Forms.ComboBox();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbFind = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showClientInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAppliactionInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctrlBankAccountInfo1 = new BankManagementSystem.Appliaction.Control.ctrlBankAccountInfo();
            this.gbFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Find by";
            // 
            // cbFilter
            // 
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Items.AddRange(new object[] {
            "Bank Account ID",
            "Account Number"});
            this.cbFilter.Location = new System.Drawing.Point(94, 21);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(160, 24);
            this.cbFilter.TabIndex = 2;
            this.cbFilter.SelectedIndexChanged += new System.EventHandler(this.cbFilter_SelectedIndexChanged);
            // 
            // tbFind
            // 
            this.tbFind.Location = new System.Drawing.Point(261, 20);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(217, 24);
            this.tbFind.TabIndex = 3;
            this.tbFind.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFind_KeyPress);
            this.tbFind.Validating += new System.ComponentModel.CancelEventHandler(this.tbFind_Validating);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(484, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(62, 40);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gbFind
            // 
            this.gbFind.Controls.Add(this.btnSearch);
            this.gbFind.Controls.Add(this.label1);
            this.gbFind.Controls.Add(this.tbFind);
            this.gbFind.Controls.Add(this.cbFilter);
            this.gbFind.Location = new System.Drawing.Point(19, 4);
            this.gbFind.Name = "gbFind";
            this.gbFind.Size = new System.Drawing.Size(560, 52);
            this.gbFind.TabIndex = 5;
            this.gbFind.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showClientInfoToolStripMenuItem,
            this.showAppliactionInfoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(242, 108);
            // 
            // showClientInfoToolStripMenuItem
            // 
            this.showClientInfoToolStripMenuItem.Enabled = false;
            this.showClientInfoToolStripMenuItem.Image = global::BankManagementSystem.Properties.Resources.client_info;
            this.showClientInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showClientInfoToolStripMenuItem.Name = "showClientInfoToolStripMenuItem";
            this.showClientInfoToolStripMenuItem.Size = new System.Drawing.Size(241, 38);
            this.showClientInfoToolStripMenuItem.Text = "Show Client Info";
            this.showClientInfoToolStripMenuItem.Click += new System.EventHandler(this.showClientInfoToolStripMenuItem_Click);
            // 
            // showAppliactionInfoToolStripMenuItem
            // 
            this.showAppliactionInfoToolStripMenuItem.Enabled = false;
            this.showAppliactionInfoToolStripMenuItem.Image = global::BankManagementSystem.Properties.Resources.services_info;
            this.showAppliactionInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showAppliactionInfoToolStripMenuItem.Name = "showAppliactionInfoToolStripMenuItem";
            this.showAppliactionInfoToolStripMenuItem.Size = new System.Drawing.Size(241, 38);
            this.showAppliactionInfoToolStripMenuItem.Text = "Show Appliaction Info";
            this.showAppliactionInfoToolStripMenuItem.Click += new System.EventHandler(this.showAppliactionInfoToolStripMenuItem_Click);
            // 
            // ctrlBankAccountInfo1
            // 
            this.ctrlBankAccountInfo1.Location = new System.Drawing.Point(14, 62);
            this.ctrlBankAccountInfo1.Name = "ctrlBankAccountInfo1";
            this.ctrlBankAccountInfo1.Size = new System.Drawing.Size(696, 308);
            this.ctrlBankAccountInfo1.TabIndex = 0;
            // 
            // ctrlBankAccountFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.gbFind);
            this.Controls.Add(this.ctrlBankAccountInfo1);
            this.Name = "ctrlBankAccountFilter";
            this.Size = new System.Drawing.Size(709, 373);
            this.Load += new System.EventHandler(this.ctrlBankAccountFilter_Load);
            this.gbFind.ResumeLayout(false);
            this.gbFind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlBankAccountInfo ctrlBankAccountInfo1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFilter;
        private System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gbFind;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showClientInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAppliactionInfoToolStripMenuItem;
    }
}
