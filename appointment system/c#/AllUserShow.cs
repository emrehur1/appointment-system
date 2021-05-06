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
    public partial class AllUserShow : Form
    {
        public AllUserShow()
        {
            InitializeComponent();
        }
        private readonly Listing listing = new Listing();
        private void AllUserShow_Load(object sender, EventArgs e)
        {
            dgwAllUserShow.DataSource = listing.Listing2();
        }

        private void dgwAllUserShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
