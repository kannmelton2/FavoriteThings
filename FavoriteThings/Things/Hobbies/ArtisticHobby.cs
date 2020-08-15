using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace FavoriteThings.Things.Hobbies
{
    class ArtisticHobby : Hobby
    {
        // properties
        public ArtType ArtType { get; set; }

        // constructor
        public ArtisticHobby(string name, SkillLevel skill) : base(name, skill)
        {

        }

        // methods
        public void MakeMoney()
        {
            if (ArtType == ArtType.Visual)
            {
                Console.WriteLine($"Let's sell a {Name}!");
            }
            else if (ArtType == ArtType.Performance)
            {
                Console.WriteLine($"You performed {Name} beautifully!");
            }
            else
            {
                Console.WriteLine($"Let's talk to a publisher!");
            }
        }
    }
}
