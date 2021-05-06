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
    public partial class AllEmpShow : Form
    {
        public AllEmpShow()
        {
            InitializeComponent();
        }
        private readonly Listing listing = new Listing();
        private readonly Delete compempdelete = new Delete();

        private void listele()
        {
            dgwAllEmpShow.DataSource = listing.Listing2();
            dgwAllEmpShow.Refresh();
        }
        private void empdelete(int id)
        {
            CompEmp compEmp = new CompEmp
            {
                ID=id
              
            };
            compempdelete.delete3(compEmp);

        }
        private void dgwAllEmpShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                empdelete(Convert.ToInt32(dgwAllEmpShow.CurrentRow.Cells["ID"].Value));
                MessageBox.Show("basarili");
                listele();



            }
        }

        private void AllEmpShow_Load(object sender, EventArgs e)
        {
            listele();

        }
    }
}
