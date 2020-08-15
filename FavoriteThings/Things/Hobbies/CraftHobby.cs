using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Things.Hobbies
{
    // think - leather making, card making, crochet, knitting, scrap booking
    class CraftHobby : Hobby
    {
        // properties
        public string Tools { get; set; }

        // constructor
        public CraftHobby(string name, SkillLevel skill) : base(name, skill)
        {

        }

        // methods
        public void UpgradeTools()
        {
            if (Skill == SkillLevel.MidLevel)
            {
                Console.WriteLine($"Great job practicing {Name}. You can upgrade your {Tools} now!");
            }
            else
            {
                Console.WriteLine($"You should practice {Name} a little more before you upgrade your {Tools}.");
            }
        }
    }
}
