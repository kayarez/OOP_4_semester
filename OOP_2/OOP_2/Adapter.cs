using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    public interface IWalking
    {
        void Walk();
    }

    public interface IRiding
    {
        void Ride();
    }

   public class Person
    {
        public string name { get; set; }
        public int age { get; set; }

        public Person (string _name, int _age)
        {
            this.name = _name;
            this.age = _age;
        }
        
        public void Travel(IWalking walking)
        {
            walking.Walk();
        }

    }

    public class AFoot:IWalking
    {

        public void Walk()
        {
            Console.WriteLine("Going on foot");
        }
    }

    public class Bike:IRiding
    {

        public void Ride()
        {
            Console.WriteLine("Riding a bike");
        }
    }

    public class AFootToBikeAdapter : IWalking
    {
        Bike bike;
        public AFootToBikeAdapter(Bike _bike)
        {
            this.bike = _bike;
        }

        public void Walk()
        {
            bike.Ride();
        }
    }

}
