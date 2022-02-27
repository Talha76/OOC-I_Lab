using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_Bank_Management_System
{
    abstract internal class Account
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int balance { get; set; }
        abstract public void prefix();
        protected Account(int ID, string Name, int balance)
        {
            this.ID = ID;
            if (string.IsNullOrEmpty(Name))
                throw new ApplicationException("Enter your name.");
            this.Name = Name;
            if (balance < 0)
                throw new ApplicationException("Balance cannot be negative.");
            this.balance = balance;
        }
    }
}
