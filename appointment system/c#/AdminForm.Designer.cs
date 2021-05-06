namespace ProjeSon
{
    partial class AdminForm
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
            this.companyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.companyEmployeeAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.aLLUSERSHOWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // companyToolStripMenuItem
            // 
            this.companyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.companyAddToolStripMenuItem,
            this.companyUpdateToolStripMenuItem,
            this.companyDeleteToolStripMenuItem});
            this.companyToolStripMenuItem.Name = "companyToolStripMenuItem";
            this.companyToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.companyToolStripMenuItem.Text = "Company Operations";
            // 
            // companyAddToolStripMenuItem
            // 
            this.companyAddToolStripMenuItem.Name = "companyAddToolStripMenuItem";
            this.companyAddToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.companyAddToolStripMenuItem.Text = "Company Add";
            this.companyAddToolStripMenuItem.Click += new System.EventHandler(this.companyAddToolStripMenuItem_Click);
            // 
            // companyUpdateToolStripMenuItem
            // 
            this.companyUpdateToolStripMenuItem.Name = "companyUpdateToolStripMenuItem";
            this.companyUpdateToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.companyUpdateToolStripMenuItem.Text = "Company Update";
            this.companyUpdateToolStripMenuItem.Click += new System.EventHandler(this.companyUpdateToolStripMenuItem_Click);
            // 
            // companyDeleteToolStripMenuItem
            // 
            this.companyDeleteToolStripMenuItem.Name = "companyDeleteToolStripMenuItem";
            this.companyDeleteToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.companyDeleteToolStripMenuItem.Text = "Company Delete";
            this.companyDeleteToolStripMenuItem.Click += new System.EventHandler(this.companyDeleteToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aLLUSERSHOWToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // companyEmployeeAddToolStripMenuItem
            // 
            this.companyEmployeeAddToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeAddToolStripMenuItem,
            this.employeeDeleteToolStripMenuItem});
            this.companyEmployeeAddToolStripMenuItem.Name = "companyEmployeeAddToolStripMenuItem";
            this.companyEmployeeAddToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.companyEmployeeAddToolStripMenuItem.Text = "Employee Operation";
            this.companyEmployeeAddToolStripMenuItem.Click += new System.EventHandler(this.companyEmployeeAddToolStripMenuItem_Click);
            // 
            // employeeAddToolStripMenuItem
            // 
            this.employeeAddToolStripMenuItem.Name = "employeeAddToolStripMenuItem";
            this.employeeAddToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.employeeAddToolStripMenuItem.Text = "Employee Add";
            this.employeeAddToolStripMenuItem.Click += new System.EventHandler(this.employeeAddToolStripMenuItem_Click);
            // 
            // employeeDeleteToolStripMenuItem
            // 
            this.employeeDeleteToolStripMenuItem.Name = "employeeDeleteToolStripMenuItem";
            this.employeeDeleteToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.employeeDeleteToolStripMenuItem.Text = "Employee Delete";
            this.employeeDeleteToolStripMenuItem.Click += new System.EventHandler(this.employeeDeleteToolStripMenuItem_Click);
            // 
            // mainMenu
            // 
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.companyToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.companyEmployeeAddToolStripMenuItem,
            this.eXITToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(634, 28);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "menuStrip1";
            // 
            // aLLUSERSHOWToolStripMenuItem
            // 
            this.aLLUSERSHOWToolStripMenuItem.Name = "aLLUSERSHOWToolStripMenuItem";
            this.aLLUSERSHOWToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aLLUSERSHOWToolStripMenuItem.Text = "ALL USER SHOW";
            this.aLLUSERSHOWToolStripMenuItem.Click += new System.EventHandler(this.aLLUSERSHOWToolStripMenuItem_Click);
            // 
            // eXITToolStripMenuItem
            // 
            this.eXITToolStripMenuItem.Name = "eXITToolStripMenuItem";
            this.eXITToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.eXITToolStripMenuItem.Text = "EXIT";
            this.eXITToolStripMenuItem.Click += new System.EventHandler(this.eXITToolStripMenuItem_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 544);
            this.Controls.Add(this.mainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "AdminForm";
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem companyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyUpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem companyEmployeeAddToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem employeeAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aLLUSERSHOWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXITToolStripMenuItem;
    }
}