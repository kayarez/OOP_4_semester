using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{

    class Program
    {
        static void Main(string[] args)
        {
            new Client().Main();

            Commander commander = Commander.getCommander("Big Boss");
            Console.WriteLine();
            Console.WriteLine(commander.name);
            Console.WriteLine();

            Director director = new Director();
            Builder drinkBuilder = new Drink1();
            Drink drink1 = director.Make(drinkBuilder);
            Console.WriteLine(drink1.ToString());
            Console.WriteLine();

            drinkBuilder = new Drink2();
            Drink drink2 = director.Make(drinkBuilder);
            Console.WriteLine(drink2.ToString());
            Console.WriteLine();

            drinkBuilder = new Drink3();
            Drink drink3 = director.Make(drinkBuilder);
            Console.WriteLine(drink3.ToString());
            Console.WriteLine();

            IThing figure = new Ball("red");
            IThing clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();
            Console.WriteLine();

            figure = new Mirror("oval");
            clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();

        }

    }
}
