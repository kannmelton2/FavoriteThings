using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Things.Books
{
    class RomanceBook : Book
    {
        // properties
        public bool IsTrashy { get; set; } = true;
        public string RelationshipType { get; set; }

        // constructor
        public RomanceBook(string title, string author, int yearRead, int rating) : base(title, author, yearRead, rating)
        {

        }

        // methods
        public void Fangirl()
        {
            Console.WriteLine("The current reader is fangirl screaming");
        }
    }
}
