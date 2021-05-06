using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeSon.Data
{
    class NormUser: tblUser
    {
        public NormUser()
        {

        }
        public DateTime EntryDate { get; set; }
    }
}
