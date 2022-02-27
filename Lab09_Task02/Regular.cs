using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Task02
{
    sealed internal class Regular : Typist
    {
        public override string whoAmI() => "I am a Regular-Typist-Staff.";
        public override void showInfo()
        {
            Console.WriteLine("\nTypist Details-\nType: Regular\nName: " + name
                + "\nCode: " + code + "\nSpeed: " + speed);
        }
        public Regular(string name, int code, double speed) : base (name, code, speed) { }
    }
}
