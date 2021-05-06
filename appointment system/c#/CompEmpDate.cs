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
    public partial class CompEmpDate : Form
    {
        public CompEmpDate()
        {
            InitializeComponent();
        }
        public static string DateTime2;


        private void btndatecontinue_Click(object sender, EventArgs e)
        {
            var datestring2 = dtpEmpDate.Value.ToString("dd/MM/yyyy");
            DateTime2 = datestring2;
            CompEmpTime compEmpTime = new CompEmpTime();
            this.Hide();
            compEmpTime.ShowDialog();


        }
    }
}
