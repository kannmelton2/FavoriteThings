using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Things.Snacks
{
    class DessertSnack : Snack
    {
        // methods
        public override void EatSnack()
        {
            Console.WriteLine($"Let's eat {Name}! I really want some.");
            IsHungry = true;
            Console.WriteLine($"I never feel full after eating {Name}. Let's have some more.");
        }
    }
}
