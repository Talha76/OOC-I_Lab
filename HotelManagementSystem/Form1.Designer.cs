namespace HotelManagementSystem
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
            this.tbOsBookID = new System.Windows.Forms.TextBox();
            this.cbOsStatus = new System.Windows.Forms.ComboBox();
            this.lbOsBalance = new System.Windows.Forms.Label();
            this.lboxOsDetails = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbUsUserID = new System.Windows.Forms.TextBox();
            this.tbUsAddress = new System.Windows.Forms.TextBox();
            this.tbUsContactNo = new System.Windows.Forms.TextBox();
            this.tbUsName = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.tbBookUserID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbBookChoice = new System.Windows.Forms.ComboBox();
            this.tbBookQty = new System.Windows.Forms.TextBox();
            this.dtEntry = new System.Windows.Forms.DateTimePicker();
            this.dtDep = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.tbDetailsID = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.tbDetailsStatus = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbDetailsRoomNo = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbDetailsAmount = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbDetailsUserName = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tbDetailsAddress = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Owner Section";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Booking ID";
            // 
            // tbOsBookID
            // 
            this.tbOsBookID.Location = new System.Drawing.Point(106, 63);
            this.tbOsBookID.Name = "tbOsBookID";
            this.tbOsBookID.Size = new System.Drawing.Size(187, 26);
            this.tbOsBookID.TabIndex = 2;
            // 
            // cbOsStatus
            // 
            this.cbOsStatus.FormattingEnabled = true;
            this.cbOsStatus.Items.AddRange(new object[] {
            "Pending",
            "Confirmed"});
            this.cbOsStatus.Location = new System.Drawing.Point(106, 96);
            this.cbOsStatus.Name = "cbOsStatus";
            this.cbOsStatus.Size = new System.Drawing.Size(187, 28);
            this.cbOsStatus.TabIndex = 3;
            // 
            // lbOsBalance
            // 
            this.lbOsBalance.AutoSize = true;
            this.lbOsBalance.Location = new System.Drawing.Point(25, 157);
            this.lbOsBalance.Name = "lbOsBalance";
            this.lbOsBalance.Size = new System.Drawing.Size(141, 20);
            this.lbOsBalance.TabIndex = 4;
            this.lbOsBalance.Text = "Current Balance: 0";
            // 
            // lboxOsDetails
            // 
            this.lboxOsDetails.FormattingEnabled = true;
            this.lboxOsDetails.ItemHeight = 20;
            this.lboxOsDetails.Items.AddRange(new object[] {
            "RoomType\tQuantity\tAmount\tStatus"});
            this.lboxOsDetails.Location = new System.Drawing.Point(12, 194);
            this.lboxOsDetails.Name = "lboxOsDetails";
            this.lboxOsDetails.Size = new System.Drawing.Size(446, 204);
            this.lboxOsDetails.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 59);
            this.button1.TabIndex = 6;
            this.button1.Text = "Set Status";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.setStatus);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(464, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(5, 619);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(73, 428);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(324, 40);
            this.button2.TabIndex = 8;
            this.button2.Text = "Show Room Details";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.showRoomDetails);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(743, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 48);
            this.label4.TabIndex = 9;
            this.label4.Text = "User Section";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(507, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "User ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(520, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(482, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Contact No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(503, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Address";
            // 
            // tbUsUserID
            // 
            this.tbUsUserID.Location = new System.Drawing.Point(577, 63);
            this.tbUsUserID.Name = "tbUsUserID";
            this.tbUsUserID.Size = new System.Drawing.Size(227, 26);
            this.tbUsUserID.TabIndex = 14;
            // 
            // tbUsAddress
            // 
            this.tbUsAddress.Location = new System.Drawing.Point(577, 185);
            this.tbUsAddress.Name = "tbUsAddress";
            this.tbUsAddress.Size = new System.Drawing.Size(227, 26);
            this.tbUsAddress.TabIndex = 15;
            // 
            // tbUsContactNo
            // 
            this.tbUsContactNo.Location = new System.Drawing.Point(577, 143);
            this.tbUsContactNo.Name = "tbUsContactNo";
            this.tbUsContactNo.Size = new System.Drawing.Size(227, 26);
            this.tbUsContactNo.TabIndex = 16;
            // 
            // tbUsName
            // 
            this.tbUsName.Location = new System.Drawing.Point(577, 101);
            this.tbUsName.Name = "tbUsName";
            this.tbUsName.Size = new System.Drawing.Size(227, 26);
            this.tbUsName.TabIndex = 17;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(553, 232);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(199, 40);
            this.button3.TabIndex = 18;
            this.button3.Text = "Create Account";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.createAccount);
            // 
            // tbBookUserID
            // 
            this.tbBookUserID.Location = new System.Drawing.Point(962, 63);
            this.tbBookUserID.Name = "tbBookUserID";
            this.tbBookUserID.Size = new System.Drawing.Size(227, 26);
            this.tbBookUserID.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(892, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "User ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(851, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Room Choice";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(888, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Quantity";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(871, 185);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "Entry Date";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(836, 222);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 20);
            this.label13.TabIndex = 24;
            this.label13.Text = "Departure Date";
            // 
            // cbBookChoice
            // 
            this.cbBookChoice.FormattingEnabled = true;
            this.cbBookChoice.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Deluxe",
            "Suit"});
            this.cbBookChoice.Location = new System.Drawing.Point(962, 101);
            this.cbBookChoice.Name = "cbBookChoice";
            this.cbBookChoice.Size = new System.Drawing.Size(227, 28);
            this.cbBookChoice.TabIndex = 25;
            // 
            // tbBookQty
            // 
            this.tbBookQty.Location = new System.Drawing.Point(962, 146);
            this.tbBookQty.Name = "tbBookQty";
            this.tbBookQty.Size = new System.Drawing.Size(227, 26);
            this.tbBookQty.TabIndex = 26;
            // 
            // dtEntry
            // 
            this.dtEntry.Location = new System.Drawing.Point(962, 185);
            this.dtEntry.Name = "dtEntry";
            this.dtEntry.Size = new System.Drawing.Size(227, 26);
            this.dtEntry.TabIndex = 27;
            // 
            // dtDep
            // 
            this.dtDep.Location = new System.Drawing.Point(962, 222);
            this.dtDep.Name = "dtDep";
            this.dtDep.Size = new System.Drawing.Size(227, 26);
            this.dtDep.TabIndex = 28;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(908, 263);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(199, 40);
            this.button4.TabIndex = 29;
            this.button4.Text = "Place Booking";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.placeBooking);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox2.Location = new System.Drawing.Point(820, 48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(5, 299);
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox3.Location = new System.Drawing.Point(464, 342);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(741, 5);
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            // 
            // tbDetailsID
            // 
            this.tbDetailsID.Location = new System.Drawing.Point(577, 409);
            this.tbDetailsID.Name = "tbDetailsID";
            this.tbDetailsID.Size = new System.Drawing.Size(187, 26);
            this.tbDetailsID.TabIndex = 33;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(483, 412);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 20);
            this.label14.TabIndex = 32;
            this.label14.Text = "Booking ID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Uighur", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(743, 350);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(184, 48);
            this.label15.TabIndex = 34;
            this.label15.Text = "Order Details";
            // 
            // tbDetailsStatus
            // 
            this.tbDetailsStatus.Location = new System.Drawing.Point(577, 442);
            this.tbDetailsStatus.Name = "tbDetailsStatus";
            this.tbDetailsStatus.ReadOnly = true;
            this.tbDetailsStatus.Size = new System.Drawing.Size(187, 26);
            this.tbDetailsStatus.TabIndex = 36;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(515, 445);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 20);
            this.label16.TabIndex = 35;
            this.label16.Text = "Status";
            // 
            // tbDetailsRoomNo
            // 
            this.tbDetailsRoomNo.Location = new System.Drawing.Point(577, 474);
            this.tbDetailsRoomNo.Name = "tbDetailsRoomNo";
            this.tbDetailsRoomNo.ReadOnly = true;
            this.tbDetailsRoomNo.Size = new System.Drawing.Size(187, 26);
            this.tbDetailsRoomNo.TabIndex = 38;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(495, 477);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 20);
            this.label17.TabIndex = 37;
            this.label17.Text = "Room No";
            // 
            // tbDetailsAmount
            // 
            this.tbDetailsAmount.Location = new System.Drawing.Point(577, 506);
            this.tbDetailsAmount.Name = "tbDetailsAmount";
            this.tbDetailsAmount.ReadOnly = true;
            this.tbDetailsAmount.Size = new System.Drawing.Size(187, 26);
            this.tbDetailsAmount.TabIndex = 40;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(503, 509);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 20);
            this.label18.TabIndex = 39;
            this.label18.Text = "Amount";
            // 
            // tbDetailsUserName
            // 
            this.tbDetailsUserName.Location = new System.Drawing.Point(1002, 409);
            this.tbDetailsUserName.Name = "tbDetailsUserName";
            this.tbDetailsUserName.ReadOnly = true;
            this.tbDetailsUserName.Size = new System.Drawing.Size(187, 26);
            this.tbDetailsUserName.TabIndex = 42;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(907, 412);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(89, 20);
            this.label19.TabIndex = 41;
            this.label19.Text = "User Name";
            // 
            // tbDetailsAddress
            // 
            this.tbDetailsAddress.Location = new System.Drawing.Point(1002, 441);
            this.tbDetailsAddress.Name = "tbDetailsAddress";
            this.tbDetailsAddress.ReadOnly = true;
            this.tbDetailsAddress.Size = new System.Drawing.Size(187, 26);
            this.tbDetailsAddress.TabIndex = 44;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(928, 444);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(68, 20);
            this.label20.TabIndex = 43;
            this.label20.Text = "Address";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(751, 555);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(176, 40);
            this.button5.TabIndex = 45;
            this.button5.Text = "Show Booking Details";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.showBookingDetails);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 639);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.tbDetailsAddress);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.tbDetailsUserName);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.tbDetailsAmount);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.tbDetailsRoomNo);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.tbDetailsStatus);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tbDetailsID);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.dtDep);
            this.Controls.Add(this.dtEntry);
            this.Controls.Add(this.tbBookQty);
            this.Controls.Add(this.cbBookChoice);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbBookUserID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tbUsName);
            this.Controls.Add(this.tbUsContactNo);
            this.Controls.Add(this.tbUsAddress);
            this.Controls.Add(this.tbUsUserID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lboxOsDetails);
            this.Controls.Add(this.lbOsBalance);
            this.Controls.Add(this.cbOsStatus);
            this.Controls.Add(this.tbOsBookID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbOsBookID;
        private System.Windows.Forms.ComboBox cbOsStatus;
        private System.Windows.Forms.Label lbOsBalance;
        private System.Windows.Forms.ListBox lboxOsDetails;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbUsUserID;
        private System.Windows.Forms.TextBox tbUsAddress;
        private System.Windows.Forms.TextBox tbUsContactNo;
        private System.Windows.Forms.TextBox tbUsName;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbBookUserID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbBookChoice;
        private System.Windows.Forms.TextBox tbBookQty;
        private System.Windows.Forms.DateTimePicker dtEntry;
        private System.Windows.Forms.DateTimePicker dtDep;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox tbDetailsID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbDetailsStatus;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbDetailsRoomNo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbDetailsAmount;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbDetailsUserName;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbDetailsAddress;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button button5;
    }
}

