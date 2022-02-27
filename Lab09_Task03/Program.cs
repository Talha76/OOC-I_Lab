using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Task03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char c;
            while (true)
            {
                string cmd;
                Console.Write("Enter an option(add, show, quit): ");
                cmd = Console.ReadLine();
                if (cmd == "quit")
                    break;

                if(cmd == "add")
                {
                    string name, type;
                    int capacity;

                    Console.Write("Enter room name: ");
                    name = Console.ReadLine();
                    Console.Write("Enter capacity: ");
                    capacity = int.Parse(Console.ReadLine());
                    Console.Write("Enter room type(Lab/Lecturer Room): ");
                    type = Console.ReadLine();
                    if(type == "Lab")
                    {
                        Lab lab = new Lab(name, capacity);
                        N28Building.add(lab);
                    }
                    else if(type == "Lecturer Room")
                    {
                        int roomNo;
                        Console.Write("Enter Room No: ");
                        roomNo = int.Parse(Console.ReadLine());
                        LecturerRoom lecturer = new LecturerRoom(name, roomNo
                            , capacity);
                        N28Building.add(lecturer);
                    }
                }
                else if(cmd == "show")
                {
                    string type;
                    Console.Write("Enter room type(Lab/Lecturer Room): ");
                    type = Console.ReadLine();
                    if (type == "Lab")
                        N28Building.showAllLabs();
                    else if (type == "Lecturer Room")
                        N28Building.showAllLecturerRooms();
                }
            }
            Console.ReadKey();
        }
    }
}
