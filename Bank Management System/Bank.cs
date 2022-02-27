using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Management_System
{
    static internal class Bank
    {
        static public List<Account> accountList;
        static Bank()
        {
            accountList = new List<Account>();
        }
    }
}
