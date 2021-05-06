using ProjeSon.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ProjeSon.Logic
{
    class tblEmpLogic: DBEntity
    {
        public CompEmp LoginEmp(string username1, string password1,int roletypeid)

        {
            try
            {
                CompEmp Emp = null;
                SqlConnection con = new SqlConnection(connStr);

                SqlCommand cmd = new SqlCommand("Select * From tblUser where UserName=@UserName and Password=@Password and RoleTypeID=@RoleTypeID ", con);
                cmd.Parameters.Add(new SqlParameter("@UserName", username1));
                cmd.Parameters.Add(new SqlParameter("@Password", password1));
                cmd.Parameters.Add(new SqlParameter("@RoleTypeID", roletypeid));
                con.Open();


                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Emp = new CompEmp();
                            Emp.ID = reader.GetInt32(0);
                            Emp.UserName = !reader.IsDBNull(1) ? reader.GetString(1) : "";
                            Emp.Password = !reader.IsDBNull(2) ? reader.GetString(2) : "";
                            Emp.CompanyID = !reader.IsDBNull(3) ? reader.GetInt32(3) : 0;
                            Emp.Email = !reader.IsDBNull(4) ? reader.GetString(4) : "";
                            Emp.Name = !reader.IsDBNull(5) ? reader.GetString(5) : "";
                            Emp.SurName = !reader.IsDBNull(6) ? reader.GetString(6) : "";
                            Emp.Phone = !reader.IsDBNull(7) ? reader.GetString(7) : "";
                            Emp.Adress = !reader.IsDBNull(8) ? reader.GetString(8) : "";
                            Emp.BirthDay = !reader.IsDBNull(9) ? reader.GetDateTime(9) : (DateTime?)null;
                            Emp.TcNo = !reader.IsDBNull(10) ? reader.GetString(10) : "";
                            
                            Emp.RoleTypeID = !reader.IsDBNull(11) ? reader.GetInt32(11) : 0;



                        }
                    }

                }
                return Emp;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }






    }
}
