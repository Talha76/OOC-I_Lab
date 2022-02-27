using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int code;
            string name, staffType;

            Console.Write("Enter staff type(Teacher/Typist/Officer): ");
            staffType = Console.ReadLine();

            Console.Write("Enter code: ");
            code = int.Parse(Console.ReadLine());

            Console.Write("Enter name: ");
            name = Console.ReadLine();

            if(staffType == "Teacher")
            {
                string subject, publication;

                Console.Write("Enter Subject: ");
                subject = Console.ReadLine();

                Console.Write("Enter Publication: ");
                publication = Console.ReadLine();
                
                Teacher teacher = new Teacher(name, code, subject, publication);
                teacher.showInfo();
                Console.WriteLine(teacher.whoAmI());
            }
            else if(staffType == "Typist")
            {
                string typistType;
                double speed;

                Console.Write("Enter typist type(Regular/Casual): ");
                typistType = Console.ReadLine();

                Console.Write("Enter typing speed: ");
                speed = double.Parse(Console.ReadLine());

                if(typistType == "Regular")
                {
                    Regular regularTypist = new Regular(name, code, speed);
                    regularTypist.showInfo();
                    Console.WriteLine(regularTypist.whoAmI());
                }
                else if(typistType == "Casual")
                {
                    int dailyWages;

                    Console.Write("Enter daily wages: ");
                    dailyWages = int.Parse(Console.ReadLine());

                    Casual casualTypist = new Casual(name, code, speed, dailyWages);
                    casualTypist.showInfo();
                    Console.WriteLine(casualTypist.whoAmI());
                }
            }
            else if(staffType == "Officer")
            {
                int grade;

                Console.Write("Enter offier grade: ");
                grade = int.Parse(Console.ReadLine());

                Officer officer = new Officer(name, code, grade);
                officer.showInfo();
                Console.WriteLine(officer.whoAmI());
            }
            Console.ReadKey();
        }
    }
}
