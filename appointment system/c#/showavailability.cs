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
    public partial class showavailability : Form
    {
        public showavailability()
        {
            InitializeComponent();
        }
        private readonly Listing listing = new Listing();
        private readonly Delete deleteapp2 = new Delete();
        private void appdelete2(int id)
        {
            tblAppointments App = new tblAppointments
            {

                ID = id
            };
            deleteapp2.delete2(App);

        }
        private void app(int companyid)
        {
            

            
            dgwMusaitlikGor.DataSource= listing.AppAvailability(companyid,0);

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                appdelete2(Convert.ToInt32(dgwMusaitlikGor.CurrentRow.Cells["ID"].Value));
                MessageBox.Show("Successful");
                app(Login_Form.companyid);



            }


        }

        private void musaitlikgor_Load(object sender, EventArgs e)
        {
            app(Login_Form.companyid);

        }

        private void dgwMusaitlikGor_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgwMusaitlikGor.Columns["ID"].Visible = false;
            this.dgwMusaitlikGor.Columns["UserID"].Visible = false; 
        }
    }
}
