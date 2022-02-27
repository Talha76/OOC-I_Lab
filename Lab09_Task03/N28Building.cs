using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Task03
{
    static internal class N28Building
    {
        static private List<Lab> labList;
        static private List<LecturerRoom> lecturerRooms;
        static public Lab find(string labName)
        {
            foreach(Lab lab in labList)
            {
                if (lab.labName == labName)
                    return lab;
            }
            throw new Exception();
        }
        static public void add(Lab lab)
        {
            try
            {
                find(lab.labName);
            }
            catch
            {
                labList.Add(lab);
            }
        }
        static public void showAllLabs()
        {
            int count = 1;
            foreach(Lab lab in labList)
            {
                Console.WriteLine(count++ + ". Lab Name: " + lab.labName + ", Capacity: "
                    + lab.capacity);
            }
        }
        static LecturerRoom find(int roomNo)
        {
            foreach(LecturerRoom lecturer in lecturerRooms)
            {
                if(lecturer.roomNo == roomNo)
                    return lecturer;
            }
            throw new Exception();
        }
        static public void add(LecturerRoom lecturerRoom)
        {
            try
            {
                find(lecturerRoom.roomNo);
            }
            catch
            {
                lecturerRooms.Add(lecturerRoom);
            }
        }
        static public void showAllLecturerRooms()
        {
            int count = 1;
            foreach(LecturerRoom lecturerRoom in lecturerRooms)
            {
                Console.WriteLine(count++ + ". Lecturer Room Name: " + lecturerRoom.roomName
                    + ", Room No: " + lecturerRoom.roomNo + ", Capacity: " + lecturerRoom.capacity);
            }
        }
        static N28Building()
        {
            labList = new List<Lab>();
            lecturerRooms = new List<LecturerRoom>();
        }
    }
}
