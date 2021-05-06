using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using ProjeSon.Data;
using ProjeSon.Logic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeSon
{
    public partial class NormAppShow : Form
    {
        public NormAppShow()
        {
            InitializeComponent();
        }
        private readonly Listing listing = new Listing();
        private readonly Delete deleteapp = new Delete();
        private void show(int userid)
        {

            string sorgu = "SELECT *FROM Appointments WHERE UserID='"+userid+ "' ";
            dgwNormAppShow.DataSource = listing.appointments(sorgu);

        }
        private void appdelete(int id)
        {
            tblAppointments App = new tblAppointments
            {
                
                ID=id
            };
            deleteapp.delete2(App);

        }

        private void NormAppShow_Load(object sender, EventArgs e)
        {
            show(Login_Form.userid);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            show(Login_Form.userid);
        }

        private void dgwNormAppShow_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgwNormAppShow.Columns["ID"].Visible = false;
        }

        private void dgwNormAppShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                appdelete(Convert.ToInt32(dgwNormAppShow.CurrentRow.Cells["ID"].Value));
                MessageBox.Show("Successful");
                show(Login_Form.userid);



            }
        }
    }
}
