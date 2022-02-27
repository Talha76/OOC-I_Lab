using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Task01
{
    sealed internal class Seat
    {
        public int pleasant { get; }
        public int comfy { get; }
        public bool seatWarmer { get; }
        public Seat(int pleasant, int comfy, bool seatWarmer)
        {
            this.pleasant = pleasant;
            this.comfy = comfy;
            this.seatWarmer = seatWarmer;
        }
    }
}
