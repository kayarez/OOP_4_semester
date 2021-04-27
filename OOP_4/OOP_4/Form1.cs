using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_4
{
    public partial class Form1 : Form
    {
        public double i;
        public double a, b, c;
        public double memory = 0;
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            a = Double.Parse(textBox1.Text);
            b = Math.Sin(a);
            textBox1.Text = b.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            a = Double.Parse(textBox1.Text);
            b = Math.Cos(a);
            textBox1.Text = b.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a = Double.Parse(textBox1.Text);
            b = Math.Tan(a);
            textBox1.Text = b.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a = Double.Parse(textBox1.Text);
            b = 1 / Math.Tan(a);
            textBox1.Text = b.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "7";
            else
                textBox1.Text += 7;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "8";
            else
                textBox1.Text += 8;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "9";
            else
                textBox1.Text += 9;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            a = Double.Parse(textBox1.Text);
            b = Math.Sqrt(a);
            textBox1.Text = b.ToString();
        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "4";
            else
                textBox1.Text += 4;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "5";
            else
                textBox1.Text += 5;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "6";
            else
                textBox1.Text += 6;
        }
        private void button12_Click(object sender, EventArgs e)
        {
            a = Double.Parse(textBox1.Text);
            b = Math.Pow(a, (double) 1/3);
            textBox1.Text = b.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "1";
            else
                textBox1.Text += 1;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "2";
            else
                textBox1.Text += 2;
        }
        private void button15_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "3";
            else
                textBox1.Text += 3;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            i = 1;
            a = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            textBox1.Focus();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
                textBox1.Text = "0";
            else
                textBox1.Text += 0;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text.IndexOf(",") == -1) && (textBox1.Text.IndexOf("∞") == -1))
                textBox1.Text += ",";

        }


        private void button19_Click(object sender, EventArgs e)
        {
            if (i == 1)
            {
                b = Double.Parse(textBox1.Text);
                c = Math.Pow(a, b);
                textBox1.Text = c.ToString();
            }
        }



        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }



        private void button21_Click(object sender, EventArgs e)
        {
            double Num2, Num3;
            Num2 = Double.Parse(textBox1.Text);
            Num3 = memory + Num2;
            textBox2.Text = Num3.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            double Num2, Num3;
            Num2 = Double.Parse(textBox1.Text);
            Num3 = memory - Num2;
            textBox2.Text = Num3.ToString();
        }


        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {
            memory = 0;
            textBox2.Text = "0";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            memory = Double.Parse(textBox1.Text);
            textBox2.Text = memory.ToString();
            textBox1.Text = "0";
        }
    }
}
