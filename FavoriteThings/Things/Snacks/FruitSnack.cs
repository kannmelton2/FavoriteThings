using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Things.Snacks
{
    class FruitSnack : Snack
    {
        // properties
        public bool IsPineapple { get; set; }

        // methods
        public void CutFruit()
        {
            Console.WriteLine($"Cut the {MainInregredient}.");
        }

        public void EatsYouBack()
        {
            if (IsPineapple)
            {
                Console.WriteLine("Better eat it, before it eats you!");
            }
            else
            {
                Console.WriteLine("Looks like this one won't eat you back, how boring.");
            }
        }
    }
}
