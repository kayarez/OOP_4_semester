using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static lab5.Form1;
using Newtonsoft.Json;
using System.IO;
using static lab5.Form3;

namespace lab5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
       public static IEnumerable<Book> books_sorted = books;
        string au = "";
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            books_sorted = books;
            WriteAll();
        }

        private void UpSortToolMenu_Click(object sender, EventArgs e)
        {
            books_sorted = books_sorted.OrderBy(s => s.name);
            WriteAll();
        }

        private void DescSortTool_Click(object sender, EventArgs e)
        {
            books_sorted = books_sorted.OrderByDescending(s => s.name);
            WriteAll();
        }
        public void WriteAll()
        {
            label1.Text = "";
            foreach (Book book in books_sorted)
            {
                au = "";
                foreach (Author author in book.authors)
                {
                    au += author.name + ", ";
                }
                label1.Text += "Название: " + book.name + "\nСтраниц: "+ book.count_list+"\nДата выпуска: " + book.release_year.ToLongDateString() + "\nАвторы:" + au + "\n--------------\n";
            }
        }

        private void UpDateSortTool_Click(object sender, EventArgs e)
        {
            books_sorted = books_sorted.OrderBy(s => s.release_year);
            WriteAll();
        }

        private void DescDateSortTool_Click(object sender, EventArgs e)
        {
            books_sorted = books_sorted.OrderByDescending(s => s.release_year);
            WriteAll();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            File.WriteAllText("D:\\4 СЕМЕСТР\\ООП\\лабы\\lab5\\data\\SortingResult.json", JsonConvert.SerializeObject(books_sorted, Formatting.Indented));
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор: Katya Kerez\nВерсия 1");
        }

        private void SearchButtonTool_Click(object sender, EventArgs e)
        {
            ShowMyDialogBox3();
            WriteAll();
        }
        public void ShowMyDialogBox3()
        {
            Form3 testDialog3 = new Form3();
            chk1 = false;chk2 = false;chk3 = false;
            if (testDialog3.ShowDialog(this) == DialogResult.OK)
            {

            }
            else
            {

            }
           
            testDialog3.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (toolStrip1.Visible)
            {
                toolStrip1.Hide();
                button1.Text = "Показать";
            }
            else
            {
                toolStrip1.Show();
                button1.Text = "Скрыть";
            }
        }
        

        //-----------------------------------------
  

    }

}
