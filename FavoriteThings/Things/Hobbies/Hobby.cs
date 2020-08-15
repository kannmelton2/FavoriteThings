using FavoriteThings.Things.Hobbies;
using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Things
{ 
    abstract class Hobby
    {
        // properties
        public string Name { get; set; }
        public string Type { get; set; }
        public SkillLevel Skill { get; set; }

        // constructor
        public Hobby(string name, SkillLevel skill)
        {
            Name = name;
            Skill = skill;
        }

        // methods
        public void DoTheHobby()
        {
            Console.WriteLine($"I like doing {Name}, too. Let's go!");
            switch (Skill)
            {
                case (SkillLevel)1:
                    Skill = SkillLevel.Amatuer;
                    break;
                case (SkillLevel)2:
                    Skill = SkillLevel.MidLevel;
                    break;
                case (SkillLevel)3:
                    Skill = SkillLevel.Master;
                    break;
                default:
                    break;
            }    
        }

        public void Levels()
        {
            switch (Skill)
            {
                case (SkillLevel)1:
                    Console.WriteLine($"I'm a {Skill}, and learning something new with {Name} as often as I can");
                    break;
                case (SkillLevel)2:
                    Console.WriteLine($"I'm an {Skill} at {Name}, but I'm getting better every day!");
                    break;
                case (SkillLevel)3:
                    Console.WriteLine($"I feel confident with {Name}, but I haven't mastered it yet.");
                    break;
                case (SkillLevel)4:
                case (SkillLevel)5:
                    Console.WriteLine($"I'm a {Skill} at {Name}.");
                    break;
                default:
                    Console.WriteLine("You need to pick a skill level");
                    break;
            }
        }

    }
}
