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
    public partial class CompEmpForm1 : Form
    {
        public CompEmpForm1()
        {
            InitializeComponent();
        }

        private void soruİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void müsaitlikDurumuBelirlemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CompEmpDate compEmpDate = new CompEmpDate();
            compEmpDate.MdiParent = this;
            compEmpDate.Show();
        }

        private void müsaıtOlmayanYerleriGörToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showavailability musaitlikgor = new showavailability();
            musaitlikgor.MdiParent = this;
            musaitlikgor.Show();
        }

        private void randevularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllApp allApp = new AllApp();
            allApp.MdiParent = this;
            allApp.Show();
        }

        private void sorulariGorVeCevaplaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowQuestion showQuestion = new ShowQuestion();
            showQuestion.MdiParent = this;
            showQuestion.Show();
        }

        private void cIKISToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CompEmpForm1_Load(object sender, EventArgs e)
        {

        }
    }
}
