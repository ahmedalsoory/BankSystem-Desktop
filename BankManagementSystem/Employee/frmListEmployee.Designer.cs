namespace BankManagementSystem.Employee
{
    partial class frmListEmployee
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
            this.dgvEmployeeList = new System.Windows.Forms.DataGridView();
            this.cmsEmplyee = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showEmployeeInfoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewEmployeeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateEmployeeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEmployeeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lbReocrd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.showEmployeeInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).BeginInit();
            this.cmsEmplyee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployeeList
            // 
            this.dgvEmployeeList.AllowUserToAddRows = false;
            this.dgvEmployeeList.AllowUserToDeleteRows = false;
            this.dgvEmployeeList.AllowUserToOrderColumns = true;
            this.dgvEmployeeList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvEmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployeeList.ContextMenuStrip = this.cmsEmplyee;
            this.dgvEmployeeList.Location = new System.Drawing.Point(12, 220);
            this.dgvEmployeeList.Name = "dgvEmployeeList";
            this.dgvEmployeeList.ReadOnly = true;
            this.dgvEmployeeList.RowHeadersWidth = 51;
            this.dgvEmployeeList.RowTemplate.Height = 26;
            this.dgvEmployeeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmployeeList.Size = new System.Drawing.Size(1116, 406);
            this.dgvEmployeeList.TabIndex = 0;
            // 
            // cmsEmplyee
            // 
            this.cmsEmplyee.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmsEmplyee.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showEmployeeInfoToolStripMenuItem1,
            this.addNewEmployeeToolStripMenuItem1,
            this.updateEmployeeToolStripMenuItem1,
            this.deleteEmployeeToolStripMenuItem1});
            this.cmsEmplyee.Name = "cmsEmplyee";
            this.cmsEmplyee.Size = new System.Drawing.Size(231, 156);
            // 
            // showEmployeeInfoToolStripMenuItem1
            // 
            this.showEmployeeInfoToolStripMenuItem1.Image = global::BankManagementSystem.Properties.Resources.salesman;
            this.showEmployeeInfoToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showEmployeeInfoToolStripMenuItem1.Name = "showEmployeeInfoToolStripMenuItem1";
            this.showEmployeeInfoToolStripMenuItem1.Size = new System.Drawing.Size(230, 38);
            this.showEmployeeInfoToolStripMenuItem1.Text = "Show Employee Info";
            this.showEmployeeInfoToolStripMenuItem1.Click += new System.EventHandler(this.showEmployeeInfoToolStripMenuItem_Click);
            // 
            // addNewEmployeeToolStripMenuItem1
            // 
            this.addNewEmployeeToolStripMenuItem1.Image = global::BankManagementSystem.Properties.Resources.salesman__4_;
            this.addNewEmployeeToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewEmployeeToolStripMenuItem1.Name = "addNewEmployeeToolStripMenuItem1";
            this.addNewEmployeeToolStripMenuItem1.Size = new System.Drawing.Size(230, 38);
            this.addNewEmployeeToolStripMenuItem1.Text = "Add New Employee";
            this.addNewEmployeeToolStripMenuItem1.Click += new System.EventHandler(this.addNewEmployeeToolStripMenuItem_Click);
            // 
            // updateEmployeeToolStripMenuItem1
            // 
            this.updateEmployeeToolStripMenuItem1.Image = global::BankManagementSystem.Properties.Resources.salesman__3_;
            this.updateEmployeeToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.updateEmployeeToolStripMenuItem1.Name = "updateEmployeeToolStripMenuItem1";
            this.updateEmployeeToolStripMenuItem1.Size = new System.Drawing.Size(230, 38);
            this.updateEmployeeToolStripMenuItem1.Text = "Update Employee";
            this.updateEmployeeToolStripMenuItem1.Click += new System.EventHandler(this.updateEmployeeToolStripMenuItem_Click);
            // 
            // deleteEmployeeToolStripMenuItem1
            // 
            this.deleteEmployeeToolStripMenuItem1.Image = global::BankManagementSystem.Properties.Resources.salesman__2_;
            this.deleteEmployeeToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteEmployeeToolStripMenuItem1.Name = "deleteEmployeeToolStripMenuItem1";
            this.deleteEmployeeToolStripMenuItem1.Size = new System.Drawing.Size(230, 38);
            this.deleteEmployeeToolStripMenuItem1.Text = "Delete Employee";
            this.deleteEmployeeToolStripMenuItem1.Click += new System.EventHandler(this.deleteEmployeeToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(421, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Employees List";
            // 
            // lbReocrd
            // 
            this.lbReocrd.AutoSize = true;
            this.lbReocrd.Location = new System.Drawing.Point(146, 639);
            this.lbReocrd.Name = "lbReocrd";
            this.lbReocrd.Size = new System.Drawing.Size(16, 17);
            this.lbReocrd.TabIndex = 4;
            this.lbReocrd.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 629);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "#Record : ";
            // 
            // showEmployeeInfoToolStripMenuItem
            // 
            this.showEmployeeInfoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.showEmployeeInfoToolStripMenuItem.Name = "showEmployeeInfoToolStripMenuItem";
            this.showEmployeeInfoToolStripMenuItem.Size = new System.Drawing.Size(214, 24);
            this.showEmployeeInfoToolStripMenuItem.Text = "Show Employee Info";
            this.showEmployeeInfoToolStripMenuItem.Click += new System.EventHandler(this.showEmployeeInfoToolStripMenuItem_Click);
            // 
            // addNewEmployeeToolStripMenuItem
            // 
            this.addNewEmployeeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addNewEmployeeToolStripMenuItem.Name = "addNewEmployeeToolStripMenuItem";
            this.addNewEmployeeToolStripMenuItem.Size = new System.Drawing.Size(214, 24);
            this.addNewEmployeeToolStripMenuItem.Text = "Add New Employee";
            this.addNewEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addNewEmployeeToolStripMenuItem_Click);
            // 
            // updateEmployeeToolStripMenuItem
            // 
            this.updateEmployeeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.updateEmployeeToolStripMenuItem.Name = "updateEmployeeToolStripMenuItem";
            this.updateEmployeeToolStripMenuItem.Size = new System.Drawing.Size(214, 24);
            this.updateEmployeeToolStripMenuItem.Text = "Update Employee";
            this.updateEmployeeToolStripMenuItem.Click += new System.EventHandler(this.updateEmployeeToolStripMenuItem_Click);
            // 
            // deleteEmployeeToolStripMenuItem
            // 
            this.deleteEmployeeToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteEmployeeToolStripMenuItem.Name = "deleteEmployeeToolStripMenuItem";
            this.deleteEmployeeToolStripMenuItem.Size = new System.Drawing.Size(214, 24);
            this.deleteEmployeeToolStripMenuItem.Text = "Delete Employee";
            this.deleteEmployeeToolStripMenuItem.Click += new System.EventHandler(this.deleteEmployeeToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BankManagementSystem.Properties.Resources.employee;
            this.pictureBox1.Location = new System.Drawing.Point(454, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmListEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 685);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbReocrd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvEmployeeList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmListEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "76";
            this.Load += new System.EventHandler(this.frmListEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployeeList)).EndInit();
            this.cmsEmplyee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployeeList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbReocrd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip cmsEmplyee;
        private System.Windows.Forms.ToolStripMenuItem showEmployeeInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showEmployeeInfoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addNewEmployeeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateEmployeeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteEmployeeToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}