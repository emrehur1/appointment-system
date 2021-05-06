using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using ProjeSon.Logic;
using ProjeSon.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeSon
{
    public partial class CompAddForm : Form
    {
        public CompAddForm()
        {
            InitializeComponent();
        }

        private readonly companyadd companyDB = new companyadd();
        private void addcmp(string companyname , int categoryid , string adress , string phone)
        {
            tblCompany cmp = new tblCompany
            {

                CompanyName = companyname,
                CategoryID=categoryid,
                Address=adress,
                Phone=phone
            };
            companyDB.addCompany(cmp);
        }
        
        private void btnCompAdd_Click(object sender, EventArgs e)
        {
            if (txtCompName.Text == "" || txtCompAdress.Text == "" || txtCompPhone.Text == "" || cbCompCategory.SelectedItem == null)
            {
                MessageWarning wrn1 = new MessageWarning();
                wrn1.Message = "Do not leave empty space";
                wrn1.DialogPush(wrn1.Message);


            }
            else
            {
                addcmp(txtCompName.Text, cbCompCategory.SelectedIndex, txtCompAdress.Text, txtCompPhone.Text);
                MessageWarning wrn = new MessageWarning();
                wrn.Message = "Successful";
                wrn.DialogPush(wrn.Message);
                txtCompName.Text = "";
                txtCompAdress.Text = "";
                txtCompPhone.Text = "";
            }
            
        }

        private void lblCompCategory_Click(object sender, EventArgs e)
        {

        }

        private void CompAddForm_Load(object sender, EventArgs e)
        {

        }

        public class MessageWarning : DialogCustom
        {

            public override void DialogPush(string Message)
            {
                MessageBox.Show(Message);
            }
        }



    }
}
