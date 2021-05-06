namespace ProjeSon
{
    partial class Norm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.randevuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevuAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randevularimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soruSorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soruSorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cevaplarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randevuToolStripMenuItem,
            this.soruSorToolStripMenuItem,
            this.cikisYapToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // randevuToolStripMenuItem
            // 
            this.randevuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.randevuAlToolStripMenuItem,
            this.randevularimToolStripMenuItem});
            this.randevuToolStripMenuItem.Name = "randevuToolStripMenuItem";
            this.randevuToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.randevuToolStripMenuItem.Text = "Appointment";
            // 
            // randevuAlToolStripMenuItem
            // 
            this.randevuAlToolStripMenuItem.Name = "randevuAlToolStripMenuItem";
            this.randevuAlToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.randevuAlToolStripMenuItem.Text = "Make an appointment";
            this.randevuAlToolStripMenuItem.Click += new System.EventHandler(this.randevuAlToolStripMenuItem_Click);
            // 
            // randevularimToolStripMenuItem
            // 
            this.randevularimToolStripMenuItem.Name = "randevularimToolStripMenuItem";
            this.randevularimToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.randevularimToolStripMenuItem.Text = "My appointments";
            this.randevularimToolStripMenuItem.Click += new System.EventHandler(this.randevularimToolStripMenuItem_Click);
            // 
            // soruSorToolStripMenuItem
            // 
            this.soruSorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.soruSorToolStripMenuItem1,
            this.cevaplarToolStripMenuItem});
            this.soruSorToolStripMenuItem.Name = "soruSorToolStripMenuItem";
            this.soruSorToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.soruSorToolStripMenuItem.Text = "Question";
            // 
            // soruSorToolStripMenuItem1
            // 
            this.soruSorToolStripMenuItem1.Name = "soruSorToolStripMenuItem1";
            this.soruSorToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.soruSorToolStripMenuItem1.Text = "Ask question";
            this.soruSorToolStripMenuItem1.Click += new System.EventHandler(this.soruSorToolStripMenuItem1_Click);
            // 
            // cevaplarToolStripMenuItem
            // 
            this.cevaplarToolStripMenuItem.Name = "cevaplarToolStripMenuItem";
            this.cevaplarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cevaplarToolStripMenuItem.Text = "Answers";
            this.cevaplarToolStripMenuItem.Click += new System.EventHandler(this.cevaplarToolStripMenuItem_Click);
            // 
            // cikisYapToolStripMenuItem
            // 
            this.cikisYapToolStripMenuItem.Name = "cikisYapToolStripMenuItem";
            this.cikisYapToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.cikisYapToolStripMenuItem.Text = "Exit";
            this.cikisYapToolStripMenuItem.Click += new System.EventHandler(this.cikisYapToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Norm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Norm";
            this.Text = "Norm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem randevuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevuAlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randevularimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soruSorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soruSorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cevaplarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cikisYapToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}