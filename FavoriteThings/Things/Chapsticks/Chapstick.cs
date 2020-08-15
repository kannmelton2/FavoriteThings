using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Things
{
    abstract class Chapstick
    {
        // properties
        public string Brand { get; set; }
        public bool IsFlavored { get; }
        public bool IsTinted { get;  }
        public string Flavor { get; set;  }

        // constructor
        public Chapstick(string brand, bool isFlavored, bool isTinted)
        {
            Brand = brand;
            IsFlavored = isFlavored;
            IsTinted = isTinted;
        }

        // methods
        public string WhatFlavor()
        {
            if (IsFlavored)
            {
                Console.WriteLine("What Flavor is your Chapstick?");
                Flavor = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You don't use Flavored Chapstick? What kind of monster are you?");
            }
            return Flavor;
        }

        public void ApplyChapstick()
        {
            Console.WriteLine($"You should put on your {Brand} chapstick.");
        }
    }
}
