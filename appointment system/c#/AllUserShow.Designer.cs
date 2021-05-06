namespace ProjeSon
{
    partial class AllUserShow
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
            this.dgwAllUserShow = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAllUserShow)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwAllUserShow
            // 
            this.dgwAllUserShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAllUserShow.Location = new System.Drawing.Point(88, 61);
            this.dgwAllUserShow.Name = "dgwAllUserShow";
            this.dgwAllUserShow.RowHeadersWidth = 51;
            this.dgwAllUserShow.RowTemplate.Height = 24;
            this.dgwAllUserShow.Size = new System.Drawing.Size(611, 267);
            this.dgwAllUserShow.TabIndex = 0;
            this.dgwAllUserShow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwAllUserShow_CellContentClick);
            // 
            // AllUserShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgwAllUserShow);
            this.Name = "AllUserShow";
            this.Text = "AllUserShow";
            this.Load += new System.EventHandler(this.AllUserShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwAllUserShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwAllUserShow;
    }
}