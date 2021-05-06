namespace ProjeSon
{
    partial class CompAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompAddForm));
            this.lblCompName = new System.Windows.Forms.Label();
            this.txtCompName = new System.Windows.Forms.TextBox();
            this.lblCompCategory = new System.Windows.Forms.Label();
            this.txtCompAdress = new System.Windows.Forms.TextBox();
            this.lblCompAdress = new System.Windows.Forms.Label();
            this.txtCompPhone = new System.Windows.Forms.TextBox();
            this.lblCompPhone = new System.Windows.Forms.Label();
            this.cbCompCategory = new System.Windows.Forms.ComboBox();
            this.btnCompAdd = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCompName
            // 
            this.lblCompName.AutoSize = true;
            this.lblCompName.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCompName.Location = new System.Drawing.Point(377, 37);
            this.lblCompName.Name = "lblCompName";
            this.lblCompName.Size = new System.Drawing.Size(121, 17);
            this.lblCompName.TabIndex = 0;
            this.lblCompName.Text = "Company Name";
            // 
            // txtCompName
            // 
            this.txtCompName.Location = new System.Drawing.Point(515, 31);
            this.txtCompName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCompName.Name = "txtCompName";
            this.txtCompName.Size = new System.Drawing.Size(195, 22);
            this.txtCompName.TabIndex = 1;
            // 
            // lblCompCategory
            // 
            this.lblCompCategory.AutoSize = true;
            this.lblCompCategory.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCompCategory.Location = new System.Drawing.Point(427, 86);
            this.lblCompCategory.Name = "lblCompCategory";
            this.lblCompCategory.Size = new System.Drawing.Size(70, 17);
            this.lblCompCategory.TabIndex = 2;
            this.lblCompCategory.Text = "Category";
            this.lblCompCategory.Click += new System.EventHandler(this.lblCompCategory_Click);
            // 
            // txtCompAdress
            // 
            this.txtCompAdress.Location = new System.Drawing.Point(515, 129);
            this.txtCompAdress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCompAdress.Name = "txtCompAdress";
            this.txtCompAdress.Size = new System.Drawing.Size(195, 22);
            this.txtCompAdress.TabIndex = 5;
            // 
            // lblCompAdress
            // 
            this.lblCompAdress.AutoSize = true;
            this.lblCompAdress.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCompAdress.Location = new System.Drawing.Point(372, 135);
            this.lblCompAdress.Name = "lblCompAdress";
            this.lblCompAdress.Size = new System.Drawing.Size(123, 17);
            this.lblCompAdress.TabIndex = 4;
            this.lblCompAdress.Text = "Company Adress";
            // 
            // txtCompPhone
            // 
            this.txtCompPhone.Location = new System.Drawing.Point(515, 180);
            this.txtCompPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCompPhone.Name = "txtCompPhone";
            this.txtCompPhone.Size = new System.Drawing.Size(195, 22);
            this.txtCompPhone.TabIndex = 7;
            // 
            // lblCompPhone
            // 
            this.lblCompPhone.AutoSize = true;
            this.lblCompPhone.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCompPhone.Location = new System.Drawing.Point(373, 186);
            this.lblCompPhone.Name = "lblCompPhone";
            this.lblCompPhone.Size = new System.Drawing.Size(121, 17);
            this.lblCompPhone.TabIndex = 6;
            this.lblCompPhone.Text = "Company Phone";
            // 
            // cbCompCategory
            // 
            this.cbCompCategory.FormattingEnabled = true;
            this.cbCompCategory.Items.AddRange(new object[] {
            "psychologist",
            "dentist",
            "doctor",
            "engineer",
            "architect"});
            this.cbCompCategory.Location = new System.Drawing.Point(515, 79);
            this.cbCompCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCompCategory.Name = "cbCompCategory";
            this.cbCompCategory.Size = new System.Drawing.Size(195, 24);
            this.cbCompCategory.TabIndex = 8;
            // 
            // btnCompAdd
            // 
            this.btnCompAdd.BackColor = System.Drawing.Color.Maroon;
            this.btnCompAdd.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCompAdd.ForeColor = System.Drawing.Color.Yellow;
            this.btnCompAdd.Location = new System.Drawing.Point(539, 235);
            this.btnCompAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCompAdd.Name = "btnCompAdd";
            this.btnCompAdd.Size = new System.Drawing.Size(147, 71);
            this.btnCompAdd.TabIndex = 9;
            this.btnCompAdd.Text = "Add";
            this.btnCompAdd.UseVisualStyleBackColor = false;
            this.btnCompAdd.Click += new System.EventHandler(this.btnCompAdd_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 263);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(381, 59);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 14);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(381, 108);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(329, 14);
            this.panel2.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(381, 160);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(329, 14);
            this.panel3.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel4.Location = new System.Drawing.Point(381, 208);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(329, 14);
            this.panel4.TabIndex = 14;
            // 
            // CompAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCompAdd);
            this.Controls.Add(this.cbCompCategory);
            this.Controls.Add(this.txtCompPhone);
            this.Controls.Add(this.lblCompPhone);
            this.Controls.Add(this.txtCompAdress);
            this.Controls.Add(this.lblCompAdress);
            this.Controls.Add(this.lblCompCategory);
            this.Controls.Add(this.txtCompName);
            this.Controls.Add(this.lblCompName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CompAddForm";
            this.Text = " ";
            this.Load += new System.EventHandler(this.CompAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCompName;
        private System.Windows.Forms.TextBox txtCompName;
        private System.Windows.Forms.Label lblCompCategory;
        private System.Windows.Forms.TextBox txtCompAdress;
        private System.Windows.Forms.Label lblCompAdress;
        private System.Windows.Forms.TextBox txtCompPhone;
        private System.Windows.Forms.Label lblCompPhone;
        private System.Windows.Forms.ComboBox cbCompCategory;
        private System.Windows.Forms.Button btnCompAdd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}