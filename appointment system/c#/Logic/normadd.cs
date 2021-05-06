using System;
using ProjeSon.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeSon.Logic
{
    class normadd:DBEntity
    {


        public void normalsignup(NormUser normal)
        {
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                string komut = "INSERT INTO tblUser(UserName,Password,Email,Name,SurName,Phone,Adress,RoleTypeID) values (@UserName,@Password,@Email,@Name,@SurName,@Phone,@Adress,@RoleTypeID)";
                SqlCommand cmd = new SqlCommand(komut, con);
                cmd.Parameters.AddWithValue("@UserName", normal.UserName);
                cmd.Parameters.AddWithValue("@Password", normal.Password);
                cmd.Parameters.AddWithValue("@Email", normal.Email);
                cmd.Parameters.AddWithValue("@Name", normal.Name);
                cmd.Parameters.AddWithValue("@SurName", normal.SurName);
                cmd.Parameters.AddWithValue("@Phone", normal.Phone);
                cmd.Parameters.AddWithValue("@Adress", normal.Adress);
                cmd.Parameters.AddWithValue("@RoleTypeID", normal.RoleTypeID);
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
