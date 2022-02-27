using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_Bank_Management_System
{
    internal class Loan : Account
    {
        public static string ToString() { return "Lab08_Bank_Management_System.Loan"; }
        public override void prefix() { ID = int.Parse(ID + "400"); }
        public Loan(int ID, string Name, int balance) : base(ID, Name, balance) { }
    }
}
