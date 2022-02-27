using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Task02
{
    abstract internal class Typist : Staff
    {
        public double speed { get; }
        public Typist (string name, int code, double speed) : base (name, code)
        {
            this.speed = speed;
        }
    }
}
