using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Task03
{
    internal class LecturerRoom
    {
        public string roomName { get; set; }
        public int roomNo { get; set; }
        public int capacity { get; set; }
        public LecturerRoom(string roomName, int roomNo, int capacity)
        {
            this.roomName = roomName;
            this.roomNo = roomNo;
            this.capacity = capacity;

        }
        public LecturerRoom() { }
    }
}
