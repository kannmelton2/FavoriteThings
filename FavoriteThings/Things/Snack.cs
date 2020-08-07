using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Things
{
    class Snack
    {
        // properties
        public bool isHot { get; set; }
        public bool isHealthy { get; set; }
        public string Name { get; set; }
        public string MainInregredient { get; set; }   
        public Flavour Flavor { get; set; }

        // fields
        private bool _isHungry = true;


        // methods
        public void MakeSnack()
        {
            Console.WriteLine($"Let's go ahead and make {Name}, I'm really craving something {Flavor}.");
        }

        public void EatSnack()
        {
            if (_isHungry)
            {
                Console.WriteLine($"I'm starved. Let's eat {Name}!");
                _isHungry = false;
            }
            else
            {
                Console.WriteLine($"I'm not hungry right now, let's have some {Name} later.");
            }
        }
    }

    enum Flavour
    {
        Spicy,
        Sweet,
        Savory,
        Salty,
        Sour
    }
}
