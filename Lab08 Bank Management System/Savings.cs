using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_Bank_Management_System
{
    sealed internal class Savings : Account
    {
        private const int minAmountToCreate = 50000;
        private int trxLim = 5;
        private const int withdrawalCharge = 15;
        public static string ToString() { return "Lab08_Bank_Management_System.Savings"; }
        public override void prefix() { ID = int.Parse(ID + "312"); }
        public static int minAmount { get { return minAmountToCreate; } }
        public int TrxLim { get { return trxLim; } set { trxLim--; } }
        public int WithdrawalCharge { get { return withdrawalCharge; } }
        public Savings(int ID, string Name, int balance) : base(ID, Name, balance) { }
    }
}
