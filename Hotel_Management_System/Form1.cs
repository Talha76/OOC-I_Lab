using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<SingleRoom> single_roomlist = new List<SingleRoom>();
        List<DoubleRoom> double_roomlist = new List<DoubleRoom>();

        private void add_single_room(object sender, EventArgs e)
        {
            if(tb_single_room.Text == "")
            {
                MessageBox.Show("Enter a package name.");
                return;
            }
            if(tb_single_qty.Text == "")
            {
                MessageBox.Show("Enter number of rooms.");
                return;
            }
            SingleRoom temp = new SingleRoom(tb_single_room.Text, tb_single_tv.Text, tb_single_fridge.Text, tb_single_qty.Text, cb_single_ac.Text, cb_single_gaming.Text);

            foreach(SingleRoom i in single_roomlist)
            {
                if(i.get_name() == temp.get_name())
                {
                    i.set_count(i.get_count() + temp.get_count());
                    string showd = "You have created " + temp.get_count().ToString() + " " + temp.get_name();
                    showd += " rooms which cost " + temp.calculate_cost().ToString() + "/day.";
                    MessageBox.Show(showd);
                    return;
                }
            }

            cb_package.Items.Add(temp.get_name());
            single_roomlist.Add(temp);
            string show = "You have created " + temp.get_count().ToString() + " " + temp.get_name();
            show += " rooms which cost " + temp.calculate_cost().ToString() + "/day.";
            MessageBox.Show(show);
        }

        private void add_double_room(object sender, EventArgs e)
        {
            if(tb_double_room.Text == "")
            {
                MessageBox.Show("Enter a package name.");
                return;
            }
            if(tb_double_qty.Text == "")
            {
                MessageBox.Show("Enter number of rooms.");
                return;
            }
            DoubleRoom temp = new DoubleRoom(tb_double_room.Text, tb_double_tv.Text, tb_double_fridge.Text, tb_double_qty.Text, cb_double_ac.Text, cb_double_xtra_tv.Text, cb_double_breakfast.Text);
            
            foreach(DoubleRoom i in double_roomlist)
            {
                if(i.get_name() == temp.get_name())
                {
                    i.set_count(i.get_count() + temp.get_count());
                    string showd = "You have created " + temp.get_count().ToString() + " " + temp.get_name();
                    showd += " rooms which cost " + temp.calculate_cost().ToString() + "/day.";
                    MessageBox.Show(showd);
                    return;
                }
            }

            cb_package.Items.Add(temp.get_name());
            double_roomlist.Add(temp);
            string show = "You have created " + temp.get_count().ToString() + " " + temp.get_name();
            show += " rooms which cost " + temp.calculate_cost().ToString() + "/day.";
            MessageBox.Show(show);
        }

        private void rent_room(object sender, EventArgs e)
        {
            if(cb_package.Text == "")
            {
                MessageBox.Show("Enter a package name.");
                return;
            }
            if(tb_rent_quantity.Text == "")
            {
                MessageBox.Show("Enter the amount you want to rent.");
                return;
            }
            foreach(SingleRoom i in single_roomlist)
            {
                if(i.get_name() == cb_package.Text)
                {
                    if(i.get_count() - Convert.ToInt32(tb_rent_quantity.Text) < 0)
                    {
                        MessageBox.Show(i.get_count() + " rooms are available.");
                        return;
                    }
                    i.set_count(i.get_count() - Convert.ToInt32(tb_rent_quantity.Text));
                    string show = "Successfully rented " + tb_rent_quantity.Text + " " + i.get_name() + " rooms.";
                    MessageBox.Show(show);
                    return;
                }
            }

            //foreach(doubleroom)
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if(tb_room_history.Text == "")
            {
                MessageBox.Show("Please enter a package name.");
                return;
            }
            foreach(SingleRoom i in single_roomlist)
            {
                if(i.get_name() == tb_room_history.Text)
                {
                    MessageBox.Show(i.get_count().ToString() + " rooms are available of " + i.get_name() + " type.");
                    return;
                }
            }
            foreach(DoubleRoom i in double_roomlist)
            {
                if(i.get_name() == tb_room_history.Text)
                {
                    MessageBox.Show(i.get_count().ToString() + " rooms are available of " + i.get_name() + " type.");
                    return;
                }
            }

            MessageBox.Show("No room has been added yet.");
        }

        private void clear_single_room(object sender, EventArgs e)
        {
            tb_single_room.Clear();
            tb_single_tv.Clear();
            tb_single_fridge.Clear();
            tb_single_qty.Clear();
            cb_single_ac.ResetText();
            cb_single_gaming.ResetText();

            MessageBox.Show("Cleared Successfully.");
        }

        private void clear_double_room(object sender, EventArgs e)
        {
            tb_double_room.Clear();
            tb_double_tv.Clear();
            tb_double_fridge.Clear();
            tb_double_qty.Clear();
            cb_double_ac.ResetText();
            cb_double_xtra_tv.ResetText();
            cb_double_breakfast.ResetText();

            MessageBox.Show("Cleared Successfully.");
        }

        private void clear_rent(object sender, EventArgs e)
        {
            cb_package.ResetText();
            tb_rent_quantity.Clear();

            MessageBox.Show("Cleared Successfully.");
        }

        private void clear_history(object sender, EventArgs e)
        {
            tb_room_history.ResetText();

            MessageBox.Show("Cleared Successfully.");
        }
    }
}
