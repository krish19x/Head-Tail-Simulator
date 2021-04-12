using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Head_Tail_Simulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tryAgainBtn.Visible = false;
            label1.Text = "";
            FlipBtn.Enabled = false;
        }

        string userInput;
        int loseCount, WinCount;
        private void FlipBtn_Click(object sender, EventArgs e)
        {
            Random headOrTail = new Random();
            int checkForheadOrTail = headOrTail.Next(0, 10);
            if(checkForheadOrTail > 5)
            {
                var bmp = new Bitmap(Head_Tail_Simulator.Properties.Resources.Heads);
                OutPutBox.Image = bmp;
                if (userInput.Equals("HEAD"))
                {
                    label1.ForeColor = Color.Green;
                    label1.Text = "You win!";
                    WinCount++;
                }
                if (userInput.Equals("TAIL"))
                {
                    label1.ForeColor = Color.Red;
                    label1.Text = "You lose";
                    loseCount++;
                }
            }
            if(checkForheadOrTail < 6)
            {
                var bmp = new Bitmap(Head_Tail_Simulator.Properties.Resources.Tails);
                OutPutBox.Image = bmp;
                if (userInput.Equals("TAIL"))
                {
                    label1.ForeColor = Color.Green;
                    label1.Text = "You win!";
                    WinCount++;
                }
                if (userInput.Equals("HEAD"))
                {
                    label1.ForeColor = Color.Red;
                    label1.Text = "You lose";
                    loseCount++;
                }
            }
            Countlbl.Text = WinCount + " - " + loseCount;
            tryAgainBtn.Visible = true;
        }

        private void Headbtn_Click(object sender, EventArgs e)
        {
            userInput = Headbtn.Text;
            TailBtn.Enabled = false;
            Headbtn.Enabled = false;
            FlipBtn.Enabled = true;
        }

        private void TailBtn_Click(object sender, EventArgs e)
        {
            userInput = TailBtn.Text;
            TailBtn.Enabled = false;
            Headbtn.Enabled = false;
            FlipBtn.Enabled = true;
        }

        private void tryAgainBtn_Click(object sender, EventArgs e)
        {
            OutPutBox.Image = null;
            tryAgainBtn.Visible = false;
            label1.Text = "";
            Headbtn.Enabled = true;
            TailBtn.Enabled = true;
            FlipBtn.Enabled = false;
        }
    }
}
