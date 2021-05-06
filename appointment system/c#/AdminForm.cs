using System;
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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void companyAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompAddForm Add = new CompAddForm();
            Add.MdiParent = this;
            Add.Show();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
        
        private void companyEmployeeAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void companyUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompUpdateForm update = new CompUpdateForm();
            update.MdiParent = this;
            update.Show();
        }

        private void companyDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompDeleteForm delete = new CompDeleteForm();
            delete.MdiParent = this;
            delete.Show();
        }

        private void employeeDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllEmpShow allEmpShow = new AllEmpShow();
            allEmpShow.MdiParent = this;
            allEmpShow.Show();
        }

        private void employeeAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompEmpAddForm Add = new CompEmpAddForm();
            Add.MdiParent = this;
            Add.Show();

        }

        private void aLLUSERSHOWToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllUserShow allUserShow = new AllUserShow();
            allUserShow.MdiParent = this;
            allUserShow.Show();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
