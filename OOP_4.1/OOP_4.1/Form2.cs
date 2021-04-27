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
    public partial class Form2 : Form
    {
        public delegate void Delegator(bool b);
        Delegator delegator;
        List<int> list;

        public Form2()
        {
            InitializeComponent();
            delegator += SortCollection;
        }
        public void SortCollection(bool b)
        {
            if (list == null)
                return;
            if (b)
                list = list.OrderBy(i => i).ToList();
            else
                list = list.OrderByDescending(i => i).ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            list = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < Int32.Parse(textBox3.Text); i++)
            {
                list.Add(rnd.Next(0, 15));
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (list == null)
            {
                label1.Text = "Коллекция не создана!";
                return;
            }
            if (list.Count == 0)
                label1.Text = "В коллекции 0 элементов";
            else
            {
                label1.Text = "";
                for (int i = 0; i < list.Count; i++)
                {
                    label1.Text += list.ElementAt(i) + "\n";

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (list == null)
            {
                label1.Text = "Коллекция не создана";
                return;
            }

            label1.Text = list.Count().ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (list == null)
            {
                label1.Text = "Коллекция не создана";
                return;
            }
            delegator(true);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (list == null)
            {
                label1.Text = "Коллекция не создана";
                return;
            }
            delegator(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (list == null)
            {
                label1.Text = "Коллекция не создана";
                return;
            }
            if (list.Count == 0)
                label1.Text = "В коллекции 0 элементов";
            else
                label1.Text = list.Max().ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (list == null)
            {
                label1.Text = "Коллекция не создана";
                return;
            }
            if (list.Count == 0)
                label1.Text = "В коллекции 0 элементов";
            else
                label1.Text = list.Min().ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int first = 0;

            if (list == null)
            {
                label1.Text = "Коллекция не создана";
                return;
            }
            int last = list.Count;
            try
            {
                first = Int32.Parse(textBox2.Text);
                last = Int32.Parse(textBox1.Text);
                if (first < 0 || last > list.Count || first > last)
                {
                    throw new FormatException();

                }
            }
            catch (FormatException ex)
            {
                label1.Text = " Введен некоректный диапазон";
                return;
            }
            label1.Text = "";
            for (int i = first; i < last; i++)
            {
                label1.Text += list.ElementAt(i) + "\n";
            }
        }
    }
}
