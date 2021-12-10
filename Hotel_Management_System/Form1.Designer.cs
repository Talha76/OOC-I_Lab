namespace WindowsFormsApp1
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
            this.tb_single_room = new System.Windows.Forms.TextBox();
            this.tb_double_room = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_rent_quantity = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_room_history = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_single_fridge = new System.Windows.Forms.TextBox();
            this.tb_single_qty = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tb_double_tv = new System.Windows.Forms.TextBox();
            this.tb_double_fridge = new System.Windows.Forms.TextBox();
            this.tb_double_qty = new System.Windows.Forms.TextBox();
            this.cb_double_ac = new System.Windows.Forms.ComboBox();
            this.cb_single_ac = new System.Windows.Forms.ComboBox();
            this.tb_single_tv = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_single_gaming = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cb_double_breakfast = new System.Windows.Forms.ComboBox();
            this.cb_double_xtra_tv = new System.Windows.Forms.ComboBox();
            this.cb_package = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add single room";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Room type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(177, 325);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Add double room";
            // 
            // tb_single_room
            // 
            this.tb_single_room.Location = new System.Drawing.Point(222, 54);
            this.tb_single_room.Name = "tb_single_room";
            this.tb_single_room.Size = new System.Drawing.Size(210, 26);
            this.tb_single_room.TabIndex = 4;
            // 
            // tb_double_room
            // 
            this.tb_double_room.Location = new System.Drawing.Point(222, 376);
            this.tb_double_room.Name = "tb_double_room";
            this.tb_double_room.Size = new System.Drawing.Size(210, 26);
            this.tb_double_room.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 284);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.add_single_room);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(306, 629);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 30);
            this.button2.TabIndex = 7;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.add_double_room);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(625, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rent a room";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(559, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Package name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(606, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Quantity:";
            // 
            // tb_rent_quantity
            // 
            this.tb_rent_quantity.Location = new System.Drawing.Point(684, 91);
            this.tb_rent_quantity.Name = "tb_rent_quantity";
            this.tb_rent_quantity.Size = new System.Drawing.Size(210, 26);
            this.tb_rent_quantity.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(730, 135);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 30);
            this.button3.TabIndex = 13;
            this.button3.Text = "Rent";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.rent_room);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(625, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 29);
            this.label8.TabIndex = 14;
            this.label8.Text = "Room history";
            // 
            // tb_room_history
            // 
            this.tb_room_history.Location = new System.Drawing.Point(684, 281);
            this.tb_room_history.Name = "tb_room_history";
            this.tb_room_history.Size = new System.Drawing.Size(210, 26);
            this.tb_room_history.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(559, 284);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Package name:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(730, 327);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 30);
            this.button4.TabIndex = 17;
            this.button4.Text = "Show";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(118, 122);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = "Refrigerator:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(144, 190);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 20);
            this.label13.TabIndex = 22;
            this.label13.Text = "Quantity:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(113, 155);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(103, 20);
            this.label14.TabIndex = 23;
            this.label14.Text = "Air Condition:";
            // 
            // tb_single_fridge
            // 
            this.tb_single_fridge.Location = new System.Drawing.Point(222, 122);
            this.tb_single_fridge.Name = "tb_single_fridge";
            this.tb_single_fridge.Size = new System.Drawing.Size(210, 26);
            this.tb_single_fridge.TabIndex = 25;
            // 
            // tb_single_qty
            // 
            this.tb_single_qty.Location = new System.Drawing.Point(222, 190);
            this.tb_single_qty.Name = "tb_single_qty";
            this.tb_single_qty.Size = new System.Drawing.Size(210, 26);
            this.tb_single_qty.TabIndex = 27;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(113, 474);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 20);
            this.label16.TabIndex = 34;
            this.label16.Text = "Air Condition:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(144, 509);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(72, 20);
            this.label17.TabIndex = 33;
            this.label17.Text = "Quantity:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(118, 441);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(98, 20);
            this.label18.TabIndex = 32;
            this.label18.Text = "Refrigerator:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(183, 410);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(33, 20);
            this.label19.TabIndex = 31;
            this.label19.Text = "TV:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(126, 376);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(90, 20);
            this.label20.TabIndex = 30;
            this.label20.Text = "Room type:";
            // 
            // tb_double_tv
            // 
            this.tb_double_tv.Location = new System.Drawing.Point(222, 410);
            this.tb_double_tv.Name = "tb_double_tv";
            this.tb_double_tv.Size = new System.Drawing.Size(210, 26);
            this.tb_double_tv.TabIndex = 35;
            // 
            // tb_double_fridge
            // 
            this.tb_double_fridge.Location = new System.Drawing.Point(222, 442);
            this.tb_double_fridge.Name = "tb_double_fridge";
            this.tb_double_fridge.Size = new System.Drawing.Size(210, 26);
            this.tb_double_fridge.TabIndex = 36;
            // 
            // tb_double_qty
            // 
            this.tb_double_qty.Location = new System.Drawing.Point(222, 506);
            this.tb_double_qty.Name = "tb_double_qty";
            this.tb_double_qty.Size = new System.Drawing.Size(210, 26);
            this.tb_double_qty.TabIndex = 38;
            // 
            // cb_double_ac
            // 
            this.cb_double_ac.FormattingEnabled = true;
            this.cb_double_ac.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cb_double_ac.Location = new System.Drawing.Point(222, 472);
            this.cb_double_ac.Name = "cb_double_ac";
            this.cb_double_ac.Size = new System.Drawing.Size(210, 28);
            this.cb_double_ac.TabIndex = 39;
            // 
            // cb_single_ac
            // 
            this.cb_single_ac.FormattingEnabled = true;
            this.cb_single_ac.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cb_single_ac.Location = new System.Drawing.Point(222, 155);
            this.cb_single_ac.Name = "cb_single_ac";
            this.cb_single_ac.Size = new System.Drawing.Size(210, 28);
            this.cb_single_ac.TabIndex = 40;
            // 
            // tb_single_tv
            // 
            this.tb_single_tv.Location = new System.Drawing.Point(222, 88);
            this.tb_single_tv.Name = "tb_single_tv";
            this.tb_single_tv.Size = new System.Drawing.Size(210, 26);
            this.tb_single_tv.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(183, 91);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "TV:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 41;
            this.label4.Text = "Gaming:";
            // 
            // cb_single_gaming
            // 
            this.cb_single_gaming.FormattingEnabled = true;
            this.cb_single_gaming.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cb_single_gaming.Location = new System.Drawing.Point(222, 226);
            this.cb_single_gaming.Name = "cb_single_gaming";
            this.cb_single_gaming.Size = new System.Drawing.Size(210, 28);
            this.cb_single_gaming.TabIndex = 42;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(142, 544);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 20);
            this.label12.TabIndex = 43;
            this.label12.Text = "Extra TV:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(25, 576);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(191, 20);
            this.label15.TabIndex = 45;
            this.label15.Text = "Complimentary Breakfast:";
            // 
            // cb_double_breakfast
            // 
            this.cb_double_breakfast.FormattingEnabled = true;
            this.cb_double_breakfast.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cb_double_breakfast.Location = new System.Drawing.Point(222, 573);
            this.cb_double_breakfast.Name = "cb_double_breakfast";
            this.cb_double_breakfast.Size = new System.Drawing.Size(210, 28);
            this.cb_double_breakfast.TabIndex = 46;
            // 
            // cb_double_xtra_tv
            // 
            this.cb_double_xtra_tv.FormattingEnabled = true;
            this.cb_double_xtra_tv.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cb_double_xtra_tv.Location = new System.Drawing.Point(222, 538);
            this.cb_double_xtra_tv.Name = "cb_double_xtra_tv";
            this.cb_double_xtra_tv.Size = new System.Drawing.Size(210, 28);
            this.cb_double_xtra_tv.TabIndex = 47;
            // 
            // cb_package
            // 
            this.cb_package.FormattingEnabled = true;
            this.cb_package.Location = new System.Drawing.Point(684, 54);
            this.cb_package.Name = "cb_package";
            this.cb_package.Size = new System.Drawing.Size(210, 28);
            this.cb_package.TabIndex = 48;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(182, 281);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 30);
            this.button5.TabIndex = 49;
            this.button5.Text = "Clear";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.clear_single_room);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(182, 629);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 30);
            this.button6.TabIndex = 50;
            this.button6.Text = "Clear";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.clear_double_room);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(610, 135);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 30);
            this.button7.TabIndex = 51;
            this.button7.Text = "Clear";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.clear_rent);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(610, 327);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 30);
            this.button8.TabIndex = 52;
            this.button8.Text = "Clear";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.clear_history);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 693);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.cb_package);
            this.Controls.Add(this.cb_double_xtra_tv);
            this.Controls.Add(this.cb_double_breakfast);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cb_single_gaming);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb_single_ac);
            this.Controls.Add(this.cb_double_ac);
            this.Controls.Add(this.tb_double_qty);
            this.Controls.Add(this.tb_double_fridge);
            this.Controls.Add(this.tb_double_tv);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.tb_single_qty);
            this.Controls.Add(this.tb_single_fridge);
            this.Controls.Add(this.tb_single_tv);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_room_history);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tb_rent_quantity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_double_room);
            this.Controls.Add(this.tb_single_room);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_single_room;
        private System.Windows.Forms.TextBox tb_double_room;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_rent_quantity;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_room_history;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_single_fridge;
        private System.Windows.Forms.TextBox tb_single_qty;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tb_double_tv;
        private System.Windows.Forms.TextBox tb_double_fridge;
        private System.Windows.Forms.TextBox tb_double_qty;
        private System.Windows.Forms.ComboBox cb_double_ac;
        private System.Windows.Forms.ComboBox cb_single_ac;
        private System.Windows.Forms.TextBox tb_single_tv;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_single_gaming;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cb_double_breakfast;
        private System.Windows.Forms.ComboBox cb_double_xtra_tv;
        private System.Windows.Forms.ComboBox cb_package;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}

