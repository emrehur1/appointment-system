using System;
using ProjeSon.Logic;
using ProjeSon.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeSon
{
    public partial class CompUpdateForm : Form
    {
        public CompUpdateForm()
        {
            InitializeComponent();
        }
        private readonly CompUpdate compUpdate = new CompUpdate();
        private readonly Listing listing = new Listing();
        private void guncelle(int id, string compname, string adress, string phone)
        {
            tblCompany tblCompany = new tblCompany
            {
                ID = id,
                CompanyName = compname,
                Address = adress,
                Phone = phone



            };
            compUpdate.update(tblCompany);


        }
        private void listele()
        {
            dgwCompanies.DataSource = listing.Listing1();
            dgwCompanies.Refresh();
        }
       
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (txtUpdCompID.Text == "" || txtUpdCompName.Text == "" || txtNewAdress.Text == "" || txtNewPhone.Text == "")
            {
                MessageWarning wrn1 = new MessageWarning();
                wrn1.Message = "Do not leave empty space";
                wrn1.DialogPush(wrn1.Message);
            }
            else {

                guncelle(Convert.ToInt32(txtUpdCompID.Text), txtUpdCompName.Text, txtNewAdress.Text, txtNewPhone.Text);
                MessageWarning wrn = new MessageWarning();
                wrn.Message = "Successful";
                wrn.DialogPush(wrn.Message);
                listele();
                txtUpdCompID.Text = "";
                txtUpdCompName.Text = "";
                txtNewAdress.Text = "";
                txtNewPhone.Text = "";

            }

        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            listele();
        }

        private void CompUpdateForm_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void dgwCompanies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblNewPhone_Click(object sender, EventArgs e)
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
