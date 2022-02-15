using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab08_Employee_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addEmployee(object sender, EventArgs e)
        {
            if(cbAddDesignation.Text == "Manager")
            {
                Manager temp = new Manager(tbAddName.Text, tbAddContact.Text, dtAddJoin.Value, (int)numAddSalary.Value, (int)numAddLeave.Value);
                try
                {
                    if (EMS.find(temp) != null)
                    {
                        MessageBox.Show("Employee already exists.");
                        return;
                    }
                }
                catch
                {
                    temp.setID(EMS.getLastID());
                    EMS.Add(temp);
                }
            }
            else if(cbAddDesignation.Text == "Sales Person")
            {
                salesPerson temp = new salesPerson(tbAddName.Text, tbAddContact.Text, dtAddJoin.Value, (int)numAddSalary.Value, (int)numAddLeave.Value);
                try
                {
                    if (EMS.find(temp) != null)
                    {
                        MessageBox.Show("Employee already exists.");
                        return;
                    }
                }
                catch
                {
                    EMS.Add(temp);
                }
            }
            else if(cbAddDesignation.Text == "Type Writer")
            {
                typeWriter temp = new typeWriter(tbAddName.Text, tbAddContact.Text, dtAddJoin.Value, (int)numAddSalary.Value, (int)numAddLeave.Value);
                try
                {
                    if (EMS.find(temp) != null)
                    {
                        MessageBox.Show("Employee already exists.");
                        return;
                    }
                }
                catch
                {
                    EMS.Add(temp);
                }
            }
            MessageBox.Show("Employee Added with ID " + (EMS.getLastID() - 1).ToString());
        }

        private void showInfo(object sender, EventArgs e)
        {
            try
            {
                Employee temp = EMS.find(int.Parse(tbViewID.Text));
                tbViewName.Text = temp.getName();
                tbViewContact.Text = temp.getContact();
                tbViewJoin.Text = temp.getDateOfJoining().ToString();
                numViewLeave.Value = temp.getLeaves();
                if (temp.ToString() == "Lab08_Employee_Management_System.Manager")
                    tbViewDesignation.Text = "Manager";
                else if (temp.ToString() == "Lab08_Employee_Management_System.salesPerson")
                    tbViewDesignation.Text = "Sales Person";
                else if (temp.ToString() == "Lab08_Employee_Management_System.typeWriter")
                    tbViewDesignation.Text = "Type Writer";
                
                int salary = temp.getSalary();
                int diff = (int)(DateTime.Now - temp.getDateOfJoining()).TotalDays;
                for (int i = 0; i < diff / 365; i++)
                    salary += (int)(salary * temp.getBonus());
                numViewSalary.Value = salary;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearAddEmployee(object sender, EventArgs e)
        {
            tbAddName.Clear();
            tbAddContact.Clear();
            cbAddDesignation.ResetText();
            numAddLeave.Value = numAddSalary.Value = 0;
        }
    }
}
