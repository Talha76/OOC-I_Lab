using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Task02
{
    sealed internal class Teacher : Staff
    {
        public string subject { get; }
        public string publication { get; }
        public override string whoAmI() => "I am a Teacher-Staff.";
        public override void showInfo()
        {
            Console.WriteLine("\nTeacher Details-\nName: " + name + "\nCode: " + code
                + "\nSubject: " + subject + "\nPublication: " + publication);
        }
        public Teacher (string name, int code, string subject, string publication) : base (name, code)
        {
            this.subject = subject;
            this.publication = publication;
        }
    }
}
