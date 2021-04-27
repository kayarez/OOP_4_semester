using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{

    interface IObserver
    {
        void Update();
    }

    interface IObservable
    {
        void AddObserver(IObserver observer);
        void RemoveObserver(IObserver observer);
        void NotifyObservers();
    }

    class Observer: IObserver
    {
        public string Name { get; set; }
        public Observer(string name)
        {
            this.Name = name;
        }
        public void Update()
        {
            Console.WriteLine("Updates");
        }

    }

    class Observable: IObservable
    {
        List<IObserver> observers;
        public Observable()
        {
            observers = new List<IObserver>();
        }

        public void AddObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void NotifyObservers()
        {
            foreach (IObserver o in observers)
            {
                o.Update();
            }
        }
    }
}
