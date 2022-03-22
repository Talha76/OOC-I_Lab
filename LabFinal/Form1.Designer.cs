namespace LabFinal
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
            this.TextboxID = new System.Windows.Forms.TextBox();
            this.idListbox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ListBoxInfo = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameListbox = new System.Windows.Forms.ListBox();
            this.percentListbox = new System.Windows.Forms.ListBox();
            this.gradeListbox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextboxID
            // 
            this.TextboxID.Location = new System.Drawing.Point(705, 18);
            this.TextboxID.Name = "TextboxID";
            this.TextboxID.Size = new System.Drawing.Size(155, 26);
            this.TextboxID.TabIndex = 0;
            // 
            // idListbox
            // 
            this.idListbox.FormattingEnabled = true;
            this.idListbox.ItemHeight = 20;
            this.idListbox.Location = new System.Drawing.Point(21, 86);
            this.idListbox.Name = "idListbox";
            this.idListbox.Size = new System.Drawing.Size(109, 404);
            this.idListbox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(728, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 61);
            this.button1.TabIndex = 2;
            this.button1.Text = "Search By ID";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.search);
            // 
            // ListBoxInfo
            // 
            this.ListBoxInfo.FormattingEnabled = true;
            this.ListBoxInfo.ItemHeight = 20;
            this.ListBoxInfo.Location = new System.Drawing.Point(661, 143);
            this.ListBoxInfo.Name = "ListBoxInfo";
            this.ListBoxInfo.Size = new System.Drawing.Size(258, 264);
            this.ListBoxInfo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(657, 434);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Designed By:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(776, 434);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "200042124";
            // 
            // nameListbox
            // 
            this.nameListbox.FormattingEnabled = true;
            this.nameListbox.ItemHeight = 20;
            this.nameListbox.Location = new System.Drawing.Point(136, 86);
            this.nameListbox.Name = "nameListbox";
            this.nameListbox.Size = new System.Drawing.Size(109, 404);
            this.nameListbox.TabIndex = 6;
            // 
            // percentListbox
            // 
            this.percentListbox.FormattingEnabled = true;
            this.percentListbox.ItemHeight = 20;
            this.percentListbox.Location = new System.Drawing.Point(251, 86);
            this.percentListbox.Name = "percentListbox";
            this.percentListbox.Size = new System.Drawing.Size(109, 404);
            this.percentListbox.TabIndex = 7;
            // 
            // gradeListbox
            // 
            this.gradeListbox.FormattingEnabled = true;
            this.gradeListbox.ItemHeight = 20;
            this.gradeListbox.Location = new System.Drawing.Point(366, 86);
            this.gradeListbox.Name = "gradeListbox";
            this.gradeListbox.Size = new System.Drawing.Size(109, 404);
            this.gradeListbox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Percentage";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(388, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Grade";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(90, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(306, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Course Name: Object Oriented Concepts I";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 510);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gradeListbox);
            this.Controls.Add(this.percentListbox);
            this.Controls.Add(this.nameListbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListBoxInfo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.idListbox);
            this.Controls.Add(this.TextboxID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextboxID;
        private System.Windows.Forms.ListBox idListbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox ListBoxInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox nameListbox;
        private System.Windows.Forms.ListBox percentListbox;
        private System.Windows.Forms.ListBox gradeListbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

