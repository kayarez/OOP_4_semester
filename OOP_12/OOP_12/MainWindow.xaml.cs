using OOP_12.Controller;
using OOP_12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Data.Entity;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OOP_12
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MyDbContext context = new MyDbContext();
        public MainWindow()
        {
            InitializeComponent();
            MyDbInitialize myDbInitializer = new MyDbInitialize();
            myDbInitializer.InitializeDatabase(context);
        }

        private void SearchGroupButton_Click(object sender, RoutedEventArgs e)
        {
            if (SearchGroupTextBox.Text != "")
            {
                List<Student> students = context.Students.Include(c => c.Course).Include(g => g.Group).ToList();
                List<Student> searched = new List<Student>();
                string search_group = SearchGroupTextBox.Text;
                var searched_groups = from g in students where g.Group.Specialty.Contains($"{search_group}") select g;
                foreach(var item in searched_groups)
                {
                    searched.Add(item);
                }
                if (searched.Count == 0)
                {
                    MessageBox.Show("Данная специальность не найдена.");
                }
                StudentDataGrid.ItemsSource = searched;
            }
            else
            {
                MessageBox.Show("Введите данные для поиска.");
            }


        }

        private void SearchSurnameButton_Click(object sender, RoutedEventArgs e)
        {
            if (SearchSurnameTextBox.Text != "")
            {
                List<Student> students = context.Students.Include(c => c.Course).Include(g => g.Group).ToList();
                List<Student> searched = new List<Student>();
                string search_student = SearchSurnameTextBox.Text;
                var searched_students = from g in students where g.Surname.Contains($"{search_student}") select g;
                foreach (var item in searched_students)
                {
                    searched.Add(item);
                }
                if (searched.Count == 0)
                {
                    MessageBox.Show("Данный студент не найден.");
                }
                StudentDataGrid.ItemsSource = searched;
            }
            else
            {
                MessageBox.Show("Введите данные для поиска.");
            }

        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                context.SaveChanges();
                StudentDataGrid.ClearValue(ItemsControl.ItemsSourceProperty);
                List<Student> students = context.Students.Include(c => c.Course).Include(g => g.Group).ToList();
                StudentDataGrid.ItemsSource = students;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                StudentController studentController = new StudentController();
                Student student = new Student(txtName.Text, txtSurname.Text, txtGroup.Text, int.Parse(txtCourse.Text));

                if (studentController.AddStudent(student))
                {
                    MessageBox.Show("Студент успешно добавлен.");
                    StudentDataGrid.ClearValue(ItemsControl.ItemsSourceProperty);
                    List<Student> students = context.Students.ToList();
                    StudentDataGrid.ItemsSource = students;
                }
                else
                {
                    MessageBox.Show("Этот студент уже добавлен или введенные данные имеют неверный формат.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
