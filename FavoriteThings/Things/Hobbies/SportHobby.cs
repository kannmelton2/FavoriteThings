using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Things.Hobbies
{
    class SportHobby : Hobby
    {
        // properties
        public string Equipment { get; set; }

        // constructor
        public SportHobby(string name, SkillLevel skill) : base(name, skill)
        {
        }

        // methods
        public void TakeAShower()
        {
            Console.WriteLine($"That was a great practice! You deserve a long, hot shower. Don't forget to clean your {Equipment}, too!");
        }
    }
}
