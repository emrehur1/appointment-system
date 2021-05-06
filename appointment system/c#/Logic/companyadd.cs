using System;
using ProjeSon.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeSon.Logic
{
    class companyadd : DBEntity
    {
        public void addCompany(tblCompany company)
        {
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand("INSERT INTO tblCompany(CompanyName,CategoryID,Adress,Phone) values (@CompanyName,@CategoryID,@Adress,@Phone)", con);
                cmd.Parameters.AddWithValue("CompanyName", company.CompanyName);
                cmd.Parameters.AddWithValue("CategoryID", company.CategoryID);
                cmd.Parameters.AddWithValue("Adress", company.Address);
                cmd.Parameters.AddWithValue("Phone", company.Phone);
                con.Open();
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
