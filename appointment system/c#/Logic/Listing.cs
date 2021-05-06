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
    class Listing : DBEntity
    {


        public List<tblCompany> Listing1()
        {
            List<tblCompany> companies = new List<tblCompany>();
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand("Select * From tblCompany", con);

                con.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var entity = new tblCompany
                            {
                                ID = reader.GetInt32(0),
                                CompanyName = reader.GetString(1),
                                CategoryID = reader.GetInt32(2),
                                Address = reader.GetString(3),
                                Phone = reader.GetString(4)


                            };
                            companies.Add(entity);
                        }
                    }

                }
                return companies;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<CompEmp> Listing2()
        {
            List<CompEmp> employees = new List<CompEmp>();
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand("Select * From tblUser", con);
                con.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var entity = new CompEmp();

                            if (!reader.IsDBNull(0))
                            {
                                entity.ID = reader.GetInt32(0);
                            }
                            if (!reader.IsDBNull(1))
                            {
                                entity.UserName = reader.GetString(1);
                            }
                            if (!reader.IsDBNull(2))
                            {
                                entity.Password = reader.GetString(2);
                            }
                            if (!reader.IsDBNull(3))
                            {
                                entity.CompanyID = reader.GetInt32(3);
                            }
                            if (!reader.IsDBNull(4))
                            {
                                entity.Email = reader.GetString(4);
                            }
                            if (!reader.IsDBNull(5))
                            {
                                entity.Name = reader.GetString(5);
                            }
                            if (!reader.IsDBNull(6))
                            {
                                entity.SurName = reader.GetString(6);
                            }
                            if (!reader.IsDBNull(7))
                            {
                                entity.Phone = reader.GetString(7);
                            }
                            if (!reader.IsDBNull(8))
                            {
                                entity.Adress = reader.GetString(8);
                            }
                            if (!reader.IsDBNull(9))
                            {
                                entity.BirthDay = reader.GetDateTime(9);
                            }
                            if (!reader.IsDBNull(10))
                            {
                                entity.TcNo = reader.GetString(10);
                            }
                            if (!reader.IsDBNull(11))
                            {
                                entity.RoleTypeID = reader.GetInt32(11);
                            }



                            employees.Add(entity);
                        }
                    }

                }
                return employees;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }






        public List<tblCompany> Search(string ara)
        {
            List<tblCompany> companies = new List<tblCompany>();
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand(ara, con);

                con.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var entity = new tblCompany
                            {
                                ID = reader.GetInt32(0),
                                CompanyName = reader.GetString(1),
                                CategoryID = reader.GetInt32(2),
                                Address = reader.GetString(3),
                                Phone = reader.GetString(4)


                            };
                            companies.Add(entity);
                        }
                    }

                }
                return companies;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<tblAppointments> AppAvailability(int companyid,int userid)
        {
            List<tblAppointments> tblAppointments = new List<tblAppointments>();

            SqlConnection con = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand("SELECT * FROM Appointments WHERE CompanyID=@CompanyID AND UserID=@UserID", con);
            cmd.Parameters.AddWithValue("CompanyID", companyid);
            cmd.Parameters.AddWithValue("UserID", userid);
            con.Open();
            using (var reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var entity = new tblAppointments
                        {
                            ID = reader.GetInt32(0),
                            UserID = reader.GetInt32(1),
                            CompanyID = reader.GetInt32(2),
                            Date = reader.GetString(3),
                            Time= reader.GetInt32(4)


                        };
                        tblAppointments.Add(entity);
                    }
                }

            }
            return tblAppointments;

        }

        public int[] control(int companyid, string date)
        {

            int[] saatler = new int[10];


            try
            {

                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand("SELECT * FROM Appointments WHERE CompanyID=@CompanyID AND Date=@Date", con);
                cmd.Parameters.AddWithValue("CompanyID", companyid);
                cmd.Parameters.AddWithValue("Date", date);
                con.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        int i = 0;
                        while (reader.Read())
                        {


                            //ID = reader.GetInt32(0),
                            //UserID = reader.GetInt32(1),
                            //CompanyID = reader.GetInt32(2),
                            //Date = reader.GetString(3),
                            saatler[i] = reader.GetInt32(4);
                            i++;




                        }
                    }



                }
                return saatler;






            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        public List<tblAppointments> appointments(string command)
        {
            List<tblAppointments> appointments = new List<tblAppointments>();
            try
            {
                SqlConnection con = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand(command, con);

                con.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var entity = new tblAppointments
                            {
                                ID = reader.GetInt32(0),
                                UserID = reader.GetInt32(1),
                                CompanyID = reader.GetInt32(2),
                                Date = reader.GetString(3),
                                Time = reader.GetInt32(4),



                            };
                            appointments.Add(entity);
                        }
                    }

                }
                return appointments;
            }
            catch (Exception ex)
            {
                throw ex;
            }













        }


    }

        }

    

