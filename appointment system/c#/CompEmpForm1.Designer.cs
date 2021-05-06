namespace ProjeSon
{
    partial class CompEmpForm1
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
            this.randevuİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müsaitlikDurumuBelirlemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müsaıtOlmayanYerleriGörToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soruİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sorulariGorVeCevaplaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cIKISToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randevuİşlemleriToolStripMenuItem,
            this.soruİşlemleriToolStripMenuItem,
            this.cIKISToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // randevuİşlemleriToolStripMenuItem
            // 
            this.randevuİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randevularToolStripMenuItem,
            this.müsaitlikDurumuBelirlemeToolStripMenuItem,
            this.müsaıtOlmayanYerleriGörToolStripMenuItem});
            this.randevuİşlemleriToolStripMenuItem.Name = "randevuİşlemleriToolStripMenuItem";
            this.randevuİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.randevuİşlemleriToolStripMenuItem.Text = "Appointment process";
            // 
            // randevularToolStripMenuItem
            // 
            this.randevularToolStripMenuItem.Name = "randevularToolStripMenuItem";
            this.randevularToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.randevularToolStripMenuItem.Text = "Appointments";
            this.randevularToolStripMenuItem.Click += new System.EventHandler(this.randevularToolStripMenuItem_Click);
            // 
            // müsaitlikDurumuBelirlemeToolStripMenuItem
            // 
            this.müsaitlikDurumuBelirlemeToolStripMenuItem.Name = "müsaitlikDurumuBelirlemeToolStripMenuItem";
            this.müsaitlikDurumuBelirlemeToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.müsaitlikDurumuBelirlemeToolStripMenuItem.Text = "Determining availability";
            this.müsaitlikDurumuBelirlemeToolStripMenuItem.Click += new System.EventHandler(this.müsaitlikDurumuBelirlemeToolStripMenuItem_Click);
            // 
            // müsaıtOlmayanYerleriGörToolStripMenuItem
            // 
            this.müsaıtOlmayanYerleriGörToolStripMenuItem.Name = "müsaıtOlmayanYerleriGörToolStripMenuItem";
            this.müsaıtOlmayanYerleriGörToolStripMenuItem.Size = new System.Drawing.Size(251, 26);
            this.müsaıtOlmayanYerleriGörToolStripMenuItem.Text = "Show unavailable times";
            this.müsaıtOlmayanYerleriGörToolStripMenuItem.Click += new System.EventHandler(this.müsaıtOlmayanYerleriGörToolStripMenuItem_Click);
            // 
            // soruİşlemleriToolStripMenuItem
            // 
            this.soruİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sorulariGorVeCevaplaToolStripMenuItem});
            this.soruİşlemleriToolStripMenuItem.Name = "soruİşlemleriToolStripMenuItem";
            this.soruİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(150, 24);
            this.soruİşlemleriToolStripMenuItem.Text = "Question processes";
            this.soruİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.soruİşlemleriToolStripMenuItem_Click);
            // 
            // sorulariGorVeCevaplaToolStripMenuItem
            // 
            this.sorulariGorVeCevaplaToolStripMenuItem.Name = "sorulariGorVeCevaplaToolStripMenuItem";
            this.sorulariGorVeCevaplaToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.sorulariGorVeCevaplaToolStripMenuItem.Text = "Show and answer questions ";
            this.sorulariGorVeCevaplaToolStripMenuItem.Click += new System.EventHandler(this.sorulariGorVeCevaplaToolStripMenuItem_Click);
            // 
            // cIKISToolStripMenuItem
            // 
            this.cIKISToolStripMenuItem.Name = "cIKISToolStripMenuItem";
            this.cIKISToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.cIKISToolStripMenuItem.Text = "Exit";
            this.cIKISToolStripMenuItem.Click += new System.EventHandler(this.cIKISToolStripMenuItem_Click);
            // 
            // CompEmpForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CompEmpForm1";
            this.Text = "İşyeriyetkilisiform";
            this.Load += new System.EventHandler(this.CompEmpForm1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem randevuİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müsaitlikDurumuBelirlemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soruİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müsaıtOlmayanYerleriGörToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sorulariGorVeCevaplaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cIKISToolStripMenuItem;
    }
}