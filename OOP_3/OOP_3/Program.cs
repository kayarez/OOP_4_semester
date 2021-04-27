using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Dog dog = new Dog();
            person.SetCommand(new JumpCommand());
            person.PressButton();
            person.SetCommand(new RunCommand());
            person.PressButton();
            person.SetCommand(new GoCommand());
            person.PressButton();
            Console.WriteLine();

            Cat cat = new Cat(new FedCatState());
            cat.Pet();
            cat.Feed();
            cat.Feed();
            Console.WriteLine();

            Puppy puppy = new Puppy();
            puppy.Catch();
            Restorer game = new Restorer();
            game.History.Push(puppy.SaveState());
            puppy.Catch();
            puppy.RestoreState(game.History.Pop());
            puppy.Catch();
            Console.WriteLine();

            Observable observable = new Observable();
            Observer observer1 = new Observer("Katya");
            Observer observer2 = new Observer("Vlad");
            observable.AddObserver(observer1);
            observable.AddObserver(observer2);
            observable.NotifyObservers();
            Console.WriteLine();

            Stove stove = new Stove("12AS3", 5, new GasCook());
            stove.Cook();
            stove.Cooking = new ElectricCook();
            stove.Cook();


        }
    }
}
