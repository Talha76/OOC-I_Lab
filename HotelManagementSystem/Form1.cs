using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showRoomDetails(object sender, EventArgs e)
        {
            lboxOsDetails.Items.Clear();
            lboxOsDetails.Items.Add("RoomType\tQuantity\tAmount\tStatus");
            foreach(Booking i in Hotel.bookingList)
            {
                lboxOsDetails.Items.Add(i.getInfo());
            }
        }

        private void createAccount(object sender, EventArgs e)
        {
            if(tbUsUserID.Text == "" || tbUsName.Text == "" || tbUsContactNo.Text == "" ||
                tbUsAddress.Text == "")
            {
                MessageBox.Show("Fill up the fields.");
                return;
            }

            User temp = new User(tbUsUserID.Text, tbUsName.Text, tbUsContactNo.Text,
                tbUsAddress.Text);
            foreach(User i in Hotel.userList)
            {
                if(i.getID() == temp.getID())
                {
                    MessageBox.Show("User already exists!");
                    return;
                }
            }
            Hotel.userList.Add(temp);
            MessageBox.Show("User Created.");
        }

        private void placeBooking(object sender, EventArgs e)
        {
            Booking temp = new Booking(tbBookUserID.Text, cbBookChoice.Text, tbBookQty.Text,
                dtEntry.Text, dtDep.Text);
            temp.setID(Hotel.bookingList.Count + 1);
            temp.setStatus("Pending");
            Hotel.bookingList.Add(temp);
            MessageBox.Show("Booking Placed. Booking ID: " + temp.getID() + ".");
        }

        private void showBookingDetails(object sender, EventArgs e)
        {
            foreach(Booking i in Hotel.bookingList)
            {
                if(i.getID() == int.Parse(tbDetailsID.Text))
                {
                    tbDetailsStatus.Text = i.getStatus();
                    if (i.getRoomNo() == 0)
                        tbDetailsRoomNo.Text = "Room not given.";
                    else tbDetailsRoomNo.Text = i.getRoomNo().ToString();
                    tbDetailsAmount.Text = i.getCost().ToString();
                    tbDetailsUserName.Text = i.getName();
                    tbDetailsAddress.Text = i.getAddress();
                }
            }
        }

        private void setStatus(object sender, EventArgs e)
        {
            if (tbOsBookID.Text == "")
            {
                MessageBox.Show("Enter a Booking ID.");
                return;
            }
            if (cbOsStatus.Text == "")
            {
                MessageBox.Show("Please Enter a Status.");
                return;
            }
            foreach (Booking i in Hotel.bookingList)
            {
                if (i.getID() == int.Parse(tbOsBookID.Text))
                {
                    if (cbOsStatus.Text == "Confirmed")
                    {
                        i.setRoomNo(Hotel.roomNo);
                        Hotel.roomNo++;
                        Hotel.Balance += i.getCost();
                        MessageBox.Show("Status Updated. Assigned Room No: " + i.getRoomNo() + ".");
                    }
                    i.setStatus(cbOsStatus.Text);
                    lbOsBalance.Text = "Current Balance: " + Hotel.Balance.ToString();
                    if(cbOsStatus.Text == "Pending")
                        MessageBox.Show("Status Updated");
                    return;
                }
            }
            MessageBox.Show("Not yet Booked.");
        }
    }
}
