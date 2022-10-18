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
        int hours;
        int minutes;
        int seconds;
        public Form1()
        {
            InitializeComponent();
            hours = minutes = seconds = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            if(
                seconds > 59)
            {
                minutes++;
                seconds = 0;
            }
            if (minutes > 59)
            {
                hours++;
                minutes = 0;
            }
            lblHours.Text = appendZero(hours);
            lblMinutes.Text = appendZero(minutes);
            lblSeconds.Text = appendZero(seconds);
        }
        private string appendZero(double str)
        {
            if (str <= 9)
                return "0" + str;
            else
                return str.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            hours = minutes = seconds = 0;
            lblHours.Text = appendZero(hours);
            lblMinutes.Text = appendZero(minutes);
            lblSeconds.Text = appendZero(seconds);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
           
        }
    }
}
