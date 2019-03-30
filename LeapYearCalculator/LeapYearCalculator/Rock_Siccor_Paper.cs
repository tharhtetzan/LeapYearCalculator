using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeapYearCalculator
{
    public partial class Rock_Siccor_Paper : Form
    {
        public Rock_Siccor_Paper()
        {
            InitializeComponent();
        }

        int p1result1, p2result1 = 0;
        public static String winner;

        private void button2_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Exclamation.Play();
            resultdraw = 0;
            p1result1 = 0;
            p2result1 = 0;
            draw.Text = "0";
            p1win.Text = "0";
            p2win.Text = "0";
        }

        private void p2win_Click(object sender, EventArgs e)
        {

        }

        private void p1win_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        int resultdraw = 0;

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        messagebox m = new messagebox();

        public void showmessagebox() {
            m.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Question.Play();
            Random p1 = new Random();
            Random p2 = new Random();
            int p1result = p1.Next(1,4);
            int p2result = p1.Next(1,4);
            switch (p1result) {
                case 1:
                    p1answer.Text = "Rock";
                break;
                case 2:
                    p1answer.Text = "Scissor";
                break;
                case 3:
                    p1answer.Text = "Paper";
                break;
            }
            switch (p2result)
            {
                case 1:
                    p2answer.Text = "Rock";
                    break;
                case 2:
                    p2answer.Text = "Scissor";
                    break;
                case 3:
                    p2answer.Text = "Paper";
                    break;
            }
            if (p1result==p2result) {
                resultdraw++;
                draw.Text = resultdraw.ToString();
            }
            else if (p1result == 1 && p2result == 2)
            {
                winner = "Player1";
                showmessagebox();
                p1result1 = p1result1 + 1;
                p1win.Text = p1result1.ToString();
            }
            else if(p1result == 2 && p2result == 3)
            {
                winner = "Player1";
                showmessagebox();
                p1result1 = p1result1 + 1;
                p1win.Text = p1result1.ToString();
            }
            else if (p1result == 3 && p2result == 1)
            {
                winner = "Player1";
                showmessagebox();
                p1result1 = p1result1 + 1;
                p1win.Text = p1result1.ToString();
            }
            else if (p2result == 1 && p1result == 2)
            {
                winner = "Player2";
                showmessagebox();
                p2result1 = p2result1 + 1;
                p2win.Text = p2result1.ToString();
            }
            else if (p2result == 2 && p1result == 3)
            {
                winner = "Player2";
                showmessagebox();
                p2result1 = p2result1 + 1;
                p2win.Text = p2result1.ToString();
            }
            else if (p2result == 3 && p1result == 1)
            {
                winner = "Player2";
                showmessagebox();
                p2result1 = p2result1 + 1;
                p2win.Text = p2result1.ToString();
            }
        }
    }
}
