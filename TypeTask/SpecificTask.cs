using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeTask
{
    public abstract class SpecificTask
    {
        public SpecificTask(string _name)
        {
            this.Name = _name;


        }
        public string Name { get; set; }
        public double Priority { get; protected set; }

    }
}
