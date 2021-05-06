using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeSon.Data
{
    public abstract class DialogCustom
    {
        public string Message;

        abstract public void DialogPush(string Message);
    }
}
