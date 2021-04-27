using OOP_14.Models;
using OOP_14.ViewModels;
using OOP_14.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows;

namespace OOP_14
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public DateTime date1 = new DateTime(2020, 6, 2, 19, 00, 00);
        public DateTime date2 = new DateTime(2020, 5, 18, 19, 30, 00);
        public DateTime date3 = new DateTime(2020, 7, 30, 17, 00, 00);
        public DateTime date4 = new DateTime(2020, 10, 12, 18, 30, 00);
        private void OnStartup(object sender, StartupEventArgs e)

        {
            
            List<Ticket> ticketsList = new List<Ticket>()
            {
                new Ticket("The Cure", date1.DayOfWeek,  date1, "Танцпол", 50, 60),
                new Ticket("The XX", date1.DayOfWeek,  date2, "VIP", 100, 70),
                new Ticket("Наутилус Помпилиус", date1.DayOfWeek,  date3, "VIP", 120, 50),
                new Ticket("X Anmassadors", date1.DayOfWeek,  date4, "Танцпол", 200, 80)
            };

            MainWindow view = new MainWindow(); // создали View
            MainViewModel viewModel = new ViewModels.MainViewModel(ticketsList); // Создали ViewModel
            view.DataContext = viewModel; // положили ViewModel во View в качестве DataContext
            view.Show();
        }
    }
}
