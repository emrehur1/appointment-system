namespace ProjeSon
{
    partial class showavailability
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
            this.dgwMusaitlikGor = new System.Windows.Forms.DataGridView();
            this.DELETE = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusaitlikGor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwMusaitlikGor
            // 
            this.dgwMusaitlikGor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwMusaitlikGor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DELETE});
            this.dgwMusaitlikGor.Location = new System.Drawing.Point(77, 110);
            this.dgwMusaitlikGor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgwMusaitlikGor.Name = "dgwMusaitlikGor";
            this.dgwMusaitlikGor.RowHeadersWidth = 51;
            this.dgwMusaitlikGor.RowTemplate.Height = 24;
            this.dgwMusaitlikGor.Size = new System.Drawing.Size(604, 215);
            this.dgwMusaitlikGor.TabIndex = 0;
            this.dgwMusaitlikGor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgwMusaitlikGor.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgwMusaitlikGor_DataBindingComplete);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(73, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(569, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "You can remove the appointment times that you have determined as not available.";
            // 
            // musaitlikgor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgwMusaitlikGor);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "musaitlikgor";
            this.Text = "musaitlikgor";
            this.Load += new System.EventHandler(this.musaitlikgor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwMusaitlikGor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwMusaitlikGor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewButtonColumn DELETE;
    }
}