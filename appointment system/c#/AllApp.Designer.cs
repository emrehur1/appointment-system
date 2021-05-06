namespace ProjeSon
{
    partial class AllApp
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
            this.dgwAllApp = new System.Windows.Forms.DataGridView();
            this.DELETE = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAllApp)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwAllApp
            // 
            this.dgwAllApp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAllApp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DELETE});
            this.dgwAllApp.Location = new System.Drawing.Point(82, 68);
            this.dgwAllApp.Name = "dgwAllApp";
            this.dgwAllApp.RowHeadersWidth = 51;
            this.dgwAllApp.RowTemplate.Height = 24;
            this.dgwAllApp.Size = new System.Drawing.Size(579, 246);
            this.dgwAllApp.TabIndex = 0;
            this.dgwAllApp.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwAllApp_CellContentClick);
            this.dgwAllApp.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgwAllApp_DataBindingComplete);
            // 
            // DELETE
            // 
            this.DELETE.HeaderText = "DELETE";
            this.DELETE.MinimumWidth = 6;
            this.DELETE.Name = "DELETE";
            this.DELETE.Text = "DELETE";
            this.DELETE.UseColumnTextForButtonValue = true;
            this.DELETE.Width = 75;
            // 
            // AllApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgwAllApp);
            this.Name = "AllApp";
            this.Text = "AllApp";
            this.Load += new System.EventHandler(this.AllApp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwAllApp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwAllApp;
        private System.Windows.Forms.DataGridViewButtonColumn DELETE;
    }
}