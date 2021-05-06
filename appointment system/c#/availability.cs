using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using ProjeSon.Data;
using ProjeSon.Logic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeSon
{
    public partial class availability : Form
    {
        public availability()
        {
            InitializeComponent();
        }
        public static int CompanyID;
        private readonly Listing listing = new Listing();
        private void listele()
        {
            dgwAppComp.DataSource = listing.Listing1();
            dgwAppComp.Refresh();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void musaitlik_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CompanyID = Convert.ToInt32(txtCompEmpAppAv.Text);
            CompEmpDate compEmpDate = new CompEmpDate();
            this.Hide();
            compEmpDate.ShowDialog();
        }
    }
}
