namespace ProjeSon
{
    partial class availability
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
            this.dgwAppComp = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCompEmpAppAv = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAppComp)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwAppComp
            // 
            this.dgwAppComp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAppComp.Location = new System.Drawing.Point(48, 98);
            this.dgwAppComp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgwAppComp.Name = "dgwAppComp";
            this.dgwAppComp.RowHeadersWidth = 51;
            this.dgwAppComp.RowTemplate.Height = 24;
            this.dgwAppComp.Size = new System.Drawing.Size(628, 203);
            this.dgwAppComp.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(485, 426);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 65);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCompEmpAppAv
            // 
            this.txtCompEmpAppAv.Location = new System.Drawing.Point(84, 447);
            this.txtCompEmpAppAv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCompEmpAppAv.Name = "txtCompEmpAppAv";
            this.txtCompEmpAppAv.Size = new System.Drawing.Size(179, 22);
            this.txtCompEmpAppAv.TabIndex = 3;
            // 
            // musaitlik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 645);
            this.Controls.Add(this.txtCompEmpAppAv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgwAppComp);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "musaitlik";
            this.Text = "musaitlik";
            this.Load += new System.EventHandler(this.musaitlik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwAppComp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgwAppComp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCompEmpAppAv;
    }
}