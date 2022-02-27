using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Task01
{
    sealed internal class Door
    {
        public string openingMode { get; }
        public Door(string openingMode) { this.openingMode = openingMode; }
    }
}
