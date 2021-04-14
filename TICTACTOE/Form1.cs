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
    }

}
