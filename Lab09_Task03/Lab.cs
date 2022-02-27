using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Task03
{
    internal class Lab
    {
        public string labName { get; set; }
        public int capacity { get; set; }
        public Lab(string labName, int capacity)
        {
            this.labName = labName;
            this.capacity = capacity;
        }
        public Lab() { }
    }
}
