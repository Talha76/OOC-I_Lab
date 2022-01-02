namespace Lab07_LMS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbTeacherName = new System.Windows.Forms.TextBox();
            this.cbTeacherType = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbCourseTeacher = new System.Windows.Forms.ComboBox();
            this.cbCourseSem = new System.Windows.Forms.ComboBox();
            this.cbCourseType = new System.Windows.Forms.ComboBox();
            this.tbCourseTitle = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbStudentName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbStudentSem = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbStudentCourse = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lbTeacherInfo = new System.Windows.Forms.ListBox();
            this.lbSudentInfo = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.cbTeacherInfo = new System.Windows.Forms.ComboBox();
            this.cbStudentInfo = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.tbCourseCode = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Teacher Info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(12, 93);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(105, 20);
            this.lb1.TabIndex = 2;
            this.lb1.Text = "Teacher Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(471, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Course Info";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(386, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Course Code";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(390, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Course Type";
            // 
            // tbTeacherName
            // 
            this.tbTeacherName.Location = new System.Drawing.Point(123, 58);
            this.tbTeacherName.Name = "tbTeacherName";
            this.tbTeacherName.Size = new System.Drawing.Size(194, 26);
            this.tbTeacherName.TabIndex = 6;
            // 
            // cbTeacherType
            // 
            this.cbTeacherType.FormattingEnabled = true;
            this.cbTeacherType.Items.AddRange(new object[] {
            "Professor",
            "Lecturer"});
            this.cbTeacherType.Location = new System.Drawing.Point(123, 90);
            this.cbTeacherType.Name = "cbTeacherType";
            this.cbTeacherType.Size = new System.Drawing.Size(194, 28);
            this.cbTeacherType.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(395, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Course Title";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(410, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Semester";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(421, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "Teacher";
            // 
            // cbCourseTeacher
            // 
            this.cbCourseTeacher.FormattingEnabled = true;
            this.cbCourseTeacher.Location = new System.Drawing.Point(494, 189);
            this.cbCourseTeacher.Name = "cbCourseTeacher";
            this.cbCourseTeacher.Size = new System.Drawing.Size(194, 28);
            this.cbCourseTeacher.TabIndex = 11;
            // 
            // cbCourseSem
            // 
            this.cbCourseSem.FormattingEnabled = true;
            this.cbCourseSem.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbCourseSem.Location = new System.Drawing.Point(494, 155);
            this.cbCourseSem.Name = "cbCourseSem";
            this.cbCourseSem.Size = new System.Drawing.Size(194, 28);
            this.cbCourseSem.TabIndex = 12;
            // 
            // cbCourseType
            // 
            this.cbCourseType.FormattingEnabled = true;
            this.cbCourseType.Items.AddRange(new object[] {
            "Theory",
            "Lab"});
            this.cbCourseType.Location = new System.Drawing.Point(494, 89);
            this.cbCourseType.Name = "cbCourseType";
            this.cbCourseType.Size = new System.Drawing.Size(194, 28);
            this.cbCourseType.TabIndex = 13;
            // 
            // tbCourseTitle
            // 
            this.tbCourseTitle.Location = new System.Drawing.Point(494, 123);
            this.tbCourseTitle.Name = "tbCourseTitle";
            this.tbCourseTitle.Size = new System.Drawing.Size(194, 26);
            this.tbCourseTitle.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(858, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 29);
            this.label10.TabIndex = 16;
            this.label10.Text = "Student Info";
            // 
            // tbStudentName
            // 
            this.tbStudentName.Location = new System.Drawing.Point(856, 55);
            this.tbStudentName.Name = "tbStudentName";
            this.tbStudentName.Size = new System.Drawing.Size(194, 26);
            this.tbStudentName.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(799, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "Name";
            // 
            // cbStudentSem
            // 
            this.cbStudentSem.FormattingEnabled = true;
            this.cbStudentSem.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cbStudentSem.Location = new System.Drawing.Point(856, 87);
            this.cbStudentSem.Name = "cbStudentSem";
            this.cbStudentSem.Size = new System.Drawing.Size(194, 28);
            this.cbStudentSem.TabIndex = 20;
            this.cbStudentSem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sortBasedOnSem);
//            this.cbStudentSem.MouseCaptureChanged += new System.EventHandler(this.sortSem);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(772, 90);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 20);
            this.label12.TabIndex = 19;
            this.label12.Text = "Semester";
            // 
            // cbStudentCourse
            // 
            this.cbStudentCourse.FormattingEnabled = true;
            this.cbStudentCourse.Location = new System.Drawing.Point(856, 121);
            this.cbStudentCourse.Name = "cbStudentCourse";
            this.cbStudentCourse.Size = new System.Drawing.Size(194, 28);
            this.cbStudentCourse.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(772, 124);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 20);
            this.label13.TabIndex = 21;
            this.label13.Text = "Course";
            // 
            // lbTeacherInfo
            // 
            this.lbTeacherInfo.FormattingEnabled = true;
            this.lbTeacherInfo.ItemHeight = 20;
            this.lbTeacherInfo.Location = new System.Drawing.Point(16, 206);
            this.lbTeacherInfo.Name = "lbTeacherInfo";
            this.lbTeacherInfo.Size = new System.Drawing.Size(301, 184);
            this.lbTeacherInfo.TabIndex = 23;
            // 
            // lbSudentInfo
            // 
            this.lbSudentInfo.FormattingEnabled = true;
            this.lbSudentInfo.ItemHeight = 20;
            this.lbSudentInfo.Location = new System.Drawing.Point(776, 206);
            this.lbSudentInfo.Name = "lbSudentInfo";
            this.lbSudentInfo.Size = new System.Drawing.Size(301, 184);
            this.lbSudentInfo.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 25;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.addTeacher);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(576, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 26;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.addCourse);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(946, 158);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 28);
            this.button3.TabIndex = 27;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.addStudent);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(925, 396);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(152, 28);
            this.button4.TabIndex = 28;
            this.button4.Text = "Show Student Info";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.showStudent);
            // 
            // cbTeacherInfo
            // 
            this.cbTeacherInfo.FormattingEnabled = true;
            this.cbTeacherInfo.Location = new System.Drawing.Point(16, 396);
            this.cbTeacherInfo.Name = "cbTeacherInfo";
            this.cbTeacherInfo.Size = new System.Drawing.Size(143, 28);
            this.cbTeacherInfo.TabIndex = 29;
            // 
            // cbStudentInfo
            // 
            this.cbStudentInfo.FormattingEnabled = true;
            this.cbStudentInfo.Location = new System.Drawing.Point(776, 396);
            this.cbStudentInfo.Name = "cbStudentInfo";
            this.cbStudentInfo.Size = new System.Drawing.Size(143, 28);
            this.cbStudentInfo.TabIndex = 31;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(165, 396);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(152, 28);
            this.button5.TabIndex = 30;
            this.button5.Text = "Show Teacher Info";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.showTeacher);
            // 
            // tbCourseCode
            // 
            this.tbCourseCode.Location = new System.Drawing.Point(494, 57);
            this.tbCourseCode.Name = "tbCourseCode";
            this.tbCourseCode.Size = new System.Drawing.Size(194, 26);
            this.tbCourseCode.TabIndex = 32;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(70, 139);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 28);
            this.button6.TabIndex = 33;
            this.button6.Text = "Clear";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.clearTeacherInfo);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(441, 235);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 28);
            this.button7.TabIndex = 34;
            this.button7.Text = "Clear";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.clearCourseInfo);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(844, 158);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 28);
            this.button8.TabIndex = 35;
            this.button8.Text = "Clear";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.clearStudentInfo);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 450);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.tbCourseCode);
            this.Controls.Add(this.cbStudentInfo);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.cbTeacherInfo);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbSudentInfo);
            this.Controls.Add(this.lbTeacherInfo);
            this.Controls.Add(this.cbStudentCourse);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cbStudentSem);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbStudentName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbCourseTitle);
            this.Controls.Add(this.cbCourseType);
            this.Controls.Add(this.cbCourseSem);
            this.Controls.Add(this.cbCourseTeacher);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbTeacherType);
            this.Controls.Add(this.tbTeacherName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbTeacherName;
        private System.Windows.Forms.ComboBox cbTeacherType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbCourseTeacher;
        private System.Windows.Forms.ComboBox cbCourseSem;
        private System.Windows.Forms.ComboBox cbCourseType;
        private System.Windows.Forms.TextBox tbCourseTitle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbStudentName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbStudentSem;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbStudentCourse;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox lbTeacherInfo;
        private System.Windows.Forms.ListBox lbSudentInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox cbTeacherInfo;
        private System.Windows.Forms.ComboBox cbStudentInfo;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox tbCourseCode;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}

