using ProjeSon.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeSon.Logic
{
    class CompEmpAdd : DBEntity
    {

        public void Register(CompEmp emp)
        {
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand("Insert Into tblUser (UserName, Password,CompanyID,Email,Name,SurName,Phone,Adress,BirthDay,TcNo,RoleTypeID) values (@UserName, @Password,@CompanyID,@Email,@Name,@SurName,@Phone,@Adress,@BirthDay,@TcNo,@RoleTypeID)", con);

                cmd.Parameters.AddWithValue("UserName", emp.UserName);
                cmd.Parameters.AddWithValue("Password", emp.Password);
                cmd.Parameters.AddWithValue("CompanyID", emp.CompanyID);
                cmd.Parameters.AddWithValue("Email", emp.Email);
                cmd.Parameters.AddWithValue("Name", emp.Name);
                cmd.Parameters.AddWithValue("SurName", emp.SurName);
                cmd.Parameters.AddWithValue("Phone", emp.Phone);
                cmd.Parameters.AddWithValue("Adress", emp.Adress);
                cmd.Parameters.AddWithValue("BirthDay", emp.BirthDay);
                cmd.Parameters.AddWithValue("TcNo", emp.TcNo);
                cmd.Parameters.AddWithValue("RoleTypeID", emp.RoleTypeID);

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
