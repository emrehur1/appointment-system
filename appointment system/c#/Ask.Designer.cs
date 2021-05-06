namespace ProjeSon
{
    partial class Ask
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
            this.dgwAskComp = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtAsk = new System.Windows.Forms.TextBox();
            this.txtAskCompID = new System.Windows.Forms.TextBox();
            this.btnAsk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAskComp)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwAskComp
            // 
            this.dgwAskComp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAskComp.Location = new System.Drawing.Point(26, 39);
            this.dgwAskComp.Name = "dgwAskComp";
            this.dgwAskComp.RowHeadersWidth = 51;
            this.dgwAskComp.RowTemplate.Height = 24;
            this.dgwAskComp.Size = new System.Drawing.Size(535, 179);
            this.dgwAskComp.TabIndex = 0;
            // 
            // txtAsk
            // 
            this.txtAsk.Location = new System.Drawing.Point(50, 384);
            this.txtAsk.Multiline = true;
            this.txtAsk.Name = "txtAsk";
            this.txtAsk.Size = new System.Drawing.Size(427, 156);
            this.txtAsk.TabIndex = 1;
            // 
            // txtAskCompID
            // 
            this.txtAskCompID.Location = new System.Drawing.Point(50, 304);
            this.txtAskCompID.Name = "txtAskCompID";
            this.txtAskCompID.Size = new System.Drawing.Size(157, 22);
            this.txtAskCompID.TabIndex = 2;
            // 
            // btnAsk
            // 
            this.btnAsk.Location = new System.Drawing.Point(588, 491);
            this.btnAsk.Name = "btnAsk";
            this.btnAsk.Size = new System.Drawing.Size(126, 49);
            this.btnAsk.TabIndex = 3;
            this.btnAsk.Text = "ASK";
            this.btnAsk.UseVisualStyleBackColor = true;
            this.btnAsk.Click += new System.EventHandler(this.btnAsk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(408, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter the ID number of the company you want to ask a question";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(497, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Write your question here";
            // 
            // Ask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 606);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAsk);
            this.Controls.Add(this.txtAskCompID);
            this.Controls.Add(this.txtAsk);
            this.Controls.Add(this.dgwAskComp);
            this.Name = "Ask";
            this.Text = "Ask";
            this.Load += new System.EventHandler(this.Ask_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwAskComp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwAskComp;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtAsk;
        private System.Windows.Forms.TextBox txtAskCompID;
        private System.Windows.Forms.Button btnAsk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}