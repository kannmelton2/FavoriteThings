using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Things.Books
{
    class NonFictionBook : Book 
    {
        // properties
        public string Topic { get; set; }
        public bool WasInteresting { get; set; }
        public bool IsPrimarySource { get; set; }

        // constructor
        public NonFictionBook(string title, string author, int yearRead, int rating) : base(title, author, yearRead, rating)
        {

        }

        // methods
        public override void Learn()
        {
            Console.WriteLine($"Congratulations, you learned {Topic}!");
        }
    }
}
