using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    interface IThing
    {
        IThing Clone();
        void GetInfo();
    }

    class Ball : IThing
    {
        string color;
        public Ball(string _color)
        {
            color = _color;
        }

        public IThing Clone()
        {
            return new Ball(this.color);
        }
        public void GetInfo()
        {
            Console.WriteLine($"{color} ball");
        }
    }

    class Mirror : IThing
    {
        string form;
        public Mirror(string _form)
        {
            this.form = _form;
        }

        public IThing Clone()
        {
            return new Mirror(this.form);
        }
        public void GetInfo()
        {
            Console.WriteLine($"{form} mirror");
        }
    }
}
