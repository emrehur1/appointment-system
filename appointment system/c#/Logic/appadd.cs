using System;
using ProjeSon.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeSon.Logic
{
    class appadd:DBEntity
    {

        public void AppAdd(tblAppointments appointments)
        {


            try
            {


                SqlConnection con = new SqlConnection(connStr);
                string sorgu = "INSERT INTO Appointments(UserID,CompanyID,Date,Time) values (@UserID,@CompanyID,@Date,@Time)";
                SqlCommand cmd = new SqlCommand(sorgu, con);
                cmd.Parameters.AddWithValue("UserID", appointments.UserID);
                cmd.Parameters.AddWithValue("CompanyID", appointments.CompanyID);
                cmd.Parameters.AddWithValue("Date", appointments.Date);
                cmd.Parameters.AddWithValue("Time", appointments.Time);
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
