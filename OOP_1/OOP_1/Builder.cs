using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    class Sugar { }
    class Milk { }
    class Coffee { }
    class Water { }

    class Drink
    {
        public Sugar sugar { get; set; }
        public Milk milk { get; set; }
        public Coffee coffee { get; set; }
        public Water water { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            if (sugar != null)
                sb.Append("Sugar \n");
            if (milk != null)
                sb.Append("Milk \n");
            if (coffee != null)
                sb.Append("Coffee \n");
            if (water != null)
                sb.Append("Water \n");
            return sb.ToString();
        }
    }

        abstract class Builder
        {
            public Drink drink { get; private set; }
            public void CreateDrink()
            {
                drink = new Drink();
            }
            public abstract void AddSugar();
            public abstract void AddMilk();
            public abstract void AddCoffee();
            public abstract void AddWater();

        }

        class Director
        {
            public Drink Make(Builder drinkBuilder)
            {
                drinkBuilder.CreateDrink();
                drinkBuilder.AddSugar();
                drinkBuilder.AddMilk();
                drinkBuilder.AddCoffee();
                drinkBuilder.AddWater();

                return drinkBuilder.drink;
            }
        }

    class Drink1 : Builder
    {
        public override void AddSugar()
        {
            this.drink.sugar = new Sugar();
        }
        public override void AddMilk()
        {
            this.drink.milk = new Milk();
        }
        public override void AddCoffee()
        {
            this.drink.coffee = new Coffee();
        }
        public override void AddWater()
        {
            this.drink.water = new Water();
        }

    }

    class Drink2 : Builder
    {
        public override void AddSugar()
        {
            this.drink.sugar = new Sugar();
        }
        public override void AddMilk()
        {

        }
        public override void AddCoffee()
        {
            this.drink.coffee = new Coffee();
        }
        public override void AddWater()
        {
            this.drink.water = new Water();
        }

    }
    class Drink3 : Builder
    {
        public override void AddSugar()
        {

        }
        public override void AddMilk()
        {
            this.drink.milk = new Milk();
        }
        public override void AddCoffee()
        {
            this.drink.coffee = new Coffee();
        }
        public override void AddWater()
        {
            this.drink.water = new Water();
        }

    }



}
