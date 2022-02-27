using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_Bank_Management_System
{
    sealed internal class Current : Account
    {
        private static int minBalance = 500;
        public static string ToString() { return "Lab08_Bank_Management_System.Current"; }
        public override void prefix() { ID = int.Parse(ID + "300"); }
        public static int minBal { get { return minBalance; } }
        public Current(int ID, string Name, int balance) : base(ID, Name, balance) { }
    }
}
