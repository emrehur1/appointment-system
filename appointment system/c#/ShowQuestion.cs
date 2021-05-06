using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using ProjeSon.Data;
using ProjeSon.Logic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeSon
{
    public partial class ShowQuestion : Form
    {
        public ShowQuestion()
        {
            InitializeComponent();
        }
        private readonly DbAsk dbAsk = new DbAsk();
        

        public static string ques;
        public static int id;
        private void ShowQuestion_Load(object sender, EventArgs e)
        {

            dgwShowQuestion.DataSource = dbAsk.Showq(Login_Form.companyid,0);


        }

        private void dgwShowQuestion_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            this.dgwShowQuestion.Columns["ID"].Visible = false;
            this.dgwShowQuestion.Columns["CompanyID"].Visible = false;
            this.dgwShowQuestion.Columns["ReplyID"].Visible = false;
            this.dgwShowQuestion.Columns["Reply"].Visible = false;
            this.dgwShowQuestion.Columns["Status"].Visible = false;
        }

        private void dgwShowQuestion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
          
                 ques= Convert.ToString( dgwShowQuestion.CurrentRow.Cells["Question"].Value);
                id = Convert.ToInt32(dgwShowQuestion.CurrentRow.Cells["ID"].Value);

                AnswerQuestion answerQuestion = new AnswerQuestion();
                
                
                answerQuestion.ShowDialog();
                this.Close();

                

            }
        }
    }
}
