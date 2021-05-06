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
    public partial class NormShowReply : Form
    {
        public NormShowReply()
        {
            InitializeComponent();
        }

        private void NormShowReply_Load(object sender, EventArgs e)
        {
            txtNormReply.Text = NormShowAnswer.message;
        }

        private void txtNormReply_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
