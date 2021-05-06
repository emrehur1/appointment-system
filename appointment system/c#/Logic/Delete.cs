using System;
using ProjeSon.Data;
using ProjeSon.Logic;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeSon.Logic
{
    class Delete : DBEntity
    {

        public void delete (tblCompany company)
        {
            SqlConnection con = new SqlConnection(connStr);
            string sorgu = "DELETE FROM tblCompany WHERE ID=@ID";
            SqlCommand cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@ID", company.ID);
            con.Open();
            cmd.ExecuteNonQuery();


        }


        public void delete2(tblAppointments appointments)
        {
            SqlConnection con = new SqlConnection(connStr);
            string sorgu = "DELETE FROM Appointments WHERE ID=@ID";
            SqlCommand cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@ID",appointments.ID);
            con.Open();
            cmd.ExecuteNonQuery();


        }

        public void delete3(CompEmp compEmp)
        {
            SqlConnection con = new SqlConnection(connStr);
            string sorgu = "DELETE FROM tblUser WHERE ID=@ID";
            SqlCommand cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@ID", compEmp.ID);
            con.Open();
            cmd.ExecuteNonQuery();


        }



    }




}
