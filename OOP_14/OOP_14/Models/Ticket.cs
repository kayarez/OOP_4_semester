using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_14.Models
{
    public class Ticket
    {
        public string Group { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public DateTime DateTime { get; set; }
        public string Type { get; set; }
        public int Count { get; set; }
        public double Cost { get; set; }

        public Ticket(string group, DayOfWeek dayOfWeek, DateTime dateTime, string type, int count, double cost)
        {
            this.Group = group;
            this.DayOfWeek = dayOfWeek;
            this.DateTime = dateTime;
            this.Type = type;
            this.Count = count;
            this.Cost = cost;
        }
    }
}
