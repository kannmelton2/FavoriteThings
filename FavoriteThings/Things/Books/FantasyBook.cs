using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Things.Books
{
    class FantasyBook : Book
    {
        // properties
        public string World { get; set; }
        public bool HasMagic { get; set; } = true;

        // constructor
        public FantasyBook(string title, string author, int yearRead, int rating) : base(title, author, yearRead, rating)
        {

        }

        // methods
        public override void Learn()
        {
            base.Learn();
            Console.ReadLine();
            Console.WriteLine("You should have learned that saving the world should not have to be left to teenagers with better morals than their adult counterparts.");
        }


    }
}
