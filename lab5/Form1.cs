using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace lab5
{
    public partial class Form1 : Form
    {
        public void timer_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
            toolStripStatusLabel2.Text = "Элементов: " + books.Count() + " Последнее действие: "+ elem;
        }
        public Form1()
        {
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Enabled = true;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
            InitializeComponent();
        }
        List<Author> mama = new List<Author>();
        string elem="";
        public static List<Book> books = new List<Book>();
        public string mes;
        [Serializable]
        public class Book
        {
            public string genre;

            public Sizee siz;
            [Required]
            [NameAttribute]
            public string name { get; set; }
            public int UDK;
            public int count_list;
            public DateTime release_year;
            public List<Author> authors;
            public DateTime open_year;
            public Book(string genre, int size, string bb, string name, int UDK, int count_list, DateTime release_year,
                List<Author> authors, DateTime open_year)
            {
                this.genre = genre;
                this.siz = new Sizee(size, bb);
                this.name = name;
                this.UDK = UDK;
                this.count_list = count_list;
                this.release_year = release_year;
                this.authors = new List<Author>(authors);
                this.open_year = open_year;
            }
            public override string ToString()
            {
                string text = "\n";
                foreach (Author ss in this.authors)
                    text += ss.name + "\n";
                return "Название: " + this.name + "\nДата релиза: " + this.release_year + "\nАвторы: " + text;
            }
        }
        public class Author
        {
            public string name;
            public string country;
            public Author(string n, string c)
            {
                name = n;
                country = c;
            }
        }
        public class Sizee
        {
            public int size;
            public string bb;
            public Sizee(int siz, string b) { size = siz; bb = b; }
        }
        private void AddAuthor_Click(object sender, EventArgs e)
        {
            mama.Add(new Author(authorBox1.Text, countryBox1.Text));
            MessageBox.Show("Автор добавлен");
            elem = "Добавление автора";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mes) || books == null || listBox1.SelectedItem == null || namebox.TextLength == 0 || mama.Count == 0 || UDKBox.TextLength == 0)
            { return; }
            foreach (Book k in books)
                if (k.UDK == Convert.ToInt32(UDKBox.Text))
                {
                    MessageBox.Show("UDK не должны совпадать!");
                    return;
                }
            
            Book b1 = new Book(mes,
                Convert.ToInt32(numericUpDown1.Value),
                Convert.ToString(listBox1.SelectedItem),
                namebox.Text,
                Convert.ToInt32(UDKBox.Text),
                Convert.ToInt32(listCount.Value),
                releaseDatePicker1.Value,
                mama,
                openDatePicker1.Value
                );
            var results = new List<ValidationResult>();
            if (!Validator.TryValidateObject(b1, new ValidationContext(b1), results,true))
            {
                foreach (var error in results)
                {
                    MessageBox.Show(error.ErrorMessage);
                }
                return;
            }
            books.Add(b1);
            mama = new List<Author>();
            MessageBox.Show("Книга добавлена");
            elem = "Добавление книги";
        }

        private void serializeBut_Click(object sender, EventArgs e)
        {
            File.WriteAllText("D:\\4 СЕМЕСТР\\ООП\\лабы\\lab5\\data\\data.json", JsonConvert.SerializeObject(books, Formatting.Indented));
            elem = "Сериализация";
        }

        private void writeAll_Click(object sender, EventArgs e)
        {
            if (books != null)
            {
                foreach (Book book in books)
                    MessageBox.Show(book.ToString());
            }
        }

        private void deserializeBut_Click(object sender, EventArgs e)
        {
            if (File.Exists("D:\\4 СЕМЕСТР\\ООП\\лабы\\lab5\\data\\data.json"))
            {
                books = JsonConvert.DeserializeObject<List<Book>>(File.ReadAllText("D:\\4 СЕМЕСТР\\ООП\\лабы\\lab5\\data\\data.json"));
            }
            elem = "Десериализация";
        }

        private void HorrorsButton1_CheckedChanged(object sender, EventArgs e)
        {
            mes = HorrorsButton1.Text;
        }

        private void FantasyButton1_CheckedChanged(object sender, EventArgs e)
        {
            mes = HorrorsButton1.Text;
        }

        private void SadButton1_CheckedChanged(object sender, EventArgs e)
        {
            mes = HorrorsButton1.Text;
        }

        private void ComedyButton1_CheckedChanged(object sender, EventArgs e)
        {
            mes = HorrorsButton1.Text;
        }

        private void RomanButton1_CheckedChanged(object sender, EventArgs e)
        {
            mes = HorrorsButton1.Text;
        }

        private void UDKBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                if (e.KeyChar == '\b')
                {
                    e.KeyChar = '\b';
                    return;
                }
                e.Handled = true;
                return;
            }
            if (UDKBox.TextLength > 8)
                e.Handled = true;


        }

        private void Form2_Button_Click(object sender, EventArgs e)
        {
            ShowMyDialogBox();
            Form2.books_sorted = books;
        }
        public void ShowMyDialogBox()
        {
            Form2 testDialog = new Form2();

            if (testDialog.ShowDialog(this) == DialogResult.OK)
            {

            }
            else
            {

            }
            testDialog.Dispose();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

    public class NameAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value.ToString().Length < 2)
            {
                ErrorMessage = "Too short!";
                return false;
            }
            return true;
        }
    }
}
