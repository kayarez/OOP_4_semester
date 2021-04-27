using OOP_14.Commands;
using OOP_14.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace OOP_14.ViewModels
{
     class TicketViewModel : ViewModelBase
    {
        public Ticket Ticket;

        public TicketViewModel(Ticket ticket)
        {
            this.Ticket = ticket ;
        }

        public string Group
        {
            get { return Ticket.Group; }
            set
            {
                Ticket.Group = value;
                OnPropertyChanged("Group");
            }
        }

        public DayOfWeek DayOfWeek
        {
            get { return Ticket.DayOfWeek; }
            set
            {
                Ticket.DayOfWeek = value;
                OnPropertyChanged("DayOfWeek");
            }
        }

        public DateTime DateTime
        {
            get { return Ticket.DateTime; }
            set
            {
                Ticket.DateTime = value;
                OnPropertyChanged("DateTime");
            }
        }

        public string Type
        {
            get { return Ticket.Type; }
            set
            {
                Ticket.Type = value;
                OnPropertyChanged("Type");
            }
        }
        public int Count
        {
            get { return Ticket.Count; }
            set
            {
                Ticket.Count = value;
                OnPropertyChanged("Count");
            }
        }

        public double Cost
        {
            get { return Ticket.Cost; }
            set
            {
                Ticket.Cost = value;
                OnPropertyChanged("Cost");
            }
        }

        #region Commands

        #region Забрать

        public int i = 0;

        private DelegateCommand getItemCommand;

        public ICommand GetItemCommand
        {
            get
            {
                if (getItemCommand == null )
                {
                    
                        getItemCommand = new DelegateCommand(GetItem);
                    
                    
                }
                return getItemCommand;
            }
        }

        private void GetItem()
        { 
                Count++;
            
        }

        #endregion

        #region Выдать

        private DelegateCommand giveItemCommand;

        public ICommand GiveItemCommand
        {
            get
            {
                if (giveItemCommand == null)
                {
                    giveItemCommand = new DelegateCommand(GiveItem, CanGiveItem);

                }

                return giveItemCommand;


            }


        }

        private void GiveItem()
        {
            Count--;
        }

        private bool CanGiveItem()
        {
            return Count > 0;
        }


        #endregion

        #endregion
    }
}

