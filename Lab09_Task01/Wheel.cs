using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Task01
{
    sealed internal class Wheel
    {
        public double circumference { get; }
        public Wheel(double circumference) { this.circumference = circumference; }
    }
}
