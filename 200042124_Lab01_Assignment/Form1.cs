using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _200042124_Lab01_Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void calculateGrade(object sender, EventArgs e)
        {
            double attendance_cnt = Convert.ToInt32(attendedClasses.Text);
            int attendance_mark = (int) Math.Ceiling(attendance_cnt * 30 / 28);
            attendanceMark.Text = Convert.ToString(attendance_mark) + " / 30";
            midMark.Text = midBox.Text + " / 75";
            finalMark.Text = finalBox.Text + " / 150";

            int quiz_mark1 = Convert.ToInt32(quiz1.Text), quiz_mark2 = Convert.ToInt32(quiz2.Text);
            int quiz_mark3 = Convert.ToInt32(quiz3.Text), quiz_mark4 = Convert.ToInt32(quiz4.Text);
            int quiz_mark = quiz_mark1 + quiz_mark2 + quiz_mark3 + quiz_mark4;
            quiz_mark -= Math.Min(quiz_mark1, Math.Min(quiz_mark2, Math.Min(quiz_mark3, quiz_mark4)));

            quizMark.Text = Convert.ToString(quiz_mark) + " / 45";

            int total_mark = quiz_mark + attendance_mark + Convert.ToInt32(midBox.Text) + Convert.ToInt32(finalBox.Text);
            totalMark.Text = Convert.ToString(total_mark);
            totalMark.Text += "/300";

            finalResult.Text = studentName.Text + " obtained " + Convert.ToString(Math.Ceiling(total_mark / 3D));
            finalResult.Text += "% marks.";
            int grade_mark = (int)Math.Ceiling(total_mark / 3.0);

            if (grade_mark >= 80) grade.Text = "A+";
            else if (grade_mark >= 75 && grade_mark < 80) grade.Text = "A";
            else if (grade_mark >= 70 && grade_mark < 75) grade.Text = "A-";
            else if (grade_mark >= 65 && grade_mark < 70) grade.Text = "B+";
            else if (grade_mark >= 60 && grade_mark < 65) grade.Text = "B";
            else if (grade_mark >= 55 && grade_mark < 60) grade.Text = "B-";
            else if (grade_mark >= 50 && grade_mark < 55) grade.Text = "C+";
            else if (grade_mark >= 45 && grade_mark < 50) grade.Text = "C-";
            else if (grade_mark >= 40 && grade_mark < 45) grade.Text = "D";
            else grade.Text = "F";
            grade.Visible = finalResult.Visible = attendanceMark.Visible = midMark.Visible = true;
            finalMark.Visible = quizMark.Visible = true;
        }
    }
}
