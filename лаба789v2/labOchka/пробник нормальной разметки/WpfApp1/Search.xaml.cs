using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Search.xaml
    /// </summary>
    public partial class Search : Window
    {
        public BindingList<ToDoTask> _toDoLists;
        ObservableCollection<string> taskCategories = new ObservableCollection<string> { "Дом", "Отдых", "Учеба", "Работа" };
        List<string> durateTask = new List<string> { "однократная", "еженедельная", "ежемесячная", "ежегодная" };
        
        public Search(BindingList<ToDoTask> toDo)
        {
            InitializeComponent();
            _toDoLists = toDo;
            //DataGridListSearch.ItemsSource = _toDoLists;
        }       
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           
            CategorComboBox.ItemsSource = taskCategories;
            DurationTaskComboBox.ItemsSource = durateTask;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        { 
            if (BusinessNameBox.Text != "" && CategoriesNameBox.Text != "")
            {
                BindingList<ToDoTask> toD = new BindingList<ToDoTask>();
                foreach (var item in _toDoLists)
                {
                    if (item.Categories.Contains(CategoriesNameBox.Text) && item.Business.Contains(BusinessNameBox.Text))
                    {
                        toD.Add(item);
                    }
                }
                if (toD.Count != 0)
                {
                    DataGridListSearch.ItemsSource = toD;
                }
                
            }
            else if (BusinessNameBox.Text != "")
            {
                BindingList<ToDoTask> toD = new BindingList<ToDoTask>();
                string str = BusinessNameBox.Text;
                Regex regex = new Regex($@"(\w*)+{str}+(\w*)");
                foreach (var item in _toDoLists)
                {
                    if (regex.IsMatch(item.Business))
                    {
                        toD.Add(item); 
                    }
                   
                }
                if (toD.Count != 0)
                    DataGridListSearch.ItemsSource = toD;
            }
            else if (CategoriesNameBox.Text != "")
            {
                BindingList<ToDoTask> toD = new BindingList<ToDoTask>();
                foreach (var item in _toDoLists)
                {
                    if (item.Categories.Contains(CategoriesNameBox.Text))
                    {
                        toD.Add(item);
                    }
                }
                if (toD.Count!=0)
                {
                    DataGridListSearch.ItemsSource = toD;
                }
               
            }
           
            else if (BusinessNameBox.Text == "" && CategoriesNameBox.Text == "")
            {
                MessageBox.Show("None of them are writen");
            }

        }
    }
}
