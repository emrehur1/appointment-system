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
    public partial class DateApp : Form
    {
        public DateApp()
        {
            InitializeComponent();
        }
        public static string DateTime;

        private void DateApp_Load(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var datestring = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            DateTime = datestring;
            TimeApp timeApp = new TimeApp();
            this.Hide();
            timeApp.ShowDialog();
        }
    }
}
