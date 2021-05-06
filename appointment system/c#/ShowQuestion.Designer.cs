namespace ProjeSon
{
    partial class ShowQuestion
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
            this.dgwShowQuestion = new System.Windows.Forms.DataGridView();
            this.SHOW = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgwShowQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwShowQuestion
            // 
            this.dgwShowQuestion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwShowQuestion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SHOW});
            this.dgwShowQuestion.Location = new System.Drawing.Point(61, 44);
            this.dgwShowQuestion.Name = "dgwShowQuestion";
            this.dgwShowQuestion.RowHeadersWidth = 51;
            this.dgwShowQuestion.RowTemplate.Height = 24;
            this.dgwShowQuestion.Size = new System.Drawing.Size(678, 333);
            this.dgwShowQuestion.TabIndex = 0;
            this.dgwShowQuestion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwShowQuestion_CellContentClick);
            this.dgwShowQuestion.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgwShowQuestion_DataBindingComplete);
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
            // ShowQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgwShowQuestion);
            this.Name = "ShowQuestion";
            this.Text = "ShowQuestion";
            this.Load += new System.EventHandler(this.ShowQuestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwShowQuestion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwShowQuestion;
        private System.Windows.Forms.DataGridViewButtonColumn SHOW;
    }
}