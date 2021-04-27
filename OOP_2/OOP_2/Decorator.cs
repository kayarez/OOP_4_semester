using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_2
{
    abstract class House
    {
        public int Rooms { get; set; }
        public House(int rooms)
        {
            this.Rooms = rooms;
        }
        public abstract int Cost();
    
    }

    class FirstHouse: House
    {
        public FirstHouse() : base(4)
        { }
        public override int Cost()
        {
            return 6000000;
        }
    }

    class SecondHouse : House
    {
        public SecondHouse() : base(5)
        { }
        public override int Cost()
        {
            return 6500000;
        }
    }

    abstract class HouseDecorator: House
    {
        protected House House;
        public HouseDecorator(int r, House House): base (r)
        {
            this.House = House;
        }
    }

    class HouseWithBalconies: HouseDecorator
    {
        public HouseWithBalconies (House h): base (h.Rooms + 2, h)
        { }
        public override int Cost()
        {
            return House.Cost() + 2000;
        }

    }

    class HouseWithBasement : HouseDecorator
    {
        public HouseWithBasement(House h) : base(h.Rooms +1, h)
        { }
        public override int Cost()
        {
            return House.Cost() + 1000;
        }

    }
}
    