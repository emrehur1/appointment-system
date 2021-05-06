namespace ProjeSon
{
    partial class NormAppShow
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
            this.dgwNormAppShow = new System.Windows.Forms.DataGridView();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lbl1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwNormAppShow)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwNormAppShow
            // 
            this.dgwNormAppShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwNormAppShow.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Delete});
            this.dgwNormAppShow.Location = new System.Drawing.Point(67, 70);
            this.dgwNormAppShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgwNormAppShow.Name = "dgwNormAppShow";
            this.dgwNormAppShow.RowHeadersWidth = 51;
            this.dgwNormAppShow.RowTemplate.Height = 24;
            this.dgwNormAppShow.Size = new System.Drawing.Size(607, 238);
            this.dgwNormAppShow.TabIndex = 0;
            this.dgwNormAppShow.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwNormAppShow_CellContentClick);
            this.dgwNormAppShow.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgwNormAppShow_DataBindingComplete);
            // 
            // Delete
            // 
            this.Delete.HeaderText = "DELETE";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 75;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl1.Location = new System.Drawing.Point(329, 25);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(129, 17);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "My appointments ";
            // 
            // NormAppShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.dgwNormAppShow);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NormAppShow";
            this.Text = "NormAppShow";
            this.Load += new System.EventHandler(this.NormAppShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwNormAppShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwNormAppShow;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}