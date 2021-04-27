using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{

    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Katya", 19);
            AFoot aFoot = new AFoot();
            person1.Travel(aFoot);
            Bike bike = new Bike();
            IWalking bikeTransport = new AFootToBikeAdapter(bike);
            person1.Travel(bikeTransport);

            House house1 = new FirstHouse();
            house1 = new HouseWithBalconies(house1);
            Console.WriteLine($"Count of rooms: {house1.Rooms}");
            Console.WriteLine($"Cost: {house1.Cost()}");

            House house2 = new SecondHouse();
            house2 = new HouseWithBasement(house2);
            Console.WriteLine($"Count of rooms: {house2.Rooms}");
            Console.WriteLine($"Cost: {house2.Cost()}");

            House house3 = new FirstHouse();
            house3 = new HouseWithBalconies(house3);
            house3 = new HouseWithBasement(house3);
            Console.WriteLine($"Count of rooms: {house3.Rooms}");
            Console.WriteLine($"Cost: {house3.Cost()}");

            List<IComponent> components = new List<IComponent>();
            Map map1 = new Map("12");
            Map map2 = new Map("21");
            components.Add(map1);
            components.Add(map2);
            Predicate<IComponent> predicate = (IComponent map) => { return map.Title == "12"; };
            Console.WriteLine(components.Find(predicate));
            map1.Draw();
            map2.Draw();


        }
    }
}
