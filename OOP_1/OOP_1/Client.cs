using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    class Client
    {
        public void Main()
        {
            Console.WriteLine("Choose your team \n 1 - the first team \n 2 - the second team");
            int selection = Convert.ToInt32(Console.ReadLine());
            switch (selection)
            {
                case 1:
                    Console.WriteLine("The first team:");
                    ClientMethod(new ConcreteFactory1());
                    break;
                case 2:

                    Console.WriteLine("The second team:");
                    ClientMethod(new ConcreteFactory2());
                    break;
            }
        }

        public void ClientMethod(IAbstractFactory factory)
        {
            var productA = factory.CreateParrot();
            var productB = factory.CreateDog();

            Console.WriteLine(productA.ParrotFunction());
            Console.WriteLine(productB.DogFunction());
        }
    }
}
