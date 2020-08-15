using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Things.Chapsticks
{
    class TintedChapstick : Chapstick
    {
        // properties
        public string Color { get; set; }

        // constructor
        public TintedChapstick(string brand) : base(brand, true, true)
        {

        }

        // methods
        public void Fix()
        {
            Console.WriteLine($"Oh no! Your {Color} chapstick is messy. Why don't you fix it in the restroom?");
        }

    }
}
