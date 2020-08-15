using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Things.Snacks
{
    class VeggieSnack : Snack
    {
        // properties
        public bool PairedWithCondiment { get; set; }


        // methods
        public void Paired()
        {
            if (PairedWithCondiment)
            {
                Console.WriteLine($"What is your {Name} paired with?");
                var condiment = Console.ReadLine();
                Console.WriteLine($"{condiment}? That's a good choice!");
            }
        }

    }
}
