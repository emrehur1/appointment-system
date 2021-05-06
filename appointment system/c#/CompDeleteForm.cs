using System;
using ProjeSon.Data;
using ProjeSon.Logic;
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
    public partial class CompDeleteForm : Form
    {
        public CompDeleteForm()
        {
            InitializeComponent();
        }
        private readonly Delete deleteDB = new Delete();
        private readonly Listing listing = new Listing();
        private void deletecompany(int id)
        {
            tblCompany company = new tblCompany
            {
                ID = id

        };
            deleteDB.delete(company);

        }
        private void listele()
        {
            dgwCompanies2.DataSource = listing.Listing1();
            dgwCompanies2.Refresh();
        }
       

        

        private void dgwCompanies2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==0)
            {
                deletecompany(Convert.ToInt32(dgwCompanies2.CurrentRow.Cells["ID"].Value));
                MessageBox.Show("Successful");
                listele();

            }
        }

        private void CompDeleteForm_Load(object sender, EventArgs e)
        {
            listele();
        }
    }
}
