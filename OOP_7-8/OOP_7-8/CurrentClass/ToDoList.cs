using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.HearingClass
{
    class ToDoList : INotifyPropertyChanged
    {
        private bool isDone = false;
        private string business;
        private string category;
        private DateTime dateEnd;


        [JsonProperty(PropertyName = "dateCreation")]

        public DateTime DateCreation { get; set; } = DateTime.Now;

        [JsonProperty(PropertyName = "isDone")]
        public bool IsDone
        {
            get { return isDone; }
            set
            {
                if (isDone == value)
                    return;
                isDone = value;
                OnPropertyChanged("IsDone");
            }
        }


        [JsonProperty(PropertyName = "dateEnd")]


        public DateTime DateEnd
        {
            get { return dateEnd; }
            set
            {
                if (dateEnd == value)
                    return;
                dateEnd = value;
                OnPropertyChanged("DateEnd");
            }
        }

        [JsonProperty(PropertyName = "business")]
        public string Business
        {
            get { return business; }
            set
            {
                if (business == value)
                    return;
                business = value;
                OnPropertyChanged("Business");
            }
        }

        [JsonProperty(PropertyName = "categories")]
        public string Categories
        {
            get { return category; }
            set
            {
                if (category == value)
                    return;
                else
                {
                    category = value;
                    OnPropertyChanged("Categories");
                }
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

