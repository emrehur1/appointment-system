using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using ProjeSon.Data;
using ProjeSon.Logic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeSon
{
    public partial class AllApp : Form
    {
        public AllApp()
        {
            InitializeComponent();
        }
        private readonly Listing listing = new Listing();
        private readonly Delete deleteapp = new Delete();
        private void appdelete(int id)
        {
            tblAppointments App = new tblAppointments
            {

                ID = id
            };
            deleteapp.delete2(App);

        }
        private void showapp(int companyid)
        {

            string sorgu = "SELECT*FROM Appointments WHERE UserID NOT IN(0) AND CompanyID='"+companyid+"' ";
             dgwAllApp.DataSource= listing.appointments(sorgu);


        }
        private void AllApp_Load(object sender, EventArgs e)
        {
            showapp(Login_Form.companyid);
        }

        private void dgwAllApp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                appdelete(Convert.ToInt32(dgwAllApp.CurrentRow.Cells["ID"].Value));
                MessageBox.Show("Successful");
                showapp(Login_Form.companyid);



            }
        }

        private void dgwAllApp_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgwAllApp.Columns["ID"].Visible = false;
        }
    }
}
