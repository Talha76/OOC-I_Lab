namespace Lab10
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
            this.findEmailTextbox = new System.Windows.Forms.TextBox();
            this.showButton = new System.Windows.Forms.Button();
            this.userInfoListbox = new System.Windows.Forms.ListBox();
            this.allUserListbox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // findEmailTextbox
            // 
            this.findEmailTextbox.Location = new System.Drawing.Point(133, 24);
            this.findEmailTextbox.Name = "findEmailTextbox";
            this.findEmailTextbox.Size = new System.Drawing.Size(295, 26);
            this.findEmailTextbox.TabIndex = 0;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(242, 65);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 32);
            this.showButton.TabIndex = 1;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showInfo);
            // 
            // userInfoListbox
            // 
            this.userInfoListbox.FormattingEnabled = true;
            this.userInfoListbox.ItemHeight = 20;
            this.userInfoListbox.Location = new System.Drawing.Point(18, 116);
            this.userInfoListbox.Name = "userInfoListbox";
            this.userInfoListbox.Size = new System.Drawing.Size(517, 264);
            this.userInfoListbox.TabIndex = 2;
            // 
            // allUserListbox
            // 
            this.allUserListbox.FormattingEnabled = true;
            this.allUserListbox.ItemHeight = 20;
            this.allUserListbox.Location = new System.Drawing.Point(541, 12);
            this.allUserListbox.Name = "allUserListbox";
            this.allUserListbox.Size = new System.Drawing.Size(685, 584);
            this.allUserListbox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 614);
            this.Controls.Add(this.allUserListbox);
            this.Controls.Add(this.userInfoListbox);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.findEmailTextbox);
            this.Name = "Form1";
            this.Text = "User Finder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox findEmailTextbox;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.ListBox userInfoListbox;
        private System.Windows.Forms.ListBox allUserListbox;
    }
}

