using ProjeSon.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using ProjeSon.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeSon
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }
        public static int userid;
        public static int companyid;
        private void btnLogin2_Click(object sender, EventArgs e)
        {
            string username = txtUserName2.Text;
            string password = txtPassword2.Text;

            tblUserLogic usrLogic = new tblUserLogic();

            var usr = usrLogic.Login(username, password,1);

            if (usr != null)
            {

                

                AdminForm adminForm = new AdminForm(); 
                this.Hide();
                adminForm.ShowDialog(); 

                this.Close();
                int deger = usr.ID;


                
            }
            else
            {
                MessageWarning wrn = new MessageWarning();
                wrn.Message = "Hatalı Giriş Yaptınız";
                wrn.DialogPush(wrn.Message);

            }
        }

        private void btnNormReg_Click(object sender, EventArgs e)
        {
            NormUserReg a = new NormUserReg();
            this.Hide();
            a.ShowDialog();


        }

        private void btnEmpLogin_Click(object sender, EventArgs e)
        {

            string username = txtEmpUsrName.Text;
            string password = txtEmpUsrPsw.Text;

            tblEmpLogic tblEmpLogic = new tblEmpLogic();

            var emp = tblEmpLogic.LoginEmp(username, password,2);

            if (emp != null)
            {
                int id = emp.CompanyID;
                companyid = id;
                userid = emp.ID;

                CompEmpForm1 compEmpForm1 = new CompEmpForm1();
                this.Hide();
                compEmpForm1.ShowDialog();




            }
            else
            {
                MessageWarning wrn = new MessageWarning();
                wrn.Message = "Hatalı Giriş Yaptınız";
                wrn.DialogPush(wrn.Message);

            }





        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNrmLogin_Click(object sender, EventArgs e)
        {

            string username = txtNrmlUsrName.Text;
            string password = txtNrmlPsw.Text;

            tblUserLogic usrLogic = new tblUserLogic();

            var usr = usrLogic.Login(username, password, 3);

            if (usr != null)
            {

                userid = usr.ID;
                Norm norm = new Norm();
                this.Hide();
                norm.ShowDialog();






            }
            else
            {

            }
        }


             public class MessageWarning : DialogCustom
        {

            public override void DialogPush(string Message)
            {
                MessageBox.Show(Message);
            }
        }

        private void Login__Form_Load(object sender, EventArgs e)
        {

        }
    }
    }

