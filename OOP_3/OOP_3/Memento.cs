using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
    class Memento
    {
        public int Ball { get; private set; }
        public int Attempt { get; private set; }
        public Memento (int ball, int attempt)
        {
            this.Ball = ball;
            this.Attempt = attempt;
        }
    }

    class Restorer
    {
        public Stack<Memento> History { get; private set; }
        public Restorer()
        {
            History = new Stack<Memento>();
        }
    }

    class Puppy
    {
        private int ball = 7;
        private int attempt = 7;
        public void Catch()
        {
            if (ball > 0)
            {
                ball--;
                Console.WriteLine("Try to catch. {0} balls left", ball);
            }
            else
                Console.WriteLine("No more balls");
        }

        public Memento SaveState()
        {
            Console.WriteLine("Save the game. Parameters: {0} balls, {1} attemts", ball, attempt);
            return new Memento(ball, attempt);
        }

        public void RestoreState(Memento memento)
        {
            this.ball = memento.Ball;
            this.attempt = memento.Attempt;
            Console.WriteLine("Restart the game. Parameters: {0} balls, {1} attemts", ball, attempt);
        }
    }

}
