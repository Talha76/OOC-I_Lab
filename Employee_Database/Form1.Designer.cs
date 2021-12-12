namespace Employee_Database
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
            this.Student_ID_textbox = new System.Windows.Forms.TextBox();
            this.Student_Name_textbox = new System.Windows.Forms.TextBox();
            this.Student_dept_textbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.student_listbox = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Teacher_name_textbox = new System.Windows.Forms.TextBox();
            this.Teacher_ID_textbox = new System.Windows.Forms.TextBox();
            this.Teacher_dept_textbox = new System.Windows.Forms.TextBox();
            this.Teacher_designation_textbox = new System.Windows.Forms.TextBox();
            this.Teacher_salaray_textbox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Teacher_listbox = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Student_semester_textbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Student Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Department";
            // 
            // Student_ID_textbox
            // 
            this.Student_ID_textbox.Location = new System.Drawing.Point(131, 10);
            this.Student_ID_textbox.Name = "Student_ID_textbox";
            this.Student_ID_textbox.Size = new System.Drawing.Size(220, 26);
            this.Student_ID_textbox.TabIndex = 3;
            // 
            // Student_Name_textbox
            // 
            this.Student_Name_textbox.Location = new System.Drawing.Point(131, 49);
            this.Student_Name_textbox.Name = "Student_Name_textbox";
            this.Student_Name_textbox.Size = new System.Drawing.Size(220, 26);
            this.Student_Name_textbox.TabIndex = 4;
            // 
            // Student_dept_textbox
            // 
            this.Student_dept_textbox.Location = new System.Drawing.Point(131, 91);
            this.Student_dept_textbox.Name = "Student_dept_textbox";
            this.Student_dept_textbox.Size = new System.Drawing.Size(220, 26);
            this.Student_dept_textbox.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 6;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Student_Clear_Info);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(219, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 7;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Student_Save_Info);
            // 
            // student_listbox
            // 
            this.student_listbox.FormattingEnabled = true;
            this.student_listbox.ItemHeight = 20;
            this.student_listbox.Location = new System.Drawing.Point(16, 315);
            this.student_listbox.Name = "student_listbox";
            this.student_listbox.Size = new System.Drawing.Size(335, 224);
            this.student_listbox.TabIndex = 8;
            this.student_listbox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(369, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(5, 530);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Teacher ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(407, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Teacher Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(407, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Department";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(407, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Designation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(407, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Salary";
            // 
            // Teacher_name_textbox
            // 
            this.Teacher_name_textbox.Location = new System.Drawing.Point(526, 49);
            this.Teacher_name_textbox.Name = "Teacher_name_textbox";
            this.Teacher_name_textbox.Size = new System.Drawing.Size(220, 26);
            this.Teacher_name_textbox.TabIndex = 15;
            // 
            // Teacher_ID_textbox
            // 
            this.Teacher_ID_textbox.Location = new System.Drawing.Point(526, 10);
            this.Teacher_ID_textbox.Name = "Teacher_ID_textbox";
            this.Teacher_ID_textbox.Size = new System.Drawing.Size(220, 26);
            this.Teacher_ID_textbox.TabIndex = 16;
            // 
            // Teacher_dept_textbox
            // 
            this.Teacher_dept_textbox.Location = new System.Drawing.Point(526, 91);
            this.Teacher_dept_textbox.Name = "Teacher_dept_textbox";
            this.Teacher_dept_textbox.Size = new System.Drawing.Size(220, 26);
            this.Teacher_dept_textbox.TabIndex = 17;
            // 
            // Teacher_designation_textbox
            // 
            this.Teacher_designation_textbox.Location = new System.Drawing.Point(526, 134);
            this.Teacher_designation_textbox.Name = "Teacher_designation_textbox";
            this.Teacher_designation_textbox.Size = new System.Drawing.Size(220, 26);
            this.Teacher_designation_textbox.TabIndex = 18;
            // 
            // Teacher_salaray_textbox
            // 
            this.Teacher_salaray_textbox.Location = new System.Drawing.Point(526, 175);
            this.Teacher_salaray_textbox.Name = "Teacher_salaray_textbox";
            this.Teacher_salaray_textbox.Size = new System.Drawing.Size(220, 26);
            this.Teacher_salaray_textbox.TabIndex = 19;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(455, 236);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 32);
            this.button3.TabIndex = 20;
            this.button3.Text = "Clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Teacher_clear_info);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(607, 236);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 32);
            this.button4.TabIndex = 21;
            this.button4.Text = "Save";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Teacher_save_info);
            // 
            // Teacher_listbox
            // 
            this.Teacher_listbox.FormattingEnabled = true;
            this.Teacher_listbox.ItemHeight = 20;
            this.Teacher_listbox.Location = new System.Drawing.Point(411, 315);
            this.Teacher_listbox.Name = "Teacher_listbox";
            this.Teacher_listbox.Size = new System.Drawing.Size(453, 224);
            this.Teacher_listbox.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 20);
            this.label9.TabIndex = 23;
            this.label9.Text = "Semester";
            // 
            // Student_semester_textbox
            // 
            this.Student_semester_textbox.Location = new System.Drawing.Point(131, 137);
            this.Student_semester_textbox.Name = "Student_semester_textbox";
            this.Student_semester_textbox.Size = new System.Drawing.Size(220, 26);
            this.Student_semester_textbox.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 565);
            this.Controls.Add(this.Student_semester_textbox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Teacher_listbox);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Teacher_salaray_textbox);
            this.Controls.Add(this.Teacher_designation_textbox);
            this.Controls.Add(this.Teacher_dept_textbox);
            this.Controls.Add(this.Teacher_ID_textbox);
            this.Controls.Add(this.Teacher_name_textbox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.student_listbox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Student_dept_textbox);
            this.Controls.Add(this.Student_Name_textbox);
            this.Controls.Add(this.Student_ID_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Student_ID_textbox;
        private System.Windows.Forms.TextBox Student_Name_textbox;
        private System.Windows.Forms.TextBox Student_dept_textbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox student_listbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Teacher_name_textbox;
        private System.Windows.Forms.TextBox Teacher_ID_textbox;
        private System.Windows.Forms.TextBox Teacher_dept_textbox;
        private System.Windows.Forms.TextBox Teacher_designation_textbox;
        private System.Windows.Forms.TextBox Teacher_salaray_textbox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox Teacher_listbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Student_semester_textbox;
    }
}

