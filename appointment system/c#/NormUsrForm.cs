using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using ProjeSon.Data;
using ProjeSon.Logic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeSon
{
    public partial class NormUsrForm : Form
    {
        public NormUsrForm()
        {
            InitializeComponent();
        }
        public static int companyid;
        private readonly Listing listing = new Listing();
       

      
        private void listele()
        {
           dataGridView1.DataSource = listing.Listing1();
            dataGridView1.Refresh();
        }

       
        private void arama(string aranacak)
        {
            
             string sorgu = "SELECT *FROM tblCompany WHERE CompanyName lIKE '%" + aranacak+ "%' ";
           dataGridView1.DataSource= listing.Search(sorgu);

        }

        private void arama2(int aranacak)
        {

            string sorgu = "SELECT *FROM tblCompany WHERE CategoryID lIKE '%" + aranacak + "%' ";
            dataGridView1.DataSource = listing.Search(sorgu);

        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void NormUsrForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            arama(textBox1.Text);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            arama2(comboBox1.SelectedIndex);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            companyid = Convert.ToInt32(textBox2.Text);
            DateApp dateApp = new DateApp();
            this.Hide();
            dateApp.ShowDialog();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
