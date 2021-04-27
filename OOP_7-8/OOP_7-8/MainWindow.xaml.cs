using OOP_7_8.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.HearingClass;

namespace OOP_7_8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BindingList<ToDoList> _toDoList;

        private FileIOService _fileIOService;
        ObservableCollection<string> taskCategories = new ObservableCollection<string> { "Дом", "Отдых", "Учеба" };
        private readonly string PATH = $"{Environment.CurrentDirectory}\\ToDoList.json";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _fileIOService = new FileIOService(PATH);

            try
            {
                _toDoList = _fileIOService.LoadData();
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                Close();
            }


            DataGridList.ItemsSource = _toDoList;
            _toDoList.ListChanged += _toDoList_ListChanged;
            CategorComboBox.ItemsSource = taskCategories;
        }

        private void _toDoList_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemChanged || e.ListChangedType == ListChangedType.ItemAdded || e.ListChangedType == ListChangedType.ItemDeleted)
            {
                try
                {
                    _fileIOService.SaveData(sender);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Close();
                }
            }
        }

        
    }
}
