using FavoriteThings.Things.Snacks;
using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Things
{
    class Snack
    {
        // properties
        public bool IsHot { get; set; }
        public bool IsHealthy { get; set; }
        public string Name { get; set; }
        public string MainInregredient { get; set; }   
        public Flavour Flavor { get; set; }
        public bool IsHungry { get; set; } = true;


        // methods
        public void MakeSnack()
        {
            Console.WriteLine($"Let's go ahead and make {Name}, I'm really craving something {Flavor}.");
        }

        public virtual void EatSnack()
        {
            if (IsHungry)
            {
                Console.WriteLine($"I'm starved. Let's eat {Name}!");
                IsHungry = false;
            }
            else
            {
                Console.WriteLine($"I'm not hungry right now, let's have some {Name} later.");
            }
        }
    }
}
