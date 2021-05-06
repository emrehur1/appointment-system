namespace ProjeSon
{
    partial class AllEmpShow
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
            this.dgwAllEmpShow = new System.Windows.Forms.DataGridView();
            this.DELETE = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAllEmpShow)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwAllEmpShow
            // 
            this.dgwAllEmpShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAllEmpShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DELETE});
            this.dgwAllEmpShow.Location = new System.Drawing.Point(49, 59);
            this.dgwAllEmpShow.Name = "dgwAllEmpShow";
            this.dgwAllEmpShow.RowHeadersWidth = 51;
            this.dgwAllEmpShow.RowTemplate.Height = 24;
            this.dgwAllEmpShow.Size = new System.Drawing.Size(643, 295);
            this.dgwAllEmpShow.TabIndex = 0;
            this.dgwAllEmpShow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwAllEmpShow_CellContentClick);
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
            // AllEmpShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgwAllEmpShow);
            this.Name = "AllEmpShow";
            this.Text = "AllEmpShow";
            this.Load += new System.EventHandler(this.AllEmpShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwAllEmpShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwAllEmpShow;
        private System.Windows.Forms.DataGridViewButtonColumn DELETE;
    }
}