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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(
                textBox1.Text == "Anika" && textBox2.Text == "101010")
            {
           
                Form1 a = new Form1();
                MessageBox.Show("Successful");
                a.Show();

            }
        }
    }
}
