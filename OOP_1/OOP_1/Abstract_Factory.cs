using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    public interface IAbstractFactory
    {
        IAbstractParrot CreateParrot();

        IAbstractDog CreateDog();
    }

    class ConcreteFactory1 : IAbstractFactory
    {
        public IAbstractParrot CreateParrot()
        {
            return new ConcreteParrot1();
        }

        public IAbstractDog CreateDog()
        {
            return new ConcreteDog1();
        }
    }

    class ConcreteFactory2 : IAbstractFactory
    {
        public IAbstractParrot CreateParrot()
        {
            return new ConcreteParrot2();
        }

        public IAbstractDog CreateDog()
        {
            return new ConcreteDog2();
        }
    }

    public interface IAbstractParrot
    {
        string ParrotFunction();
    }

    class ConcreteParrot1 : IAbstractParrot
    {
        public string ParrotFunction()
        {
            return "Parrot is flying";
        }
    }

    class ConcreteParrot2 : IAbstractParrot
    {
        public string ParrotFunction()
        {
            return "Parrot is screaming";
        }
    }

    public interface IAbstractDog
    {
        string DogFunction();
    }

    class ConcreteDog1 : IAbstractDog
    {
        public string DogFunction()
        {
            return "Dog is jumping";
        }

    }

    class ConcreteDog2 : IAbstractDog
    {
        public string DogFunction()
        {
            return "Dog is barking";
        }

    }
}
