using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Things
{
    class Hobby
    {
        // properties
        public string Name { get; set; }
        public Type HobbyType { get; set; }
        public Skill Level { get; set; }

        // constructor
        public Hobby(string name)
        {
            Name = name;
        }

        // methods
        public void DoTheHobby()
        {
            Console.WriteLine($"I like doing {Name}, too. Let's go!");
        }

        public void LevelUp()
        {
            switch (Level)
            {
                case (Skill)1:
                    Console.WriteLine($"I'm a {Level}, and learning something new with {Name} as often as I can");
                    break;
                case (Skill)2:
                    Console.WriteLine($"I'm an {Level} at {Name}, but I'm getting better every day!");
                    break;
                case (Skill)3:
                    Console.WriteLine($"I feel confident with {Name}, but I haven't mastered it yet.");
                    break;
                case (Skill)4:
                case (Skill)5:
                    Console.WriteLine($"I'm a {Level} at {Name}.");
                    break;
                default:
                    Console.WriteLine("You need to pick a skill level");
                    break;
            }
        }

    }
    //enums
    enum Type
    {
        Artistic = 1,
        PhysicalActivity,
        TeamSport,
        Baking,
        Cooking,
        Craft,
        Writing
    }

    enum Skill
    {
        Beginner = 1,
        Amatuer,
        MidLevel,
        Master,
        Professional
    }
}
