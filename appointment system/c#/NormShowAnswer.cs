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
    public partial class NormShowAnswer : Form
    {
        public NormShowAnswer()
        {
            InitializeComponent();
        }
        private readonly DbAsk dbAsk = new DbAsk();
        public static string message;
        public static int messageid;
        private void showr(int userid,int status)
        {
            dgwNormShowAnswer.DataSource = dbAsk.ShowR(userid,status);


        }
        private void NormShowAnswer_Load(object sender, EventArgs e)
        {
            showr(Login_Form.userid, 1);

        }

        private void dgwNormShowAnswer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {

               message = Convert.ToString(dgwNormShowAnswer.CurrentRow.Cells["Reply"].Value);
                // messageid = Convert.ToInt32(dgwNormShowAnswer.CurrentRow.Cells["ID"].Value);


                NormShowReply normShowReply = new NormShowReply();
                normShowReply.ShowDialog();
                this.Close();




            }
        }

        private void dgwNormShowAnswer_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgwNormShowAnswer.Columns["ID"].Visible = false;
            this.dgwNormShowAnswer.Columns["ReplyID"].Visible = false;
            this.dgwNormShowAnswer.Columns["QuestionerID"].Visible = false;
            this.dgwNormShowAnswer.Columns["Status"].Visible = false;
        }
    }
}
