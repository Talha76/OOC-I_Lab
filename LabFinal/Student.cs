using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabFinal
{
    internal class Student
    {
        public string Name { get; }
        public int ID { get; }
        public double Attendance { get; }
        public double[] quiz { get; }
        public double Mid { get; }
        public double Final { get; }
        public double Viva { get; }
        public double getTotalQuiz()
        {
            double[] dummy = quiz;
            Array.Sort(dummy);
            return quiz.Sum() - dummy[0];
        }
        public double getTotal()
        {
            return Attendance + getTotalQuiz() + Mid + Final + Viva;
        }
        public double getPercentage()
        {
            return getTotal() / 3.0;
        }
        public string getLetterGrade()
        {
            string letterGrade;
            double percentage = getPercentage();
            if (percentage >= 80)
                letterGrade = "A+";
            else if (percentage < 80 && percentage >= 75)
                letterGrade = "A";
            else if (percentage < 75 && percentage >= 70)
                letterGrade = "A-";
            else if (percentage >= 65 && percentage < 70)
                letterGrade = "B+";
            else if (percentage < 65 && percentage >= 60)
                letterGrade = "B";
            else if (percentage < 60 && percentage >= 55)
                letterGrade = "B-";
            else if (percentage < 55 && percentage >= 50)
                letterGrade = "C+";
            else if (percentage < 50 && percentage >= 45)
                letterGrade = "C";
            else if (percentage < 45 && percentage >= 40)
                letterGrade= "D";
            else
                letterGrade = "F";
            return letterGrade;
        }
        public Student() { }
        public Student(string Name, string ID, string Attendance, string quiz1, string quiz2, string quiz3,
            string quiz4, string Mid, string Final, string Viva)
        {
            this.Name = Name;
            this.ID = int.Parse(ID);
            this.Attendance = double.Parse(Attendance);
            quiz = new double[4];

            this.quiz[0] = quiz1 == "" ? 0 : double.Parse(quiz1);
            this.quiz[1] = quiz2 == "" ? 0 : double.Parse(quiz2);
            this.quiz[2] = quiz3 == "" ? 0 : double.Parse(quiz3);
            this.quiz[3] = quiz4 == "" ? 0 : double.Parse(quiz4);

            this.Mid = double.Parse(Mid);
            this.Final = double.Parse(Final);
            this.Viva = double.Parse(Viva);
        }
    }
}
