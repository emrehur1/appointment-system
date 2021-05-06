using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeSon.Data
{
    class CompEmp:tblUser
    {

        public DateTime? BirthDay { get; set; }
        public string TcNo { get; set; }
        public int CompanyID { get; set; }
    }
}
