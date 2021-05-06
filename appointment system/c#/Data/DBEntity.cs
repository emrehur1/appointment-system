using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeSon.Data
{
    public class DBEntity
    {
        public string connStr { get; private set; }
        public DBEntity()
        {
            connStr = @"Data Source=DESKTOP-E6UT6AD\SQLEXPRESS;Initial Catalog=ProjeOdevi;Integrated Security=True";
        }
    }
}
