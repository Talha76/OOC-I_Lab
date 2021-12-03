using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRS_Dependencies;

namespace Car_Rental_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<User> users = new List<User>();
        List<Car> cars_history = new List<Car>();
        private void save_user(object sender, EventArgs e)
        {
            if(tb_userid.Text == "" || tb_username.Text == "" || tb_address.Text == "" || tb_destination.Text == "")
            {
                MessageBox.Show("Please fill up the boxes.");
                return;
            }
            User temp = new User(Convert.ToInt32(tb_userid.Text), tb_username.Text, tb_address.Text, tb_destination.Text);
            foreach(User i in users)
            {
                if(i.get_id() == Convert.ToInt32(tb_userid.Text))
                {
                    MessageBox.Show("User already exists.");
                    return;
                }
            }
            users.Add(temp);
            MessageBox.Show("User Added Successfully!");
        }

        private void save_car(object sender, EventArgs e)
        {
            if(tb_carname.Text == "" || tb_carmodel.Text == "" || tb_count.Text == "")
            {
                MessageBox.Show("Please fiil up the boxes.");
                return;
            }
            int count = Convert.ToInt32(tb_count.Text);
            if (count < 0) MessageBox.Show("Invalid number of Cars entry!");
            Car temp = new Car(tb_carname.Text, tb_carmodel.Text, Convert.ToInt32(tb_count.Text));
            cars_history.Add(temp);
            MessageBox.Show("Car Added Successfully!");
        }

        private void show_user_history(object sender, EventArgs e)
        {
            if(tb_history_userid.Text.Length == 0)
            {
                MessageBox.Show("Please enter an User ID.");
                return;
            }
            int id = Convert.ToInt32(tb_history_userid.Text);

            bool found = false;
            foreach(User i in users)
            {
                if(i.get_id () == id)
                {
                    if ((i.get_car_name()).Length == 0)
                    {
                        MessageBox.Show("User has not rented a car yet");
                        return;
                    }
                    found = true;
                    tb_history_username.Text = i.get_name();
                    tb_history_adress.Text = i.get_address();
                    tb_history_rentedcar.Text = i.get_car_name();
                    tb_history_destination.Text = i.get_destination();
                    break;
                }
            }
            if (!found) MessageBox.Show("User has not rented a car!");
        }

        private void show_car_history(object sender, EventArgs e)
        {
            if(tb_history_carname.Text.Length == 0)
            {
                MessageBox.Show("Please enter a Car name.");
                return;
            }
            bool found = false;
            foreach(Car i in cars_history)
            {
                if(i.get_name() == tb_history_carname.Text)
                {
                    found = true;
                    tb_history_carmodel.Text = i.get_model();
                    tb_history_count.Text = i.get_count().ToString();
                    break;
                }
            }
            if (!found) MessageBox.Show("Car not found!");
        }

        private void rent_a_car(object sender, EventArgs e)
        {
            if(tb_rent_userid.Text.Length == 0 || tb_rent_carname.Text.Length == 0)
            {
                MessageBox.Show("Please fill up the boxes.");
                return;
            }
            int id = Convert.ToInt32(tb_rent_userid.Text);
            bool user_found = false;
            foreach(User i in users)
            {
                if(i.get_id() == id)
                {
                    user_found = true;

                    bool car_found = false;
                    foreach(Car j in cars_history)
                    {
                        if(j.get_name() == tb_rent_carname.Text)
                        {
                            car_found = true;
                            if(j.get_count() == 0)
                            {
                                MessageBox.Show("Car not available!");
                                break;
                            }
                            i.set_car(j.get_name());
                            j.set_count(j.get_count() - 1);
                            MessageBox.Show("Car Rented Successfully!");
                        }
                    }
                    if (!car_found) MessageBox.Show("Car not found!");
                    break;
                }
            }
            if (!user_found) MessageBox.Show("User not found!");
        }

        private void clear_user_info(object sender, EventArgs e)
        {
            tb_userid.Clear();
            tb_username.Clear();
            tb_address.Clear();
            tb_destination.Clear();
            MessageBox.Show("Cleared Successfully!");
        }

        private void clear_car(object sender, EventArgs e)
        {
            tb_carname.Clear();
            tb_carmodel.Clear();
            tb_count.Clear();
            MessageBox.Show("Cleared Successfully!");
        }

        private void clear_rent(object sender, EventArgs e)
        {
            tb_rent_userid.Clear();
            tb_rent_carname.Clear();
            MessageBox.Show("Cleared Successfully!");
        }
    }
}
