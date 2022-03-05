using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab10
{
    public partial class Form1 : Form
    {
        List<User> userList = new List<User>();
        public Form1()
        {
            InitializeComponent();
            using (var reader = new StreamReader(@"E:\SWE-4202-OOC-I_Lab\Lab10\userInfo.csv"))
            {
                while(!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');
                    string toAddinList = "";
                    for(int i = 0; i < 2; i++)
                    {
                        toAddinList += values[i] + " ";
                    }
                    allUserListbox.Items.Add(toAddinList);

                    User dummy = new User(values[0], values[1], values[2], values[3], values[4],
                        values[5], values[6], values[7], values[8], values[9]);
                    userList.Add(dummy);
                }
            }
        }

        private void showInfo(object sender, EventArgs e)
        {
            userInfoListbox.ResetText();

            User dummy = null;
            foreach(User user in userList)
            {
                if(user.eMail == findEmailTextbox.Text)
                    dummy = user;
            }

            string toShow = findEmailTextbox.Text + '_' + DateTime.Now.ToString() + '_';
            if (dummy == null)
            {
                toShow += "NotFound";
                MessageBox.Show("User Not found!");
            }
            else
            {
                userInfoListbox.Items.Add("Name: " + dummy.firstName + " " + dummy.lastName);
                userInfoListbox.Items.Add("Address: " + dummy.Address);
                userInfoListbox.Items.Add("City: " + dummy.City);
                userInfoListbox.Items.Add("Country: " + dummy.Country);
                userInfoListbox.Items.Add("State: " + dummy.State);
                userInfoListbox.Items.Add("Zip: " + dummy.Zip);
                userInfoListbox.Items.Add("Phone 1: " + dummy.Phone1);
                userInfoListbox.Items.Add("Phone 2: " + dummy.Phone2);
                userInfoListbox.Items.Add("Email: " + dummy.eMail);
                //userInfoListbox.Items.Add(dummy.getDetailedInfo());
                toShow += dummy.firstName + "_" + dummy.lastName + "_" + dummy.Address + "_"
                    + dummy.City + "_" + dummy.Country + "_" + dummy.State + "_" + dummy.Zip + "_"
                    + dummy.Phone1 + "_" + dummy.Phone2 + "_" + dummy.eMail;
            }
            string path = @"E:\SWE-4202-OOC-I_Lab\Lab10\search.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(toShow);
                }
            }
            else
            {
                using (StreamWriter sr = File.AppendText(path))
                {
                    sr.WriteLine(toShow);
                }
            }
        }
    }
}
