using System;
using ProjeSon.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeSon.Logic
{
    class CompUpdate : DBEntity
    {

        public void update( tblCompany isyeri)
        {
            SqlConnection con = new SqlConnection(connStr);
            string sorgu = "UPDATE tblCompany SET CompanyName=@CompanyName, Adress=@Adress, Phone=@Phone WHERE ID=@ID";
            SqlCommand cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@ID", isyeri.ID);
            cmd.Parameters.AddWithValue("@CompanyName", isyeri.CompanyName);
            cmd.Parameters.AddWithValue("@Adress", isyeri.Address);
            cmd.Parameters.AddWithValue("@Phone", isyeri.Phone);
            con.Open();
            cmd.ExecuteNonQuery();


        }

      

    }
}
