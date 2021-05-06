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
    public partial class Ask : Form
    {
        public Ask()
        {
            InitializeComponent();
        }
        private readonly Listing listing = new Listing();
        private readonly DbAsk dbAsk = new DbAsk();
        private void AskQ(int companyid,int questionerid,string question ,byte status)
        {
            AskAnswer AskAnswer = new AskAnswer
            {

                CompanyID = companyid,
                QuestionerID = questionerid,
                Question=question,
                Status=status
                
            };
            dbAsk.Ask(AskAnswer);

        }
        
        private void btnAsk_Click(object sender, EventArgs e)
        {
            if (txtAsk.Text == "" || txtAskCompID.Text == "")
            {

                MessageBox.Show("Do not leave empty space ");

            }
            else
            {
                AskQ(Convert.ToInt32(txtAskCompID.Text), Login_Form.userid, txtAsk.Text, 0);
                MessageBox.Show("Successful");
                this.Close();
            }

        }

        private void Ask_Load(object sender, EventArgs e)
        {
            dgwAskComp.DataSource = listing.Listing1();
        }
    }
}
