using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{

    interface ICooking
    {
        void Cook();
    }

    class GasCook: ICooking
    {
        public void Cook()
        {
            Console.WriteLine("Cook on a gas stove");
        }
    }

    class ElectricCook: ICooking
    {
        public void Cook()
        {
            Console.WriteLine("Cook on a electric stove");
        }
    }

    class Stove
    {
        protected string Number { get; set; }
        protected int Age { get; set; }
        public ICooking Cooking { private get; set; }
        public Stove (string number, int age, ICooking c)
        {
            this.Number = number;
            this.Age = age;
            Cooking = c;
        }

        public void Cook()
        {
            Cooking.Cook();
        }
    }
}
