using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Lab11_TicTacToe
{
    public partial class Form1 : Form
    {
        bool playerTurn;
        string player, com;
        bool easy;
        List<Button> buttons;
        List<int> unused;
        Random rand;
        int pWin = 0, cWin = 0;

        public Form1()
        {
            InitializeComponent();
        }

        void createUnusedList()
        {
            unused.Clear();
            for(int i = 0; i < 9; i++)
            {
                if (buttons[i].Text == "")
                    unused.Add(i);
            }
        }

        void easyCom()
        {
            bool allUsed = true;
            foreach (Button i in buttons)
                if (i.Text == "")
                    allUsed = false;
            if (allUsed)
            {
                return;
            }
            buttons[unused[rand.Next(unused.Count)]].Text = com;
        }

        int checkIfPlayerWins()
        {
            for (int i = 0; i < 9; i += 3)
            {
                if (buttons[i].Text == buttons[i + 1].Text && buttons[i + 2].Text == buttons[i].Text
                    && buttons[i].Text != "")
                {
                    return buttons[i].Text == player ? 1 : 0;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (buttons[i].Text == buttons[i + 3].Text && buttons[i + 6].Text == buttons[i].Text
                    && buttons[i].Text != "")
                {
                    return buttons[i].Text == player ? 1 : 0;
                }
            }
            if (buttons[0].Text == buttons[4].Text && buttons[8].Text == buttons[0].Text
                    && buttons[0].Text != "")
            {
                return buttons[0].Text == player ? 1 : 0;
            }
            if (buttons[2].Text == buttons[4].Text && buttons[6].Text == buttons[2].Text
                    && buttons[2].Text != "")
            {
                return buttons[2].Text == player ? 1 : 0;
            }
            return -1;
        }

        void clean()
        {
            foreach(Button i in buttons)
                i.Text = "";
        }

        private async void buttonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (!string.IsNullOrEmpty(button.Text))
            {
                MessageBox.Show("You cannot make a move on a used square.");
                return;
            }

            button.Text = player;
            await Task.Delay(1000);

            createUnusedList();
            if (easy)
            {
                easyCom();
            }

            int check = checkIfPlayerWins();
            if (check == 1)
            {
                MessageBox.Show("Player Wins");
                pWin++;
                scorePlayer.Text = "Player: " + pWin.ToString();
            }
            else if (check == 0)
            {
                MessageBox.Show("Computer Wins.");
                cWin++;
                scoreCom.Text = "Computer: " + cWin.ToString();
            }

            bool allUsed = true;
            foreach (Button i in buttons)
                if (i.Text == "")
                    allUsed = false;
            if (allUsed && check == -1)
            {
                MessageBox.Show("Match Tied.");
            }
        }

        private void startGame(object sender, EventArgs e)
        {
            if (o.Checked)
            {
                player = "O"; com = "X";
            }
            else
            {
                player = "X"; com = "O";
            }

            playerTurn = first.Checked;
            easy = izy.Checked;

            buttons = new List<Button>() { button1, button2, button3, button4, button5, button6, button7, button8,
                button9 };
            unused = new List<int>();
            rand = new Random();
            clean();

            if(!playerTurn)
            {
                int i = rand.Next(0, 9);
                buttons[i].Text = com;
            }

            MessageBox.Show("You may start the game.");
        }
    }
}