using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    interface ICommand
    {
        void Execute();
    }

    class JumpCommand : ICommand
    {
        Dog dog = new Dog();
        public void Execute()
        {
            dog.Jump();
        }
    }

    class GoCommand : ICommand
    {
        Dog dog = new Dog();
        public void Execute()
        {
            dog.Go();
        }
    }

    class RunCommand : ICommand
    {
        Dog dog = new Dog();
        public void Execute()
        {
            dog.Run();
        }
    }

    class Dog
    {
        public void Jump()
        {
            Console.WriteLine("Dog is jumping");
        }

        public void Go()
        {
            Console.WriteLine("Dog is going");
        }

        public void Run()
        {
            Console.WriteLine("Dog is running");
        }
    }

    class Person
    {
        ICommand command;
        public Person()
        { }

        public void SetCommand(ICommand command)
        {
            this.command = command;
        }

        public void PressButton()
        {
            command.Execute();
        }
    }

}
