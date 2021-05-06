using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using ProjeSon.Data;
using ProjeSon.Logic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeSon
{
    public partial class AnswerQuestion : Form
    {
        public AnswerQuestion()
        {
            InitializeComponent();
        }
        private readonly DbAsk dbAsk = new DbAsk();

        private void Reply(int id,string reply,int replyid,int status)
        {
            AskAnswer askAnswer = new AskAnswer
            {
                ID=id,
                Reply = reply,
                ReplyID = replyid,
                Status = status

            };
            dbAsk.Answer(askAnswer);


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AnswerQuestion_Load(object sender, EventArgs e)
        {
            txtQuestion.Text = ShowQuestion.ques;
        }

        private void btnReply_Click(object sender, EventArgs e)
        {
            Reply(ShowQuestion.id, txtReply.Text, Login_Form.userid, 1);
            MessageBox.Show("Successful");
            this.Close();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
