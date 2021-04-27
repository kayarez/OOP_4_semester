using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static string path = @".\файлики\FileJson.json";
        private List<BindingList<ToDoTask>> _states = new List<BindingList<ToDoTask>>();
        private int _historyIndex = -1;

        private BindingList<ToDoTask> _toDoList;
        private readonly string PATH = path;
        private FileJson fileJson;
        public ObservableCollection<string> taskCategories = new ObservableCollection<string> { "Дом", "Отдых", "Учеба", "Работа" };
        public List<string> durateTask = new List<string> { "однократная", "еженедельная", "ежемесячная", "ежегодная" };

        public BindingList<ToDoTask> ToDoLists
        {
            get { return _toDoList; }
        }

        public MainWindow()
        {
            InitializeComponent();
            App.LanguageChanged += LanguageChanged;

            CultureInfo currLang = App.Language;

     
            langMenu.Items.Clear();
            foreach (var lang in App.Languages)
            {
                MenuItem menuLang = new MenuItem();
                menuLang.Header = lang.DisplayName;
                menuLang.Tag = lang;
                menuLang.IsChecked = lang.Equals(currLang);
                menuLang.Click += ChangeLanguageClick;
                langMenu.Items.Add(menuLang);
            }

            //var uri = new Uri("pack://application:,,,/Res/cursor_mini.cur");
            //var stream = Application.GetResourceStream(uri).Stream;
            //var cursor = new Cursor(stream);
            ////Uri uri = new Uri(@"B:\вторая пацейка\сишарп\пробник нормальной разметки\cursor_mini.cur");
            ////var stream = Application.GetResourceStream(uri).Stream;
            ////var cursor = new Cursor(stream);
            //Cursor = cursor;

            App.ThemeChange += ThemeChanged;
            String currTheme = App.Theme;


            Themes.Items.Clear();

            foreach (var t in App.Themes)
            {

                MenuItem tem = new MenuItem();
                tem.Header = t;
                tem.Tag = t;
                tem.IsChecked = ("Resources/" + t + "Theme.xaml").Equals(currTheme);
                tem.Click += ChangeThemeClick;
                Themes.Items.Add(tem);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
            fileJson = new FileJson(PATH);

            try
            {
                _toDoList = fileJson.FromJson();
                _states.Add(fileJson.FromJson());                                                                                                                  
                _historyIndex++;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);               
            }
          
            DataGridList.ItemsSource = _toDoList;
            if (_toDoList != null)
            {
                _toDoList.ListChanged += _toDoList_ListChanged;
            }

            CategorComboBox.ItemsSource = taskCategories;
            DurationTaskComboBox.ItemsSource = durateTask;    

        }
       
        private void LanguageChanged(Object sender, EventArgs e)
        {
            CultureInfo currLang = App.Language;

            foreach (MenuItem i in langMenu.Items)
            {
                CultureInfo ci = i.Tag as CultureInfo;
                i.IsChecked = ci != null && ci.Equals(currLang);
            }
        }
        private void ChangeLanguageClick(Object sender, EventArgs e)
        {
            MenuItem mi = sender as MenuItem;
            if (mi != null)
            {
                CultureInfo lang = mi.Tag as CultureInfo;
                if (lang != null)
                {
                    App.Language = lang;
                }
            }
        }


        private void ThemeChanged(Object sender, EventArgs e)
        {
            String currTheme = App.Theme;

            foreach (MenuItem i in Themes.Items)
            {
                String ci = i.Tag as String;
                i.IsChecked = ci != null && ("Resources/" + ci + "Theme.xaml").Equals(currTheme);
            }
        }
        private void ChangeThemeClick(Object sender, EventArgs e)
        {
            MenuItem mi = sender as MenuItem;
            if (mi != null)
            {
                String tem = mi.Tag as String;
                if (tem != null)
                {
                    App.Theme = tem;
                }
            }
        }

        private void _toDoList_ListChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemChanged || e.ListChangedType == ListChangedType.ItemAdded || e.ListChangedType == ListChangedType.ItemDeleted)
            {
                try
                {
                    fileJson.IntoJson((BindingList<ToDoTask>)sender);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                 
                }
            }

            if (e.ListChangedType == ListChangedType.ItemDeleted)
            {
                if (_historyIndex < _states.Count() - 1)
                {
                    _states.RemoveRange(_historyIndex, (_states.Count() - 1) - _historyIndex);
                }
                _states.Add(fileJson.FromJson());
                _historyIndex++;
            }

            if (e.ListChangedType == ListChangedType.ItemChanged)
            {
                int index = _historyIndex + 1;
                if (index < _states.Count())

                {
                    _states.RemoveRange(index, _states.Count() - index);
                }

                _states.Add(fileJson.FromJson());
                _historyIndex++;
            }
        }

        private void SortByCategories(object sender, RoutedEventArgs e)
        {
            //this.Style.Setters[0] = Style.Setters.Add(Button.Background = new SolidColorBrush(Colors.Red));
            this.Resources["DynAndStat"] = new SolidColorBrush(Colors.Blue);
            BindingList<ToDoTask> newToDoList = new BindingList<ToDoTask>();
            if (CriterionSort.SelectedItem != null)
            {
                if (((TextBlock)CriterionSort.SelectedItem).Text == "Date Creation Default" || ((TextBlock)CriterionSort.SelectedItem).Text == "Дата создания по умолчанию")
                {
                    DataGridList.ItemsSource = _toDoList;
                   
                }
                if (((TextBlock)CriterionSort.SelectedItem).Text == "Categories" || ((TextBlock)CriterionSort.SelectedItem).Text == "Категория")
                {

                    var n = from f in _toDoList
                            orderby f.Categories
                            select f;
                    foreach (var item in n)
                    {
                        newToDoList.Add(item);
                    }
                   
                    DataGridList.ItemsSource = newToDoList;
                   
                }
                if (((TextBlock)CriterionSort.SelectedItem).Text == "Done" || ((TextBlock)CriterionSort.SelectedItem).Text == "Состояние")
                {
                    var verify = from f in _toDoList
                                 where f.IsDone == true
                                 select f;
                    foreach (var item in verify)
                    {
                        newToDoList.Add(item);
                    }
                    DataGridList.ItemsSource = newToDoList;
                   
                }
                if (((TextBlock)CriterionSort.SelectedItem).Text == "Duration" || ((TextBlock)CriterionSort.SelectedItem).Text == "Длительность")
                {
                    var duration = from f in _toDoList
                                  orderby f.DurationTask
                                  select f;
                    foreach (var item in duration)
                    {
                        newToDoList.Add(item);
                    }
                    DataGridList.ItemsSource = newToDoList;
                   
                }
            }
            else
                MessageBox.Show("Choose a parameter of sorting");
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            this.Resources["DynAndStat"] = new SolidColorBrush(Colors.Blue);
            Search search = new Search(ToDoLists);
            search.Show();
            //search.DataGridListSearch.ItemsSource = _toDoList;
        }

        private void Redo_Click(object sender, RoutedEventArgs e)
        {
            if (_states.Count() > 0 && _historyIndex < (_states.Count() - 1))
            {
                fileJson.IntoJson(_states.ElementAt(++_historyIndex));
                _toDoList = fileJson.FromJson();
                DataGridList.ItemsSource = _toDoList;
                if (_toDoList != null)
                {
                    _toDoList.ListChanged += _toDoList_ListChanged;
                }
            }
        }

        private void Undo_Click(object sender, RoutedEventArgs e)
        {
            if (_states.Count() > 0 && _historyIndex > 0)
            {
                fileJson.IntoJson(_states.ElementAt(--_historyIndex));
                _toDoList = fileJson.FromJson();
                DataGridList.ItemsSource = _toDoList;
                if (_toDoList != null)
                {
                    _toDoList.ListChanged += _toDoList_ListChanged;
                }
            }
        }
    }
}
































//первое состояние это все что после загрузи.
//в коллекцию states мы добавили своего рода снимок коллекции в текущий момент, сериализуем чтобы в коллекции был другой объект, копия
//если сделать _states.Add(_toDoList), то снимок коллекции будет один объект с твоим _toDoList, и когда ты добавишь задачу
//то она тоже добавиться в _states, так быть не долго, у тебя должны быть разные состояния, типо загрузилась прилага с 4 задачами
//добавила задачу уже 5 задач
//в _states должно быть 2 снимка где 4 задачи(начальное сост) и где 5 задач, чтоб можно было откатиться