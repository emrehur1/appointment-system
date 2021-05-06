using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using ProjeSon.Logic;
using System.Data.SqlClient;
using ProjeSon.Data;

using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeSon
{
    public partial class TimeApp : Form
    {
        public TimeApp()
        {
            InitializeComponent();
        }
        private readonly appadd randevuEkle = new appadd();
        private readonly Listing listing = new Listing();
      

      

        private void eklerandevu(int userid, int companyid, string date, int time)
        {
            tblAppointments appointments = new tblAppointments
            {
                UserID = userid,
                CompanyID = companyid,
                Date = date,
                Time = time

            };
            randevuEkle.AppAdd(appointments);
        }

            private void button1_Click(object sender, EventArgs e)
        {
            eklerandevu(Login_Form.userid, NormUsrForm.companyid, DateApp.DateTime, Convert.ToInt32(comboBox1.Text));
            MessageBox.Show("Successful");
            this.Close();

           

        }

        private void TimeApp_Load(object sender, EventArgs e)
        {
            int[] sayilar = new int[25];
            sayilar = listing.control(NormUsrForm.companyid, DateApp.DateTime);

            if (sayilar.Contains(8))
            {
                comboBox1.Items.Remove("8");
            }
            if (sayilar.Contains(9))
            {
                comboBox1.Items.Remove("9");
            }
            if (sayilar.Contains(10))
            {
                comboBox1.Items.Remove("10");
            }
            if (sayilar.Contains(11))
            {
                comboBox1.Items.Remove("11");
            }
            if (sayilar.Contains(13))
            {
                comboBox1.Items.Remove("13");
            }
            if (sayilar.Contains(14))
            {
                comboBox1.Items.Remove("14");
            }
            if (sayilar.Contains(15))
            {
                comboBox1.Items.Remove("15");
            }
            if (sayilar.Contains(16))
            {
                comboBox1.Items.Remove("16");
            }
            if (sayilar.Contains(17))
            {
                comboBox1.Items.Remove("17");
            }
           
        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
