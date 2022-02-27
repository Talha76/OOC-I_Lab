using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_Bank_Management_System
{
    static internal class BMS
    {
        static private List<Account> accountList;
        static public void addAccount(Account a) { accountList.Add(a); }
        static public void removeAccount(Account a) { accountList.Remove(a); }
        static public Account findAccount(Account t)
        {
            foreach (Account a in accountList)
            {
                if (a.Name == t.Name)
                    return a;
            }
            throw new ApplicationException("Account does not exist.");
        }
        static public Account findAccount(int ID)
        {
            foreach(Account a in accountList)
            {
                if (a.ID == ID)
                    return a;
            }
            throw new ApplicationException("Account does not exist.");
        }
        static public int getAvailableID() { return accountList.Count + 1; }
        static BMS() { accountList = new List<Account>(); }
    }
}
