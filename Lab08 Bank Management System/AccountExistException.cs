using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_Bank_Management_System
{
    sealed internal class AccountExistException : Exception
    {
        public AccountExistException() : base("Account already exists.") { }
    }
}
