using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab08_Bank_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showInfo(object sender, EventArgs e)
        {
            try
            {
                Account temp = BMS.findAccount(int.Parse(tbInfoAccNo.Text));
                tbInfoName.Text = temp.Name;
                tbInfoAmount.Text = temp.balance.ToString();
                if (temp.ToString() == Current.ToString())
                    tbInfoType.Text = "Current";
                else if (temp.ToString() == Savings.ToString())
                    tbInfoType.Text = "Savings";
                else
                    tbInfoType.Text = "Loan";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void createAccount(object sender, EventArgs e)
        {
            Account temp;
            try
            {
                if (cbCreateType.Text == "Current Account")
                {
                    temp = new Current(BMS.getAvailableID(), tbCreateName.Text, (int)numCreateAmount.Value);
                }
                else if (cbCreateType.Text == "Savings Account")
                {
                    if (numCreateAmount.Value < Savings.minAmount)
                        throw new ApplicationException("Account must be created with at least 50,000 credit.");
                    temp = new Savings(BMS.getAvailableID(), tbCreateName.Text, (int)numCreateAmount.Value);
                }
                else if (cbCreateType.Text == "Loan Account")
                {
                    temp = new Loan(BMS.getAvailableID(), tbCreateName.Text, (int)numCreateAmount.Value);
                }
                else
                    throw new ApplicationException("Select an Account Type.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            temp.prefix();
            try
            {
                BMS.findAccount(temp);
                throw new AccountExistException();
            }
            catch (AccountExistException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch
            {
                BMS.addAccount(temp);
                MessageBox.Show("Account created with ID: " + temp.ID);
            }
        }

        private void clearCreateAccount(object sender, EventArgs e)
        {
            tbCreateName.Clear();
            cbCreateType.ResetText();
            numCreateAmount.Value = 0;
        }

        private void deposit(object sender, EventArgs e)
        {
            try
            {
                if (numAmount.Value < 0)
                    throw new ApplicationException("Amount cannot be negative.");
                BMS.findAccount(int.Parse(tbAccNo.Text)).balance += (int)numAmount.Value;
                MessageBox.Show("Deposited.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clear(object sender, EventArgs e)
        {
            tbAccNo.Clear();
            numAmount.Value = 0;
        }

        private void withdraw(object sender, EventArgs e)
        {
            try
            {
                Account a = BMS.findAccount(int.Parse(tbAccNo.Text));
                if(a.ToString() == Savings.ToString())
                {
                    Savings t = (Savings)a;
                    if (t.TrxLim == 0)
                        throw new ApplicationException("Transaction Limit has ended.");
                    t.TrxLim--;
                    a.balance -= 15;
                }
                if (a.ToString() == Loan.ToString())
                {
                    throw new ApplicationException("Loaners cannot withdraw.");
                }
                if(a.ToString() == Current.ToString() && a.balance < numAmount.Value)
                {
                    throw new ApplicationException("You cannot withdraw: Your balance will be less than 500.");
                }
                a.balance -= (int)numAmount.Value;
                MessageBox.Show("Withdrawn Successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearInfo(object sender, EventArgs e)
        {
            tbInfoAccNo.Clear();
            tbInfoName.Clear();
            tbInfoType.Clear();
            tbInfoAmount.Clear();
        }
    }
}
