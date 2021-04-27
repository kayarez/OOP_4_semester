using OOP_14.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_14.ViewModels
{
    class MainViewModel: ViewModelBase
    {
        public ObservableCollection<TicketViewModel> TicketsList { get; set; }

        #region Constructor

        public MainViewModel(List<Ticket> tickets)
        {
            TicketsList = new ObservableCollection<TicketViewModel>(tickets.Select(b => new TicketViewModel(b)));
        }

        #endregion
    }
}
