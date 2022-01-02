using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LMS_Dependecies;

namespace Lab07_LMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addTeacher(object sender, EventArgs e)
        {
            if(cbTeacherType.Text == "" || tbTeacherName.Text == "")
            {
                MessageBox.Show("Fill up the fields.");
                return;
            }
            if(cbTeacherType.Text == "Professor")
            {
                Professor temp = new Professor(tbTeacherName.Text);
                foreach(Teacher i in LMS.professorList)
                {
                    if(i.getName() == temp.getName())
                    {
                        MessageBox.Show("Professor already exists.");
                        return;
                    }
                }
                LMS.professorList.Add(temp);
                cbCourseTeacher.Items.Add(temp.getName());
                cbTeacherInfo.Items.Add(temp.getName());
                MessageBox.Show("Professor added in list.");
                return;
            }
            
            Lecturer dummy = new Lecturer(tbTeacherName.Text);
            foreach(Lecturer i in LMS.lecturerList)
            {
                if(i.getName() == dummy.getName())
                {
                    MessageBox.Show("Lecturer already exists.");
                    return;
                }
            }
            LMS.lecturerList.Add(dummy);
            cbCourseTeacher.Items.Add(dummy.getName());
            cbTeacherInfo.Items.Add(dummy.getName());
            MessageBox.Show("Lecturer added in the list.");
        }

        private void addCourse(object sender, EventArgs e)
        {
            Course temp = new Course(tbCourseCode.Text, tbCourseTitle.Text, cbCourseType.Text,
                cbCourseSem.Text);
            foreach(Course i in LMS.courseList)
            {
                if(i.getCode() == temp.getCode())
                {
                    MessageBox.Show("Course exists already.");
                    return;
                }
            }
            if(tbCourseCode.Text[1].ToString() != cbCourseSem.Text)
            {
                MessageBox.Show("Please enter valid semester or course code.");
                return;
            }

            foreach(Lecturer i in LMS.lecturerList)
            {
                if(i.getName() == cbCourseTeacher.Text)
                {
                    if(i.findCourse(temp) != null)
                    {
                        MessageBox.Show("Course already assigned.");
                        return;
                    }
                    if(temp.getType() == "Theory")
                    {
                        MessageBox.Show("Lecturers can not take theory classes.");
                        return;
                    }
                    i.addCourse(temp);
                    LMS.courseList.Add(temp);
                    cbStudentCourse.Items.Add(temp.getCode().ToString());
                    MessageBox.Show("Course Added.");
                    return;
                }
            }
            foreach(Professor i in LMS.professorList)
            {
                if(i.getName() == cbCourseTeacher.Text)
                {
                    if(i.findCourse(temp) != null)
                    {
                        MessageBox.Show("Course already assigned.");
                        return;
                    }
                    i.addCourse(temp);
                    LMS.courseList.Add(temp);
                    cbStudentCourse.Items.Add(temp.getCode().ToString());
                    MessageBox.Show("Course Added.");
                    return;
                }
            }
            MessageBox.Show("Teacher not found.");
        }

        private void addStudent(object sender, EventArgs e)
        {
            if (cbStudentCourse.Text[1].ToString() != cbStudentSem.Text)
            {
                MessageBox.Show("Enter valid semester or course code.");
                return;
            }
            Student temp = new Student(tbStudentName.Text, cbStudentSem.Text);
            foreach(Student i in LMS.studentList)
            {
                if(i.getName() == temp.getName())
                { 
                    if(i.findCourse(cbStudentCourse.Text) != null)
                    {
                        MessageBox.Show("Course already exists.");
                        return;
                    }
                    foreach(Course j in LMS.courseList)
                    {
                        if (j.getCode() == int.Parse(cbStudentCourse.Text))
                        {
                            i.addCourse(j);
                            MessageBox.Show("Student added.");
                            return;
                        }
                    }
                    return;
                }
            }

            cbStudentInfo.Items.Add(temp.getName());
            foreach (Course j in LMS.courseList)
            {
                if (j.getCode() == int.Parse(cbStudentCourse.Text))
                {
                    temp.addCourse(j);
                    break;
                }
            }
            LMS.studentList.Add(temp);
            MessageBox.Show("Student added.");
        }

        private void showTeacher(object sender, EventArgs e)
        {
            lbTeacherInfo.Items.Clear();
            foreach(Lecturer i in LMS.lecturerList)
            {
                if(i.getName() == cbTeacherInfo.Text)
                {
                    lbTeacherInfo.Items.Add("Name: " + i.getName());
                    lbTeacherInfo.Items.Add("Designation: Lecturer");
                    lbTeacherInfo.Items.Add("Total Credit: " + i.getCredit().ToString());
                    lbTeacherInfo.Items.Add("Courses:");
                    foreach(Course j in i.courseList)
                    {
                        lbTeacherInfo.Items.Add(j.getCode().ToString() + " " + j.getTitle());
                    }
                    return;
                }
            }
            foreach(Professor i in LMS.professorList)
            {
                if(i.getName() == cbTeacherInfo.Text)
                {
                    lbTeacherInfo.Items.Add("Name: " + i.getName());
                    lbTeacherInfo.Items.Add("Designation: Professor");
                    lbTeacherInfo.Items.Add("Total Credit: " + i.getCredit().ToString());
                    lbTeacherInfo.Items.Add("Courses:");
                    foreach (Course j in i.courseList)
                    {
                        lbTeacherInfo.Items.Add(j.getCode().ToString() + " " + j.getTitle());
                    }
                }
            }
        }

        private void showStudent(object sender, EventArgs e)
        {
            lbSudentInfo.Items.Clear();
            foreach(Student i in LMS.studentList)
            {
                lbSudentInfo.Items.Add("Name: " + i.getName());
                lbSudentInfo.Items.Add("Semester: " + i.getSemester().ToString());
                lbSudentInfo.Items.Add("Courses: ");
                foreach(Course j in i.courseList)
                {
                    lbSudentInfo.Items.Add(j.getCode() + " " + j.getTitle());
                }
            }
        }

        private void clearTeacherInfo(object sender, EventArgs e)
        {
            tbTeacherName.Clear();
            cbTeacherType.ResetText();
        }

        private void clearCourseInfo(object sender, EventArgs e)
        {
            tbCourseCode.Clear();
            tbCourseTitle.Clear();
            cbCourseSem.ResetText();
            cbCourseTeacher.ResetText();
            cbCourseType.ResetText();
        }

        private void clearStudentInfo(object sender, EventArgs e)
        {
            tbStudentName.Clear();
            cbStudentCourse.ResetText();
            cbStudentSem.ResetText();
        }

        private void sortBasedOnSem(object sender, MouseEventArgs e)
        {
            cbStudentCourse.Items.Clear();
            foreach(Course j in LMS.courseList)
            {
                string temp = j.getCode().ToString();
                if (j.getCode().ToString()[1].ToString() == cbStudentSem.Text)
                    cbStudentCourse.Items.Add(j.getCode().ToString());
            }
        }
    }
}
