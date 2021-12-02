using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Database
{
    internal class Teacher
    {
        private int id, salary;
        private string name, dept, designation;
        public string get_info()
        {
            string ret = this.id.ToString() + '\t' + this.name + '\t' + this.dept + '\t';
            ret += this.designation + '\t' + this.salary.ToString();

            return ret;
        }
        public void set_info(string id, string name, string dept, string designation, string salary)
        {
            this.id = Convert.ToInt32(id);
            this.name = name;
            this.dept = dept;
            this.designation = designation;
            this.salary = Convert.ToInt32(salary);
        }
        public Teacher(string id, string name, string dept, string designation, string salary)
        {
            this.set_info(id, name, dept, designation, salary);
        }
    }
}
