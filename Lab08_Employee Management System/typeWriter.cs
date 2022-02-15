using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_Employee_Management_System
{
    sealed internal class typeWriter: Employee
    {
        public override double getBonus() { return .05; }
        public typeWriter(string Name, string Contact, DateTime dateOfJoining, int Salary, int Leaves) :
            base(Name, Contact, dateOfJoining, Salary, Leaves)
        { }
    }
}
