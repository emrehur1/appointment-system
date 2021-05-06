namespace ProjeSon
{
    partial class CompDeleteForm
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
            this.dgwCompanies2 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCompanies2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwCompanies2
            // 
            this.dgwCompanies2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCompanies2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgwCompanies2.Location = new System.Drawing.Point(22, 31);
            this.dgwCompanies2.Name = "dgwCompanies2";
            this.dgwCompanies2.RowHeadersWidth = 51;
            this.dgwCompanies2.RowTemplate.Height = 24;
            this.dgwCompanies2.Size = new System.Drawing.Size(738, 295);
            this.dgwCompanies2.TabIndex = 0;
            this.dgwCompanies2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCompanies2_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "DELETE";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Text = "Delete";
            this.Column1.UseColumnTextForButtonValue = true;
            this.Column1.Width = 75;
            // 
            // CompDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgwCompanies2);
            this.Name = "CompDeleteForm";
            this.Text = "Company Delete";
            this.Load += new System.EventHandler(this.CompDeleteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCompanies2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwCompanies2;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
    }
}