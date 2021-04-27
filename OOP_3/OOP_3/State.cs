using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_3
{
  interface ICatState
    {
        void Feed(Cat cat);
        void Pet(Cat cat);
    }

    partial class Cat
    {
        public ICatState CatState { get; set; }
        public Cat(ICatState state)
        {
            CatState = state;
        }

        public void Feed()
        {
            CatState.Feed(this);
        }

        public void Pet()
        {
            CatState.Pet(this);
        }

    }
       class FedCatState : ICatState
        { 
            public void Feed(Cat cat)
            {
                Console.WriteLine("Feed the cat now");
            }

            public void Pet(Cat cat)
            {
                Console.WriteLine("Pet the cat");
                cat.CatState = new PetCatState();
            }
        }

        class PetCatState: ICatState
        {
            public void Feed(Cat cat)
            {
                Console.WriteLine("Feed the cat");
                cat.CatState = new FedCatState();
            }

            public void Pet(Cat cat)
            {
                Console.WriteLine("Pet the cat now");

            }
        }
   
}
