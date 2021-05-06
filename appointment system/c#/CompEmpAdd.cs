using ProjeSon.Data;
using ProjeSon.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjeSon
{
    public partial class CompEmpAddForm : Form
    {
        public CompEmpAddForm()
        {
            InitializeComponent();
        }

        private readonly CompEmpAdd empAdd = new CompEmpAdd();
        private readonly Listing listing = new Listing();

        private void PersonelEkle(string username,string password,int companyid,string email,string name,string surname,string phone,string adress, DateTime birthday,string tcno,int roletypeid)
        {
            
            
            CompEmp emp=new CompEmp
            {
                UserName = username,
                Password = password,
                CompanyID = companyid,
                Email = email,
                Name = name,
                SurName = surname,
                Phone = phone,
                Adress = adress,
                BirthDay = birthday,
                TcNo = tcno,
                RoleTypeID=roletypeid,
              
            };

           empAdd.Register(emp);

        }
        private void listele()
        {
            dgwCompEmp.DataSource = listing.Listing2();
            dgwCompEmp.Refresh();
        }
        
        private void btnEmpRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmpUserName.Text == "" || txtEmpAdress.Text == "" || txtEmpPassword.Text == "" || txtEmpEmail.Text == "" || txtEmpSurName.Text == "" || txtEmpTcNo.Text == "" || txtEmpName.Text == "" || txtEmpBirthDay.Text == "" || txtEmpCompID.Text == "" || txtEmpPhone.Text == "")
                {
                    MessageWarning wrn1 = new MessageWarning();
                    wrn1.Message = "Do not leave empty space ";
                    wrn1.DialogPush(wrn1.Message);

                }
                else
                {
                    PersonelEkle(txtEmpUserName.Text, txtEmpPassword.Text, Convert.ToInt32(txtEmpCompID.Text), txtEmpEmail.Text, txtEmpName.Text, txtEmpSurName.Text, txtEmpPhone.Text, txtEmpAdress.Text, Convert.ToDateTime(txtEmpBirthDay.Text), txtEmpTcNo.Text, 2);
                    MessageBox.Show("Succesfully Added");
                    txtEmpUserName.Text = "";
                    txtEmpAdress.Text = "";
                     txtEmpPassword.Text = "";
                    txtEmpEmail.Text = "";
                    txtEmpSurName.Text = "";
                    txtEmpTcNo.Text = "";
                    txtEmpName.Text = "";
                    txtEmpBirthDay.Text = "";
                        txtEmpCompID.Text = "";
                    txtEmpPhone.Text = "";
                    listele();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("operation failed . : " + ex.Message);
            }
        }

       
       

        private void CompEmpAddForm_Load(object sender, EventArgs e)
        {
            listele();
        }


        public class MessageWarning : DialogCustom
        {

            public override void DialogPush(string Message)
            {
                MessageBox.Show(Message);
            }
        }




    }
}
