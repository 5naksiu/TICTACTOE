using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TICTACTOE
{
    enum CurrentPlayer
    {
        Cross,
        Circle
    }

    public partial class Form1 : Form
    {
        CurrentPlayer cp;
        public Form1()
        {
            InitializeComponent();
            cp = CurrentPlayer.Cross;
            changeLabel();


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Mark(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;
            if(senderButton.Text.Contains("X") || senderButton.Text.Contains("O"))
            {
                return;
            }
            if(cp == CurrentPlayer.Cross)
            {
                senderButton.Text = "X";
                cp = CurrentPlayer.Circle;
            }
            else
            {
                senderButton.Text = "O";
                cp = CurrentPlayer.Cross;
            }
            checkForWinner();
            changeLabel();



        }
        public void changeLabel()
        {
            if(cp == CurrentPlayer.Cross)
            {
                PlayerLabel.Text = "Krzyżyk";
            }
            else
            {
                PlayerLabel.Text = "Kółko";
            }
        }
        public void checkForWinner()
        {
            if (tl.Text.Contains("X") && cl.Text.Contains("X") && bl.Text.Contains("X"))
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.winner = tl.Text;
                victoryScreen.Show();
            }
            else if (tc.Text.Contains("X") && cc.Text.Contains("X") && bc.Text.Contains("X"))
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.winner = tc.Text;
                victoryScreen.Show();
            }
            else if (tr.Text.Contains("X") && cr.Text.Contains("X") && br.Text.Contains("X"))
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.winner = tr.Text;
                victoryScreen.Show();
            }
            else if (tl.Text.Contains("X") && tc.Text.Contains("X") && tr.Text.Contains("X"))
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.winner = tl.Text;
                victoryScreen.Show();
            }
            else if (cl.Text.Contains("X") && cc.Text.Contains("X") && cr.Text.Contains("X"))
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.winner = tr.Text;
                victoryScreen.Show();
            }
            else if (bl.Text.Contains("X") && bc.Text.Contains("X") && br.Text.Contains("X"))
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.winner = bl.Text;
                victoryScreen.Show();
            }
            else if (tl.Text.Contains("X") && cc.Text.Contains("X") && br.Text.Contains("X"))
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.winner = tl.Text;
                victoryScreen.Show();
            }
            else if (tr.Text.Contains("X") && cc.Text.Contains("X") && bl.Text.Contains("X"))
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.winner = tr.Text;
                victoryScreen.Show();
            }
            else if (tl.Text.Contains("O") && cl.Text.Contains("O") && bl.Text.Contains("O"))
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.winner = tl.Text;
                victoryScreen.Show();
            }
            else if (tc.Text.Contains("O") && cc.Text.Contains("O") && bc.Text.Contains("O"))
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.winner = tc.Text;
                victoryScreen.Show();
            }
            else if (tr.Text.Contains("O") && cr.Text.Contains("O") && br.Text.Contains("O"))
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.winner = tr.Text;
                victoryScreen.Show();
            }
            else if (tl.Text.Contains("O") && tc.Text.Contains("O") && tr.Text.Contains("O"))
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.winner = tl.Text;
                victoryScreen.Show();
            }
            else if (cl.Text.Contains("O") && cc.Text.Contains("O") && cr.Text.Contains("O"))
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.winner = tr.Text;
                victoryScreen.Show();
            }
            else if (bl.Text.Contains("O") && bc.Text.Contains("O") && br.Text.Contains("O"))
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.winner = bl.Text;
                victoryScreen.Show();
            }
            else if (tl.Text.Contains("O") && cc.Text.Contains("O") && br.Text.Contains("O"))
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.winner = tl.Text;
                victoryScreen.Show();
            }
            else if (tr.Text.Contains("O") && cc.Text.Contains("O") && bl.Text.Contains("O"))
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.winner = tr.Text;
                victoryScreen.Show();
            }
        }
        public void clearBoard()
        {
            TableLayoutControlCollection buttons = tableLayoutPanel1.Controls;

            for(int i = 0; i < buttons.Count; i++)
            {
                if (buttons[i] is Button)
                    buttons[i].Text = "";  
            }

            cp = CurrentPlayer.Cross;
            changeLabel();
        }
    }

}
