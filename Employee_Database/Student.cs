using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Database
{
    internal class Student
    {
        private int id;
        private string name, dept, semester;
        private void set_info(string id, string name, string dept, string semester)
        {
            this.id = Convert.ToInt32(id);
            this.name = name;
            this.dept = dept;
            this.semester = semester;
        }
        public string get_info() {
            string ret = this.id.ToString() + '\t' + this.name + '\t' + this.dept + '\t' + this.semester;
            return ret;
        }

        public Student(string id, string name, string dept, string semester)
        {
            this.set_info(id, name, dept, semester);
        }
    }
}
