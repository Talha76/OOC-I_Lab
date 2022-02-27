using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Task02
{
    sealed internal class Officer : Staff
    {
        public int grade { get; }
        public override string whoAmI() => "I am an Officer-Staff.";
        public override void showInfo()
        {
            Console.WriteLine("\nOfficer Details-\nName: " + name + "\nCode: " + code
                + "\nGrade: " + grade);
        }
        public Officer (string name, int code, int grade) : base (name, code)
        {
            this.grade = grade;
        }
    }
}
