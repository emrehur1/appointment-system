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
    public partial class Norm : Form
    {
        public Norm()
        {
            InitializeComponent();
        }

        private void randevuAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NormUsrForm normUsrForm = new NormUsrForm();
            normUsrForm.MdiParent = this;
            normUsrForm.Show();
            
        }

        private void randevularimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NormAppShow normAppShow = new NormAppShow();
            normAppShow.MdiParent = this;
            normAppShow.Show();
        }

        private void soruSorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Ask ask = new Ask();
            ask.MdiParent = this;
            ask.Show();
        }

        private void cevaplarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NormShowAnswer normShowAnswer = new NormShowAnswer();
            normShowAnswer.MdiParent = this;
            normShowAnswer.Show();
        }

        private void cikisYapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
