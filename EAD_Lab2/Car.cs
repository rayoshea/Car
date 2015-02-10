using System;
using System.Collections.Generic;
using System.Linq;

namespace EAD_Lab2
{
    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Reg { get; set; }
        public int EngSize { get; set; }

        public override string ToString()
        {
            return Make + " " + Model + " " + Reg + " " + EngSize;
        }
    }
}
