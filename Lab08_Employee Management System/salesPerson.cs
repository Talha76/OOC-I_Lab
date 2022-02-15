using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_Employee_Management_System
{
    sealed internal class salesPerson: Employee
    {
        public override double getBonus() { return .1; }
        public salesPerson(string Name, string Contact, DateTime dateOfJoining, int Salary, int Leaves):
            base(Name, Contact, dateOfJoining, Salary, Leaves)
        { }
    }
}
