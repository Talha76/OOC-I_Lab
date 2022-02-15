using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_Employee_Management_System
{
    abstract internal class Employee
    {
        private string Name;
        public int ID;
        private string Contact;
        private DateTime joiningDate;
        private int Salary;
        private int Leaves;

        public string getName() { return Name; }
        public int getID() { return ID; }
        public string getContact() { return Contact; }
        public DateTime getDateOfJoining() { return joiningDate; }
        public int getSalary() { return Salary; }
        public int getLeaves() { return Leaves; }
        public void setName(string Name) { this.Name = Name; }
        public void setID(int ID) { this.ID = ID; }
        public void setContact(string Contact) { this.Contact = Contact; }
        public void setSalary(int Salary) { this.Salary = Salary; }
        public void setLeaves(int Leaves) { this.Leaves = Leaves; }
        abstract public double getBonus();
        protected Employee(string Name, string Contact, DateTime joiningDate, int Salary, int Leaves)
        {
            this.Name = Name;
            this.Contact = Contact;
            this.joiningDate = joiningDate;
            this.Salary = Salary;
            this.Leaves = Leaves;
        } 
    }
}
