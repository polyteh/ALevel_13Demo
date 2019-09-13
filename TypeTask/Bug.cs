using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeTask
{
    public class Bug:SpecificTask
    {
        public Bug(string _name):base(_name)
        {
            this.Priority =2;
        }
    }
}
