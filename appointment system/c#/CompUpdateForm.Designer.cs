namespace ProjeSon
{
    partial class CompUpdateForm
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
            this.dgwCompanies = new System.Windows.Forms.DataGridView();
            this.lblNewAdress = new System.Windows.Forms.Label();
            this.txtNewAdress = new System.Windows.Forms.TextBox();
            this.txtNewPhone = new System.Windows.Forms.TextBox();
            this.lblNewPhone = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtUpdCompName = new System.Windows.Forms.TextBox();
            this.lblUpdCompName = new System.Windows.Forms.Label();
            this.txtUpdCompID = new System.Windows.Forms.TextBox();
            this.lblCompanyID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCompanies)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwCompanies
            // 
            this.dgwCompanies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCompanies.Location = new System.Drawing.Point(13, 14);
            this.dgwCompanies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgwCompanies.Name = "dgwCompanies";
            this.dgwCompanies.RowHeadersWidth = 51;
            this.dgwCompanies.RowTemplate.Height = 24;
            this.dgwCompanies.Size = new System.Drawing.Size(775, 164);
            this.dgwCompanies.TabIndex = 0;
            this.dgwCompanies.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCompanies_CellContentClick);
            // 
            // lblNewAdress
            // 
            this.lblNewAdress.AutoSize = true;
            this.lblNewAdress.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNewAdress.Location = new System.Drawing.Point(79, 350);
            this.lblNewAdress.Name = "lblNewAdress";
            this.lblNewAdress.Size = new System.Drawing.Size(86, 17);
            this.lblNewAdress.TabIndex = 1;
            this.lblNewAdress.Text = "New Adress";
            // 
            // txtNewAdress
            // 
            this.txtNewAdress.Location = new System.Drawing.Point(179, 343);
            this.txtNewAdress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNewAdress.Name = "txtNewAdress";
            this.txtNewAdress.Size = new System.Drawing.Size(185, 22);
            this.txtNewAdress.TabIndex = 2;
            // 
            // txtNewPhone
            // 
            this.txtNewPhone.Location = new System.Drawing.Point(179, 399);
            this.txtNewPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNewPhone.Name = "txtNewPhone";
            this.txtNewPhone.Size = new System.Drawing.Size(185, 22);
            this.txtNewPhone.TabIndex = 4;
            // 
            // lblNewPhone
            // 
            this.lblNewPhone.AutoSize = true;
            this.lblNewPhone.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNewPhone.Location = new System.Drawing.Point(79, 405);
            this.lblNewPhone.Name = "lblNewPhone";
            this.lblNewPhone.Size = new System.Drawing.Size(84, 17);
            this.lblNewPhone.TabIndex = 3;
            this.lblNewPhone.Text = "New Phone";
            this.lblNewPhone.Click += new System.EventHandler(this.lblNewPhone_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Maroon;
            this.btnUpdate.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Yellow;
            this.btnUpdate.Location = new System.Drawing.Point(481, 319);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(184, 79);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtUpdCompName
            // 
            this.txtUpdCompName.Location = new System.Drawing.Point(179, 290);
            this.txtUpdCompName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUpdCompName.Name = "txtUpdCompName";
            this.txtUpdCompName.Size = new System.Drawing.Size(185, 22);
            this.txtUpdCompName.TabIndex = 7;
            // 
            // lblUpdCompName
            // 
            this.lblUpdCompName.AutoSize = true;
            this.lblUpdCompName.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUpdCompName.Location = new System.Drawing.Point(15, 297);
            this.lblUpdCompName.Name = "lblUpdCompName";
            this.lblUpdCompName.Size = new System.Drawing.Size(155, 17);
            this.lblUpdCompName.TabIndex = 6;
            this.lblUpdCompName.Text = "New Company Name";
            // 
            // txtUpdCompID
            // 
            this.txtUpdCompID.Location = new System.Drawing.Point(179, 238);
            this.txtUpdCompID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUpdCompID.Name = "txtUpdCompID";
            this.txtUpdCompID.Size = new System.Drawing.Size(185, 22);
            this.txtUpdCompID.TabIndex = 8;
            // 
            // lblCompanyID
            // 
            this.lblCompanyID.AutoSize = true;
            this.lblCompanyID.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCompanyID.Location = new System.Drawing.Point(79, 244);
            this.lblCompanyID.Name = "lblCompanyID";
            this.lblCompanyID.Size = new System.Drawing.Size(93, 17);
            this.lblCompanyID.TabIndex = 9;
            this.lblCompanyID.Text = "Company ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(403, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Enter the ID number of the company you wish to update";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(19, 319);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(347, 18);
            this.panel2.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(19, 266);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 18);
            this.panel1.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(19, 372);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(347, 18);
            this.panel3.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel4.Location = new System.Drawing.Point(19, 427);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(347, 18);
            this.panel4.TabIndex = 15;
            // 
            // CompUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 470);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCompanyID);
            this.Controls.Add(this.txtUpdCompID);
            this.Controls.Add(this.txtUpdCompName);
            this.Controls.Add(this.lblUpdCompName);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtNewPhone);
            this.Controls.Add(this.lblNewPhone);
            this.Controls.Add(this.txtNewAdress);
            this.Controls.Add(this.lblNewAdress);
            this.Controls.Add(this.dgwCompanies);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CompUpdateForm";
            this.Text = "Company Update";
            this.Load += new System.EventHandler(this.CompUpdateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCompanies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwCompanies;
        private System.Windows.Forms.Label lblNewAdress;
        private System.Windows.Forms.TextBox txtNewAdress;
        private System.Windows.Forms.TextBox txtNewPhone;
        private System.Windows.Forms.Label lblNewPhone;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtUpdCompName;
        private System.Windows.Forms.Label lblUpdCompName;
        private System.Windows.Forms.TextBox txtUpdCompID;
        private System.Windows.Forms.Label lblCompanyID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}