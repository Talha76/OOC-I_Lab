namespace _200042124_Lab01_Assignment
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.studentName = new System.Windows.Forms.TextBox();
            this.studentID = new System.Windows.Forms.TextBox();
            this.semester = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.attendedClasses = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.midBox = new System.Windows.Forms.TextBox();
            this.finalBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.quiz1 = new System.Windows.Forms.TextBox();
            this.quiz2 = new System.Windows.Forms.TextBox();
            this.quiz3 = new System.Windows.Forms.TextBox();
            this.quiz4 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.attendanceMark = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.midMark = new System.Windows.Forms.Label();
            this.finalMark = new System.Windows.Forms.Label();
            this.quizMark = new System.Windows.Forms.Label();
            this.totalMark = new System.Windows.Forms.Label();
            this.grade = new System.Windows.Forms.Label();
            this.finalResult = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Student ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Semester";
            // 
            // studentName
            // 
            this.studentName.Location = new System.Drawing.Point(99, 63);
            this.studentName.Name = "studentName";
            this.studentName.Size = new System.Drawing.Size(235, 26);
            this.studentName.TabIndex = 4;
            // 
            // studentID
            // 
            this.studentID.Location = new System.Drawing.Point(99, 103);
            this.studentID.Name = "studentID";
            this.studentID.Size = new System.Drawing.Size(235, 26);
            this.studentID.TabIndex = 5;
            // 
            // semester
            // 
            this.semester.Location = new System.Drawing.Point(99, 144);
            this.semester.Name = "semester";
            this.semester.Size = new System.Drawing.Size(235, 26);
            this.semester.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(448, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 68);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calculate Grade";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.calculateGrade);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Brown;
            this.label5.Location = new System.Drawing.Point(12, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(305, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "SWE 4201 OOC - I Marks";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 40);
            this.label6.TabIndex = 9;
            this.label6.Text = "No. of attended\r\nclasses (Out of 28)";
            // 
            // attendedClasses
            // 
            this.attendedClasses.Location = new System.Drawing.Point(162, 266);
            this.attendedClasses.Name = "attendedClasses";
            this.attendedClasses.Size = new System.Drawing.Size(172, 26);
            this.attendedClasses.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Mid (Out of 75)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Final (Out of 150)";
            // 
            // midBox
            // 
            this.midBox.Location = new System.Drawing.Point(162, 309);
            this.midBox.Name = "midBox";
            this.midBox.Size = new System.Drawing.Size(172, 26);
            this.midBox.TabIndex = 13;
            // 
            // finalBox
            // 
            this.finalBox.Location = new System.Drawing.Point(162, 355);
            this.finalBox.Name = "finalBox";
            this.finalBox.Size = new System.Drawing.Size(172, 26);
            this.finalBox.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(384, 272);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(130, 20);
            this.label9.TabIndex = 15;
            this.label9.Text = "Quiz I (Out of 15)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(379, 312);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 20);
            this.label10.TabIndex = 16;
            this.label10.Text = "Quiz II (Out of 15)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(374, 355);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "Quiz III (Out of 15)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(373, 393);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 20);
            this.label12.TabIndex = 18;
            this.label12.Text = "Quiz IV (Out of 15)";
            // 
            // quiz1
            // 
            this.quiz1.Location = new System.Drawing.Point(520, 269);
            this.quiz1.Name = "quiz1";
            this.quiz1.Size = new System.Drawing.Size(172, 26);
            this.quiz1.TabIndex = 19;
            // 
            // quiz2
            // 
            this.quiz2.Location = new System.Drawing.Point(520, 309);
            this.quiz2.Name = "quiz2";
            this.quiz2.Size = new System.Drawing.Size(172, 26);
            this.quiz2.TabIndex = 20;
            // 
            // quiz3
            // 
            this.quiz3.Location = new System.Drawing.Point(520, 352);
            this.quiz3.Name = "quiz3";
            this.quiz3.Size = new System.Drawing.Size(172, 26);
            this.quiz3.TabIndex = 21;
            // 
            // quiz4
            // 
            this.quiz4.Location = new System.Drawing.Point(520, 390);
            this.quiz4.Name = "quiz4";
            this.quiz4.Size = new System.Drawing.Size(172, 26);
            this.quiz4.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Location = new System.Drawing.Point(12, 195);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(680, 5);
            this.label13.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Cursor = System.Windows.Forms.Cursors.Default;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.DarkGreen;
            this.label14.Location = new System.Drawing.Point(738, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(199, 31);
            this.label14.TabIndex = 24;
            this.label14.Text = "Obtained Marks";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(734, 63);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 20);
            this.label15.TabIndex = 25;
            this.label15.Text = "Attendance:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(792, 83);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 20);
            this.label16.TabIndex = 26;
            this.label16.Text = "Mid:";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(783, 103);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 20);
            this.label17.TabIndex = 27;
            this.label17.Text = "Final:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(785, 123);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 20);
            this.label18.TabIndex = 28;
            this.label18.Text = "Quiz:";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Black;
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label19.Location = new System.Drawing.Point(734, 162);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(265, 5);
            this.label19.TabIndex = 29;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(776, 180);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(54, 20);
            this.label20.TabIndex = 30;
            this.label20.Text = "Total:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(752, 228);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(78, 25);
            this.label21.TabIndex = 31;
            this.label21.Text = "Grade:";
            // 
            // attendanceMark
            // 
            this.attendanceMark.AutoSize = true;
            this.attendanceMark.Location = new System.Drawing.Point(836, 63);
            this.attendanceMark.Name = "attendanceMark";
            this.attendanceMark.Size = new System.Drawing.Size(72, 20);
            this.attendanceMark.TabIndex = 32;
            this.attendanceMark.Text = "att_mark";
            this.attendanceMark.Visible = false;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(830, 83);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(0, 20);
            this.label22.TabIndex = 33;
            // 
            // midMark
            // 
            this.midMark.AutoSize = true;
            this.midMark.Location = new System.Drawing.Point(836, 83);
            this.midMark.Name = "midMark";
            this.midMark.Size = new System.Drawing.Size(34, 20);
            this.midMark.TabIndex = 34;
            this.midMark.Text = "mid";
            this.midMark.Visible = false;
            // 
            // finalMark
            // 
            this.finalMark.AutoSize = true;
            this.finalMark.Location = new System.Drawing.Point(836, 103);
            this.finalMark.Name = "finalMark";
            this.finalMark.Size = new System.Drawing.Size(38, 20);
            this.finalMark.TabIndex = 35;
            this.finalMark.Text = "final";
            this.finalMark.Visible = false;
            // 
            // quizMark
            // 
            this.quizMark.AutoSize = true;
            this.quizMark.Location = new System.Drawing.Point(836, 123);
            this.quizMark.Name = "quizMark";
            this.quizMark.Size = new System.Drawing.Size(38, 20);
            this.quizMark.TabIndex = 36;
            this.quizMark.Text = "quiz";
            this.quizMark.Visible = false;
            // 
            // totalMark
            // 
            this.totalMark.AutoSize = true;
            this.totalMark.Location = new System.Drawing.Point(836, 180);
            this.totalMark.Name = "totalMark";
            this.totalMark.Size = new System.Drawing.Size(40, 20);
            this.totalMark.TabIndex = 37;
            this.totalMark.Text = "total";
            this.totalMark.Visible = false;
            // 
            // grade
            // 
            this.grade.AutoSize = true;
            this.grade.BackColor = System.Drawing.SystemColors.Control;
            this.grade.CausesValidation = false;
            this.grade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grade.ForeColor = System.Drawing.Color.Red;
            this.grade.Location = new System.Drawing.Point(836, 232);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(55, 20);
            this.grade.TabIndex = 38;
            this.grade.Text = "grade";
            this.grade.Visible = false;
            // 
            // finalResult
            // 
            this.finalResult.AutoSize = true;
            this.finalResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.finalResult.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalResult.Location = new System.Drawing.Point(738, 331);
            this.finalResult.Name = "finalResult";
            this.finalResult.Size = new System.Drawing.Size(86, 24);
            this.finalResult.TabIndex = 39;
            this.finalResult.Text = "final_text";
            this.finalResult.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(711, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(4, 413);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.finalResult);
            this.Controls.Add(this.grade);
            this.Controls.Add(this.totalMark);
            this.Controls.Add(this.quizMark);
            this.Controls.Add(this.finalMark);
            this.Controls.Add(this.midMark);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.attendanceMark);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.quiz4);
            this.Controls.Add(this.quiz3);
            this.Controls.Add(this.quiz2);
            this.Controls.Add(this.quiz1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.finalBox);
            this.Controls.Add(this.midBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.attendedClasses);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.semester);
            this.Controls.Add(this.studentID);
            this.Controls.Add(this.studentName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "GradesApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox studentName;
        private System.Windows.Forms.TextBox studentID;
        private System.Windows.Forms.TextBox semester;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox attendedClasses;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox midBox;
        private System.Windows.Forms.TextBox finalBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox quiz1;
        private System.Windows.Forms.TextBox quiz2;
        private System.Windows.Forms.TextBox quiz3;
        private System.Windows.Forms.TextBox quiz4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label attendanceMark;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label midMark;
        private System.Windows.Forms.Label finalMark;
        private System.Windows.Forms.Label quizMark;
        private System.Windows.Forms.Label totalMark;
        private System.Windows.Forms.Label grade;
        private System.Windows.Forms.Label finalResult;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

