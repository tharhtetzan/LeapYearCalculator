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
    public partial class messagebox : Form
    {
        public messagebox()
        {
            InitializeComponent();
        }

        private void messagebox_Load(object sender, EventArgs e)
        {
            label1.Text = Rock_Siccor_Paper.winner + " Wins";
            progressBar1.Value = 0;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                this.Close();
            }
            else {
                progressBar1.Value += 10;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
