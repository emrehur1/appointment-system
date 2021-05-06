using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeSon.Data
{
    public class tblUser
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        //public int? CompanyID { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
       // public DateTime? BirthDay { get; set; }
        //public string TcNo { get; set; }
        //public DateTime? EntryDate { get; set; }
        public int? RoleTypeID { get; set; }
    }
}
