using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjeSon.Data;
using ProjeSon.Logic;
using System.Windows.Forms;

namespace ProjeSon
{
    public partial class CompEmpTime : Form
    {
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
        public CompEmpTime()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            eklerandevu(0, Login_Form.companyid, CompEmpDate.DateTime2, Convert.ToInt32(cmbCompEmpTime.Text));
            MessageBox.Show("Successful");
            this.Close();


        }

        private void CompEmpTime_Load(object sender, EventArgs e)
        {
            int[] sayilar = new int[25];
            sayilar = listing.control(Login_Form.companyid, CompEmpDate.DateTime2);

            if (sayilar.Contains(8))
            {
                cmbCompEmpTime.Items.Remove("8");
            }
            if (sayilar.Contains(9))
            {
                cmbCompEmpTime.Items.Remove("9");
            }
            if (sayilar.Contains(10))
            {
                cmbCompEmpTime.Items.Remove("10");
            }
            if (sayilar.Contains(11))
            {
                cmbCompEmpTime.Items.Remove("11");
            }
            if (sayilar.Contains(13))
            {
                cmbCompEmpTime.Items.Remove("13");
            }
            if (sayilar.Contains(14))
            {
                cmbCompEmpTime.Items.Remove("14");
            }
            if (sayilar.Contains(15))
            {
                cmbCompEmpTime.Items.Remove("15");
            }
            if (sayilar.Contains(16))
            {
                cmbCompEmpTime.Items.Remove("16");
            }
            if (sayilar.Contains(17))
            {
                cmbCompEmpTime.Items.Remove("17");
            }

        }
    }
}
