using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Database
{
    public partial class Form1 : Form
    {
        List<Student> students = new List<Student>();
        List<Teacher> teachers = new List<Teacher>();
        public Form1()
        {
            InitializeComponent();
        }

        private bool find_student(Student query) {
            foreach(Student i in students)
            {
                if (i.get_info() == query.get_info()) return true;
            }
            return false;
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Student_Clear_Info(object sender, EventArgs e)
        {
            Student_ID_textbox.Clear();
            Student_Name_textbox.Clear();
            Student_dept_textbox.Clear();
            Student_semester_textbox.Clear();
            MessageBox.Show("Cleared Successfully!");
        }

        private void Student_Save_Info(object sender, EventArgs e)
        {
            // student_listbox.Items.Clear();
            string id, name, dept, semester;
            id = Student_ID_textbox.Text;
            name = Student_Name_textbox.Text;
            dept = Student_dept_textbox.Text;
            semester = Student_semester_textbox.Text;

            Student temporary = new Student(id, name, dept, semester)
            students.Add(temporary);

            if (this.find_student(temporary) == false)
            {
                student_listbox.Items.Add(temporary.get_info());
            }
            MessageBox.Show("Saved Successfully!");
        }

        private void Teacher_clear_info(object sender, EventArgs e)
        {
            Teacher_ID_textbox.Clear();
            Teacher_name_textbox.Clear();
            Teacher_dept_textbox.Clear();
            Teacher_designation_textbox.Clear();
            Teacher_salaray_textbox.Clear();
            MessageBox.Show("Cleared Successfully!");
        }

        private void Teacher_save_info(object sender, EventArgs e)
        {
            string id, name, dept, designation, salary;
            id = Teacher_ID_textbox.Text;
            name = Teacher_name_textbox.Text;
            dept = Teacher_dept_textbox.Text;
            designation = Teacher_designation_textbox.Text;
            salary = Teacher_salaray_textbox.Text;

            Teacher temporary = new Teacher(id, name, dept, designation,salary);
            teachers.Add(temporary);
            // Teacher_listbox.Items.Add(temporary.get_info());
            MessageBox.Show("Saved Successfully!");
        }

        private void show_teachers_list(object sender, EventArgs e)
        {
            Teacher_listbox.Items.Clear();
            foreach (Teacher i in teachers)
                Teacher_listbox.Items.Add(i.get_info());
        }

        private void show_student_list(object sender, EventArgs e)
        {
            student_listbox.Items.Clear();
            foreach (Student i in students)
                student_listbox.Items.Add(i.get_info());
        }
    }
}
