using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagementSystem
{
    internal class User
    {
        private int ID;
        private string Name;
        private string contactNo;
        private string Address;

        public int getID() { return ID; }
        public string getName() { return Name; }
        public string getContactNo() { return contactNo; }
        public string getAddress() { return Address; }
        public User() { }
        public User(string ID, string Name, string contactNo, string Address)
        {
            this.ID = int.Parse(ID);
            this.Name = Name;
            this.contactNo = contactNo;
            this.Address = Address;
        }
    }
}
