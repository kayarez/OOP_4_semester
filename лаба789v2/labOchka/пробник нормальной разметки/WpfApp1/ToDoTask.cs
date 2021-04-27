using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{

    public class ToDoTask : INotifyPropertyChanged
    {
        private bool isDone = false;
        private string business;
        private string category;
        private DateTime deadLine = DateTime.Now;
        private string durationTask;
        private int overDue;
        public DateTime DateCreation { get; set; } = DateTime.Now;

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
        public DateTime DeadLine
        {
            get { return deadLine; }
            set
            {
                if (deadLine == value)
                    return;
                deadLine = value;
                OnPropertyChanged("DeadLine");

            }
        }
        public string DurationTask
        {
            get { return durationTask; }
            set
            {
                if (durationTask == value)
                    return;
                else
                {
                    durationTask = value;
                    OnPropertyChanged("DurationTask");
                }
            }
        }
        public int OverDue
        {
            get { return overDue; }
            set
            {
                if (DateCreation != null && DeadLine != null)
                {
                    int residue = (DeadLine - DateTime.Today).Days;
                    if (residue < 0)
                    {
                        value = Math.Abs(residue);
                        overDue = value;
                        OnPropertyChanged("OverDue");
                    }
                    else
                    {
                        overDue = 0;
                        OnPropertyChanged("OverDue");
                    }
                }
                else
                {  
                    OnPropertyChanged("OverDue");
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

