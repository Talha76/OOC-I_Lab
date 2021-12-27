using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    internal class Booking
    {
        private int ID;
        private User user;
        private string roomType;
        public int roomNo;
        private int Qty;
        private string entryDate;
        private string depDate;
        private string Status;

        public int getID() { return ID; }
        public int getRoomNo() { return roomNo; }
        public void setRoomNo(int roomNo) { this.roomNo = roomNo; }
        public string getStatus() { return Status; }
        public string getName() { return user.getName(); }
        public string getAddress() { return user.getAddress(); }
        public void setStatus(string Status) { this.Status = Status; }
        public void setID(int ID) { this.ID = ID; }
        public string getInfo()
        {
            return roomType + "\t\t" + Qty.ToString() + "\t" + getCost().ToString() + "\t"
                + getStatus();
        }
        public int getCost()
        {
            switch(roomType)
            {
                case "Single": return Qty * 2000;
                case "Double": return Qty * 2500;
                case "Suit": return Qty * 3000;
                case "Deluxe": return Qty * 3500;
                default: return 0;
            }
        }
        public Booking() { }
        public Booking(string userID, string roomType, string Qty, string entryDate,
            string depDate)
        {
            // this.ID = int.Parse(ID);
            foreach(User i in Hotel.userList)
            {
                if(i.getID() == int.Parse(userID))
                {
                    this.user = i;
                    break;
                }
            }
            this.roomType = roomType;
            this.Qty = int.Parse(Qty);
            this.entryDate = entryDate;
            this.depDate = depDate;
        }
    }
}
