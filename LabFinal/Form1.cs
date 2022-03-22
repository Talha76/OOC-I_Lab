using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LabFinal
{
    public partial class Form1 : Form
    {
        List<Student> students;
        private void updateListbox()
        {
            idListbox.Items.Add("Course Name: Object Oriented Concepts I");
            idListbox.Items.Add("ID\t\tName\t\t\tPercentage\tGrade");
            foreach(Student student in students)
            {
                idListbox.Items.Add(student.ID);
                nameListbox.Items.Add(student.Name);
                percentListbox.Items.Add($"{Math.Round(student.getPercentage(), 2)}%");
                gradeListbox.Items.Add(student.getLetterGrade());
            }
        }

        public Form1()
        {
            InitializeComponent();
            students = new List<Student>();
            using (var reader = new StreamReader(@"E:\SWE-4202-OOC-I_Lab\SWE4201MarkSheet.csv"))
            {
                string temp = reader.ReadLine();
                while(!reader.EndOfStream)
                {
                    temp = reader.ReadLine();
                    var values = temp.Split(',');

                    string Mid = values[7] == "" ? "0" : values[7];
                    string Final = values[8] == "" ? "0" : values[8];
                    string Viva = values[9] == "" ? "0" : values[9];
                    students.Add(new Student(values[1], values[0], values[2], values[3],
                        values[4], values[5], values[6], Mid,
                        Final, Viva));
                }

                updateListbox();
            }
        }

        private void search(object sender, EventArgs e)
        {
            ListBoxInfo.Items.Clear();
            if(TextboxID.Text == "")
            {
                MessageBox.Show("Enter an ID.");
                return;
            }
            int id = int.Parse(TextboxID.Text);
            var info = from student in students where student.ID == id select student;

            if(info.Count() == 0)
            {
                MessageBox.Show("Student ID not found!");
                return;
            }

            Student value = info.First();
            ListBoxInfo.Items.Add($"Attendence: {value.Attendance}");
            ListBoxInfo.Items.Add($"Quiz 1: {value.quiz[0]}");
            ListBoxInfo.Items.Add($"Quiz 2: {value.quiz[1]}");
            ListBoxInfo.Items.Add($"Quiz 3: {value.quiz[2]}");
            ListBoxInfo.Items.Add($"Quiz 4: {value.quiz[3]}");
            ListBoxInfo.Items.Add($"Quiz Total (Best 3): {value.getTotalQuiz()}");
            ListBoxInfo.Items.Add($"Mid: {value.Mid}");
            ListBoxInfo.Items.Add($"Final: {value.Final}");
            ListBoxInfo.Items.Add($"Viva: {value.Viva}");
            ListBoxInfo.Items.Add($"Total (Out of 300): {value.getTotal()}");
            ListBoxInfo.Items.Add($"Percentage: {Math.Round(value.getPercentage(), 2)}%");
            ListBoxInfo.Items.Add($"Grade: {value.getLetterGrade()}");
        }
    }
}
