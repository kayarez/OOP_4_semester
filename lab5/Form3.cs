using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static lab5.Form1;
using static lab5.Form2;

namespace lab5
{
    public partial class Form3 : Form
    {
        List<Book> books_temp = new List<Book>();
        public Form3()
        {
            InitializeComponent();
        }
      public static bool chk1 = false, chk2 = false, chk3 = false;

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            chk3 = true;
        }
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            chk3 = true;
        }
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            chk2 = true;
        }

        public void button1_Click(object sender, EventArgs e) 
        {
            Regex regex = new Regex(@"(\w*)"+textBox1.Text+@"(\w*)", RegexOptions.IgnoreCase);
            books_temp = new List<Book>();
            if (textBox1.TextLength > 0) chk1 = true;
            if (chk1)
            {
                foreach (Book k in books_sorted)
                {
                    foreach (Author a in k.authors)
                    {
                        if (regex.IsMatch(a.name))
                        {
                            books_temp.Add(k);
                            break;
                        }
                    }
                }
            }
            else
                books_temp = (List<Book>)books_sorted;
            if (chk2)
            {
                books_sorted = books_temp;
                books_temp = new List<Book>();
                foreach (Book k in books_sorted)
                {
                    if (k.release_year.Year == numericUpDown3.Value)
                        books_temp.Add(k);
                }
            }
            if (chk3)
            {
                books_sorted = books_temp;
                books_temp = new List<Book>();
                foreach (Book k in books_sorted)
                {
                    if (k.count_list >= numericUpDown1.Value && k.count_list <= numericUpDown2.Value)
                        books_temp.Add(k);
                }
            }
            books_sorted = books_temp;
            Close();
        }
    }
}
