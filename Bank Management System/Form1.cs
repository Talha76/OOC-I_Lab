using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void createAccount(object sender, EventArgs e)
        {
            Current temp = new Current(tbCreateName.Text, (int)numCreateAmount.Value);
            Bank.accountList.Add(temp);
        }

        private void makeChange(object sender, EventArgs e)
        {
            
        }

        private void showInfo(object sender, EventArgs e)
        {
            try
            {
                for(int i = 0; i < Bank.accountList.Count; i++)
                {
                    if(i == int.Parse(tbInfoAcc.Text))
                    {
                        tbInfoName.Text = Bank.accountList[i].getName();
                        tbInfoBalance.Text = Bank.accountList[i].getBalance().ToString();
                        tbInfoType.Text = Bank.accountList[i].ToString();
                        return;
                    }
                }
                throw new ApplicationException("Account not found!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void showStatus(object sender, EventArgs e)
        {

        }
    }
}
