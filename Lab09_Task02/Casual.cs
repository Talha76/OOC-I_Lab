using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Task02
{
    sealed internal class Casual : Typist
    {
        public int dailyWages { get; }
        public override string whoAmI() => "I am a Casual-Typist-Staff.";
        public override void showInfo()
        {
            Console.WriteLine("\nTypist Details-\nType: Casual\nName: " + name
                + "\nCode: " + code + "\nSpeed: " + speed + "\nDaily Wages: " + dailyWages);
        }
        public Casual (string name, int code, double speed, int dailyWages) :
            base(name, code, speed)
        {
            this.dailyWages = dailyWages;
        }
    }
}
