namespace Bank_Management_System
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
            System.Windows.Forms.ComboBox cbCreateType;
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbCreateName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rbDepo = new System.Windows.Forms.RadioButton();
            this.rbWithdraw = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.tbChangeAcc = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbInfoAcc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbInfoName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbInfoType = new System.Windows.Forms.TextBox();
            this.tbInfoBalance = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tbStatusAcc = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.rbCreateDeposit = new System.Windows.Forms.RadioButton();
            this.rbCreateLoan = new System.Windows.Forms.RadioButton();
            this.numCreateAmount = new System.Windows.Forms.NumericUpDown();
            cbCreateType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCreateAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCreateType
            // 
            cbCreateType.FormattingEnabled = true;
            cbCreateType.Items.AddRange(new object[] {
            "Current Account",
            "Savings Account",
            "Loan Account"});
            cbCreateType.Location = new System.Drawing.Point(124, 77);
            cbCreateType.Name = "cbCreateType";
            cbCreateType.Size = new System.Drawing.Size(160, 28);
            cbCreateType.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Account Type";
            // 
            // tbCreateName
            // 
            this.tbCreateName.Location = new System.Drawing.Point(124, 45);
            this.tbCreateName.Name = "tbCreateName";
            this.tbCreateName.Size = new System.Drawing.Size(160, 26);
            this.tbCreateName.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.createAccount);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(328, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(5, 172);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(440, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Deposit / Withdraw";
            // 
            // rbDepo
            // 
            this.rbDepo.AutoSize = true;
            this.rbDepo.Location = new System.Drawing.Point(498, 80);
            this.rbDepo.Name = "rbDepo";
            this.rbDepo.Size = new System.Drawing.Size(89, 24);
            this.rbDepo.TabIndex = 8;
            this.rbDepo.TabStop = true;
            this.rbDepo.Text = "Deposit";
            this.rbDepo.UseVisualStyleBackColor = true;
            // 
            // rbWithdraw
            // 
            this.rbWithdraw.AutoSize = true;
            this.rbWithdraw.Location = new System.Drawing.Point(498, 111);
            this.rbWithdraw.Name = "rbWithdraw";
            this.rbWithdraw.Size = new System.Drawing.Size(100, 24);
            this.rbWithdraw.TabIndex = 9;
            this.rbWithdraw.TabStop = true;
            this.rbWithdraw.Text = "Withdraw";
            this.rbWithdraw.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Account No.";
            // 
            // tbChangeAcc
            // 
            this.tbChangeAcc.Location = new System.Drawing.Point(472, 45);
            this.tbChangeAcc.Name = "tbChangeAcc";
            this.tbChangeAcc.Size = new System.Drawing.Size(249, 26);
            this.tbChangeAcc.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(472, 142);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 36);
            this.button2.TabIndex = 12;
            this.button2.Text = "Make Change";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.makeChange);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Location = new System.Drawing.Point(16, 182);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(705, 5);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(66, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(223, 29);
            this.label6.TabIndex = 15;
            this.label6.Text = "Check Information";
            // 
            // tbInfoAcc
            // 
            this.tbInfoAcc.Location = new System.Drawing.Point(114, 249);
            this.tbInfoAcc.Name = "tbInfoAcc";
            this.tbInfoAcc.Size = new System.Drawing.Size(219, 26);
            this.tbInfoAcc.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Account No.";
            // 
            // tbInfoName
            // 
            this.tbInfoName.Location = new System.Drawing.Point(114, 283);
            this.tbInfoName.Name = "tbInfoName";
            this.tbInfoName.ReadOnly = true;
            this.tbInfoName.Size = new System.Drawing.Size(219, 26);
            this.tbInfoName.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 286);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Account Type";
            // 
            // tbInfoType
            // 
            this.tbInfoType.Location = new System.Drawing.Point(114, 317);
            this.tbInfoType.Name = "tbInfoType";
            this.tbInfoType.ReadOnly = true;
            this.tbInfoType.Size = new System.Drawing.Size(219, 26);
            this.tbInfoType.TabIndex = 21;
            // 
            // tbInfoBalance
            // 
            this.tbInfoBalance.Location = new System.Drawing.Point(114, 351);
            this.tbInfoBalance.Name = "tbInfoBalance";
            this.tbInfoBalance.ReadOnly = true;
            this.tbInfoBalance.Size = new System.Drawing.Size(219, 26);
            this.tbInfoBalance.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 354);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 20);
            this.label10.TabIndex = 22;
            this.label10.Text = "Balance";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(114, 392);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 36);
            this.button4.TabIndex = 25;
            this.button4.Text = "Show";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.showInfo);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(440, 212);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(209, 29);
            this.label11.TabIndex = 26;
            this.label11.Text = "Statement Status";
            // 
            // tbStatusAcc
            // 
            this.tbStatusAcc.Location = new System.Drawing.Point(472, 249);
            this.tbStatusAcc.Name = "tbStatusAcc";
            this.tbStatusAcc.Size = new System.Drawing.Size(219, 26);
            this.tbStatusAcc.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(370, 252);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "Account No.";
            // 
            // lbStatus
            // 
            this.lbStatus.FormattingEnabled = true;
            this.lbStatus.ItemHeight = 20;
            this.lbStatus.Location = new System.Drawing.Point(374, 293);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(317, 84);
            this.lbStatus.TabIndex = 29;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(483, 392);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 36);
            this.button3.TabIndex = 30;
            this.button3.Text = "Show";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.showStatus);
            // 
            // rbCreateDeposit
            // 
            this.rbCreateDeposit.AutoSize = true;
            this.rbCreateDeposit.Location = new System.Drawing.Point(12, 111);
            this.rbCreateDeposit.Name = "rbCreateDeposit";
            this.rbCreateDeposit.Size = new System.Drawing.Size(89, 24);
            this.rbCreateDeposit.TabIndex = 32;
            this.rbCreateDeposit.TabStop = true;
            this.rbCreateDeposit.Text = "Deposit";
            this.rbCreateDeposit.UseVisualStyleBackColor = true;
            // 
            // rbCreateLoan
            // 
            this.rbCreateLoan.AutoSize = true;
            this.rbCreateLoan.Location = new System.Drawing.Point(108, 112);
            this.rbCreateLoan.Name = "rbCreateLoan";
            this.rbCreateLoan.Size = new System.Drawing.Size(70, 24);
            this.rbCreateLoan.TabIndex = 33;
            this.rbCreateLoan.TabStop = true;
            this.rbCreateLoan.Text = "Loan";
            this.rbCreateLoan.UseVisualStyleBackColor = true;
            // 
            // numCreateAmount
            // 
            this.numCreateAmount.Location = new System.Drawing.Point(185, 112);
            this.numCreateAmount.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.numCreateAmount.Name = "numCreateAmount";
            this.numCreateAmount.Size = new System.Drawing.Size(120, 26);
            this.numCreateAmount.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 450);
            this.Controls.Add(this.numCreateAmount);
            this.Controls.Add(this.rbCreateLoan);
            this.Controls.Add(this.rbCreateDeposit);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.tbStatusAcc);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tbInfoBalance);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbInfoType);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbInfoName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbInfoAcc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbChangeAcc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbWithdraw);
            this.Controls.Add(this.rbDepo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(cbCreateType);
            this.Controls.Add(this.tbCreateName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank System";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCreateAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbCreateName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbDepo;
        private System.Windows.Forms.RadioButton rbWithdraw;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbChangeAcc;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbInfoAcc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbInfoName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbInfoType;
        private System.Windows.Forms.TextBox tbInfoBalance;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbStatusAcc;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox lbStatus;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton rbCreateDeposit;
        private System.Windows.Forms.RadioButton rbCreateLoan;
        private System.Windows.Forms.NumericUpDown numCreateAmount;
    }
}

