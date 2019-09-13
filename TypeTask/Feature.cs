using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeTask
{
    public class Feature:SpecificTask
    {
        public Feature(string _name) : base(_name)
        {
            this.Priority = 1;
        }
    }
}
