using System;
using System.Collections;
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
    public partial class Form1 : Form
    {
        //year
        int year;

        //For Second Panel
        int startyear, endyear;
        String leaps;

        public Form1()
        {
            InitializeComponent();
        }

        //Check Whether the Year Ends With -00
        public void Cal400()
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    leapyearanswer.Text = "This is a Leap year";
                }
                else
                {
                    leapyearanswer.Text = "This is not a Leap year";
                }
            }
            else
            {
                CalLeap();
            }
        }

        //Leap Year Calculater(By 4 Years)
        public void CalLeap() {
            if (year % 4 == 0)
            { 
                leapyearanswer.Text = "This is a Leap year";
            }
            else {
                leapyearanswer.Text = "This is not a Leap year";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        //for Normal Leap Year Calculation
        private void button1_Click_1(object sender, EventArgs e)
        {
            year = Convert.ToInt16(Year1.Text);
            Cal400();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Rock_Siccor_Paper rsp = new Rock_Siccor_Paper();
            rsp.Show();
        }

        //From Year To Leap Year Calculation
        private void button2_Click(object sender, EventArgs e)
        {
            ArrayList leapyears = new ArrayList();
            leapyears.Clear();
            leaps = "";
            startyear = Convert.ToInt16(from.Text);
            endyear = Convert.ToInt16(to.Text);
            if (startyear > endyear)
            {
                MessageBox.Show("Error");
            }
            else {
                for (int i = startyear; i <= endyear; i++)
                {
                    if (i % 100 == 0)
                    {
                        if (i % 400 == 0)
                        {
                            leapyears.Add(i);
                        }
                        else
                        { }
                    }
                    else
                    {
                        if (i % 4 == 0)
                        {
                            leapyears.Add(i);
                        }
                        else
                        { }
                    }
                }
                foreach (int i in leapyears)
                {
                    var item = new ListViewItem();
                    item.Text = i.ToString();
                    listView1.Items.Add(item);
                    leaps = leaps + "" + i + " ";
                }
                numberofleapyears.Text = (leapyears.Count).ToString();
                leapyears.Clear();
            }
        }
            
    }
}
