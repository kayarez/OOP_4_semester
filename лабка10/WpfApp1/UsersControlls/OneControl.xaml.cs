using System;
using System.Collections.Generic;
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

namespace WpfApp1.UsersControlls
{
    /// <summary>
    /// Логика взаимодействия для OneControl.xaml
    /// </summary>
    public partial class OneControl : UserControl, INotifyPropertyChanged
    { 
        public ICommand commandForButton1 { get; set; }
        public ICommand commandForButton2 { get; set; }
        string str;

        public OneControl()
        {
            this.DataContext = this;
            commandForButton1 = new RelayCommand(p => Str = "From 1 button");
            commandForButton2 = new RelayCommand(p => Str = "From 2 button");
            InitializeComponent();
        }
       
        public string Str
        {
            get { return str; }
            set
            {
                str = value;
                OnPropertyChanged("Str");
            }
        }

        

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
