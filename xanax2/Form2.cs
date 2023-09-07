using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xanax2
{
    public partial class Form2 : Form

    {
        double qwe = 0;
        double qwe1 = 0;
        Complex vivod = 0;
        string y = string.Empty;
        bool zxc = true;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            qwe = Convert.ToDouble(textBox1.Text);
            qwe1 = Convert.ToDouble(textBox3.Text);
            Complex c1 = new Complex(qwe, qwe1);
            vivod = Complex.FromPolarCoordinates(Math.Sqrt(c1.Magnitude), c1.Phase / 2.0);
            string m = Convert.ToString(vivod);
            string toRemove2 = "<";
            string toRemove1 = ">";
            int l = m.IndexOf(toRemove2);
            int k = m.IndexOf(toRemove1);
            if (l >= 0)
            {
                y = m.Remove(l, toRemove2.Length);
            }
            if (k >= 0)
            {
                y = y.Replace(">", "i");
            }
            string toReplace = "; ";
            int b = y.IndexOf(toReplace);
            if (b >= 0)
            {
                y = y.Replace("; ", " + ");
            }
            textBox2.Text = Convert.ToString(y);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (zxc == true)
            {
                textBox1.Text += (sender as Button).Text;
            }

            if (zxc == false)
            {
                textBox3.Text += (sender as Button).Text;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (zxc == true)
            {
                textBox1.Text += (sender as Button).Text;
            }

            if (zxc == false)
            {
                textBox3.Text += (sender as Button).Text;
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (zxc == true)
            {
                textBox1.Text += (sender as Button).Text;
            }

            if (zxc == false)
            {
                textBox3.Text += (sender as Button).Text;
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (zxc == true)
            {
                textBox1.Text += (sender as Button).Text;
            }

            if (zxc == false)
            {
                textBox3.Text += (sender as Button).Text;
            }

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (zxc == true)
            {
                textBox1.Text += (sender as Button).Text;
            }

            if (zxc == false)
            {
                textBox3.Text += (sender as Button).Text;
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (zxc == true)
            {
                textBox1.Text += (sender as Button).Text;
            }

            if (zxc == false)
            {
                textBox3.Text += (sender as Button).Text;
            }

        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (zxc == true)
            {
                textBox1.Text += (sender as Button).Text;
            }

            if (zxc == false)
            {
                textBox3.Text += (sender as Button).Text;
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (zxc == true)
            {
                textBox1.Text += (sender as Button).Text;
            }

            if (zxc == false)
            {
                textBox3.Text += (sender as Button).Text;
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (zxc == true)
            {
                textBox1.Text += (sender as Button).Text;
            }

            if (zxc == false)
            {
                textBox3.Text += (sender as Button).Text;
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (zxc == true)
            {
                textBox1.Text += (sender as Button).Text;
            }

            if (zxc == false)
            {
                textBox3.Text += (sender as Button).Text;
            }

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";//Стереть все
            textBox3.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "-";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            zxc = true;


        }

        private void textBox3_MouseClick(object sender, MouseEventArgs e)
        {
            zxc = false;

        }
    }
}
