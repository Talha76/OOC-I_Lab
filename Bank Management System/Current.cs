using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Management_System
{
    sealed internal class Current : Account
    {
        private int minBalance;
        private int maxTrx;
        public Current(string Name, int Balance) : base(Name, Balance)
        {
            minBalance = 500;
            maxTrx = 100000;
        }
    }
}
