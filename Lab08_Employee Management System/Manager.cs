using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_Employee_Management_System
{
    sealed internal class Manager: Employee
    {
        public override double getBonus() { return .15; }
        public Manager(string Name, string Contact, DateTime dateOfJoining, int Salary, int Leaves):
            base(Name, Contact, dateOfJoining, Salary, Leaves)
        { }
    }
}
