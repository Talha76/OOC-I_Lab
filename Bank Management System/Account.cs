using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Management_System
{
    abstract internal class Account
    {
        private string Name;
        private int Balance;
        
        public string getName() { return Name; }
        public int getBalance() { return Balance; }
        public void setBalance(int Balance) { this.Balance = Balance; }
        public Account(string Name, int Balance)
        {
            this.Name = Name;
            this.Balance = Balance;
        }
    }
}
