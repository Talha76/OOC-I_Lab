using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int balance = 0;
        List<Medicine> medicine_list = new List<Medicine>();

        // Save Medicine
        private void save_medicine(object sender, EventArgs e)
        {
            if(tb_mfg_name.Text == "" || tb_mfg_company.Text == "" || tb_mfg_date.Text == "" || tb_exp_date.Text == "" || tb_price.Text == "" || tb_mfg_qty.Text == "")
            {
                MessageBox.Show("Please fill up the fields.");
                return;
            }
            Medicine temp = new Medicine(tb_mfg_name.Text, tb_mfg_company.Text, tb_mfg_date.Text, tb_exp_date.Text, tb_price.Text, tb_mfg_qty.Text);

            if(temp.get_total_price() > balance)
            {
                MessageBox.Show("Not enough money available.");
                return;
            }

            balance -= temp.get_total_price();
            foreach (Medicine i in medicine_list)
            {
                if (i.get_name() == temp.get_name())
                {
                    i.set_count(i.get_count() + temp.get_count());
                    MessageBox.Show("You added " + tb_mfg_qty.Text + " " + tb_mfg_name.Text + " medicines of " + temp.get_total_price().ToString() + " Tk.");

                    return;
                }
            }

            medicine_list.Add(temp);
            cb_sell_name.Items.Add(temp.get_name());
            tb_history_name.Items.Add(temp.get_name());
            MessageBox.Show("Saved Successfully.");
        }

        // Clear Add Medicine
        private void clear_medicine(object sender, EventArgs e)
        {
            tb_mfg_name.Clear();
            tb_mfg_company.Clear();
            tb_mfg_date.ResetText();
            tb_exp_date.ResetText();
            tb_price.Clear();
            tb_mfg_qty.Clear();

            MessageBox.Show("Cleared Successfully.");
        }

        // Clear Sell Medicine
        private void clear_sell(object sender, EventArgs e)
        {
            cb_sell_name.ResetText();
            tb_sell_qty.Clear();

            MessageBox.Show("Cleared Successfully.");
        }

        // Sell Medicine
        private void sell(object sender, EventArgs e)
        {
            if(tb_sell_qty.Text == "" || cb_sell_name.Text == "")
            {
                MessageBox.Show("Please fill up the fields.");
                return;
            }
            foreach(Medicine i in medicine_list)
            {
                if(i.get_name() == cb_sell_name.Text)
                {
                    if(i.get_count() < int.Parse(tb_sell_qty.Text))
                    {
                        MessageBox.Show(tb_sell_qty.Text + " medicines are not available.");
                        return;
                    }

                    i.set_count(i.get_count() - int.Parse(tb_sell_qty.Text));
                    balance += i.get_price()*int.Parse(tb_sell_qty.Text);
                    MessageBox.Show("Sold Successfully.");
                    return;
                }
            }

            MessageBox.Show("Medicine is not available.");
        }

        // Clear Add Money
        private void clear_money(object sender, EventArgs e)
        {
            tb_add_money.Clear();

            MessageBox.Show("Cleared Successfully.");
        }

        // Add Money
        private void add_money(object sender, EventArgs e)
        {
            if(tb_add_money.Text == "")
            {
                MessageBox.Show("Please enter an amount.");
                return;
            }
            if(int.Parse(tb_add_money.Text) < 0)
            {
                MessageBox.Show("Enter a valid amount.");
            }
            balance += int.Parse(tb_add_money.Text);

            MessageBox.Show("Money added successfully.");
        }

        // Show Balance
        private void show_balance(object sender, EventArgs e)
        {
            MessageBox.Show("Availabe balance is " + balance.ToString() + " Tk.");
        }

        // Clear Medicine History
        private void clear_history(object sender, EventArgs e)
        {
            tb_history_name.ResetText();
            tb_history_mfg_cmp.Clear();
            tb_history_mfg_date.Clear();
            tb_history_exp.Clear();
            tb_history_qty.Clear();
            tb_history_price.Clear();

            MessageBox.Show("Cleared Successfully.");
        }

        // Show Medicine History
        private void show_hist(object sender, EventArgs e)
        {
            if(tb_history_name.Text == "")
            {
                MessageBox.Show("Please fill up medicine name.");
                return;
            }
            foreach(Medicine i in medicine_list)
            {
                if(i.get_name() == tb_history_name.Text)
                {
                    tb_history_mfg_cmp.Text = i.get_company();
                    tb_history_mfg_date.Text = i.get_mfg_date();
                    tb_history_exp.Text = i.get_exp_date();
                    tb_history_price.Text = i.get_price().ToString();
                    tb_history_qty.Text = i.get_count().ToString();
                }
            }
        }
    }
}