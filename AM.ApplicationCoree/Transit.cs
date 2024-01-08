using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCoree
{
    public class Transit
    {
        public string NumberTransit { get; set; }
        public string Locations { get; set; }
        public string Durations { get; set; }
        public override string ToString()
        {
            return $" {NumberTransit} , {Locations} , {Durations}}  ";
        }
    }
}


