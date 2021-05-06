namespace ProjeSon
{
    partial class NormShowAnswer
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
            this.dgwNormShowAnswer = new System.Windows.Forms.DataGridView();
            this.SHOW = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwNormShowAnswer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwNormShowAnswer
            // 
            this.dgwNormShowAnswer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwNormShowAnswer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SHOW});
            this.dgwNormShowAnswer.Location = new System.Drawing.Point(49, 58);
            this.dgwNormShowAnswer.Name = "dgwNormShowAnswer";
            this.dgwNormShowAnswer.RowHeadersWidth = 51;
            this.dgwNormShowAnswer.RowTemplate.Height = 24;
            this.dgwNormShowAnswer.Size = new System.Drawing.Size(686, 316);
            this.dgwNormShowAnswer.TabIndex = 0;
            this.dgwNormShowAnswer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwNormShowAnswer_CellContentClick);
            this.dgwNormShowAnswer.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgwNormShowAnswer_DataBindingComplete);
            // 
            // SHOW
            // 
            this.SHOW.HeaderText = "SHOW";
            this.SHOW.MinimumWidth = 6;
            this.SHOW.Name = "SHOW";
            this.SHOW.Text = "SHOW";
            this.SHOW.UseColumnTextForButtonValue = true;
            this.SHOW.Width = 75;
            // 
            // NormShowAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgwNormShowAnswer);
            this.Name = "NormShowAnswer";
            this.Text = "NormShowAnswer";
            this.Load += new System.EventHandler(this.NormShowAnswer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwNormShowAnswer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwNormShowAnswer;
        private System.Windows.Forms.DataGridViewButtonColumn SHOW;
    }
}