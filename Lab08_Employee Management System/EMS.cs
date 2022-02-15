using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_Employee_Management_System
{
    static internal class EMS
    {
        static private List<Employee> employeeList;
        static public void Add(Employee e)
        {
            employeeList.Add(e);
        }
        static public Employee find(Employee e)
        {
            foreach(Employee i in employeeList)
            {
                if (i.getContact() == e.getContact())
                    return i;
            }
            throw new ApplicationException("Employee not found!");
        }
        static public Employee find(int ID)
        {
            if(ID < employeeList.Count)
                return employeeList[ID];
            throw new ApplicationException("Employee not found");
        }
        static public int getLastID() { return employeeList.Count; }
        static public int getIndex(Employee e) { return employeeList.IndexOf(e); }
        static EMS() { employeeList = new List<Employee>(); }
    }
}
