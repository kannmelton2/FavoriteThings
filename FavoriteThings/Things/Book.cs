using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Things
{
    class Book
    {
        // properties
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsOwned { get; set; }
        public int YearRead { get; set; }
        public int Rating { get; set; }

        // methods
        public void StartABookClub()
        {
            Console.WriteLine($"Oh, you like {Title}, too? I read that in {YearRead}; I give it a {Rating} out of 5. Let's start a book club! Maybe {Author} will notice us!");
        }

        public void ReadBook()
        {
            Console.WriteLine($"Go Read {Title} by {Author}");
        }

    }
}
