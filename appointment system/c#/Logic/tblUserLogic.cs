  using ProjeSon.Data;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ProjeSon.Logic
{
    public class tblUserLogic : DBEntity
    {

        public tblUser Login(string username, string password, int roletypeid)
        
        {
            try
            {
                tblUser usr = null;
                SqlConnection con = new SqlConnection(connStr);
                
                SqlCommand cmd = new SqlCommand("Select top 1 * From tblUser where UserName=@UserName and Password=@Password and RoleTypeID=@RoleTypeID", con);
                cmd.Parameters.Add(new SqlParameter("@UserName", username));
                cmd.Parameters.Add(new SqlParameter("@Password", password));
                cmd.Parameters.Add(new SqlParameter("@RoleTypeId", roletypeid));
                con.Open();


                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            usr = new tblUser();
                            usr.ID = reader.GetInt32(0);
                            usr.UserName = !reader.IsDBNull(1) ? reader.GetString(1) :"";
                            usr.Password = !reader.IsDBNull(2) ? reader.GetString(2) :"" ;
                            //usr.CompanyID = !reader.IsDBNull(3) ? reader.GetInt32(3) : 0;
                            usr.Email = !reader.IsDBNull(4) ? reader.GetString(4):"";
                            usr.Name = !reader.IsDBNull(5) ? reader.GetString(5):"";
                            usr.SurName = !reader.IsDBNull(6) ? reader.GetString(6) : "";
                            usr.Phone = !reader.IsDBNull(7) ? reader.GetString(7) :"";
                            usr.Adress = !reader.IsDBNull(8) ? reader.GetString(8) :"";
                            //usr.BirthDay = !reader.IsDBNull(9) ? reader.GetDateTime(9) : (DateTime?)null;
                            //usr.TcNo = !reader.IsDBNull(10) ? reader.GetString(10):"";
                            //usr.EntryDate = !reader.IsDBNull(11) ? reader.GetDateTime(11) : (DateTime?)null;
                            usr.RoleTypeID = !reader.IsDBNull(11) ?reader.GetInt32(11) : 0;



                        }
                    }

                }
                return usr;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        






    }
}
