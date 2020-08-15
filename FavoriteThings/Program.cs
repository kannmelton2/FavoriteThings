using FavoriteThings.Things;
using FavoriteThings.Things.Books;
using FavoriteThings.Things.Chapsticks;
using FavoriteThings.Things.Hobbies;
using FavoriteThings.Things.Snacks;
using System;

namespace FavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            // BOOK BOOK BOOK
            // book 1
            var nightCircus = new FantasyBook("The Night Circus", "Erin Morgenstern", 2018, 5)
            {
                IsOwned = true,
                World = "Earth"
            };

            // book 2
            var goodOmens = new FantasyBook("Good Omens", "Neil Gaiman and Terry Pratchett", 2020, 5)
            {
                IsOwned = true,
                World = "Earth"
            };

            // book 3
            var besomStangAndSword = new NonFictionBook("Besom, Stang & Sword", "Christopher Orapello and Tara-Love Maguire", 2020, 4)
            {
                IsOwned = true,
                WasInteresting = true,
                IsPrimarySource = true,
                Topic = "Witchcraft"
            };

            // call methods from Book Class on book 1 & 2
            nightCircus.StartABookClub();
            goodOmens.ReadBook();
            nightCircus.Learn();
            besomStangAndSword.Learn();
            Console.WriteLine(new string('-', 50));

            // HOBBY HOBBY HOBBY
            // hobby 1
            var painting = new ArtisticHobby("painting", SkillLevel.MidLevel)
            {
                ArtType = ArtType.Visual
            };

            // hobby 2
            var archery = new SportHobby("archery", SkillLevel.Beginner)
            { 
                Equipment = "bow and arrows"
            };

            // hobby 3
            var plannering = new CraftHobby("art planning", SkillLevel.Amatuer)
            { 
                Tools = "pens, washi tape, and highlighters"
            };

            // use a method from the Hobby Class on an instance
            painting.Levels();
            archery.DoTheHobby();
            painting.MakeMoney();
            plannering.UpgradeTools();
            plannering.DoTheHobby();
            plannering.UpgradeTools();
            Console.WriteLine(new string('-', 50));





            // SNACK SNACK SNACK
            // snack 1
            var pie = new DessertSnack
            {
                Name = "Cherry Pie",
                MainInregredient = "Cherries",
                Flavor = Flavour.Sweet,
            };

            // snack 2
            var parmZucchini = new VeggieSnack
            {
                Name = "Parmesan Crusted Zucchini",
                IsHealthy = true,
                MainInregredient = "Zucchini",
                Flavor = Flavour.Savory
            };

            // snack 3
            var pineapple = new FruitSnack
            {
                Name = "Pineapple",
                IsHealthy = true,
                MainInregredient = "Pineapple",
                Flavor = Flavour.Sweet,
                IsPineapple = true,
            };

            // call methods for Snacks
            pie.EatSnack();
            parmZucchini.MakeSnack();
            pineapple.EatsYouBack();
            pineapple.EatSnack();
            Console.WriteLine(new string('-', 50));

            // CHAPSTICK CHAPSTICK CHAPSTICK
            // chapstick 1
            var burtsBees = new UnflavoredChapstick("Burt's Bees");

            // chapstick 2
            var cucumber = new FlavoredChapstick("Burt's Bees", false);

            // chaptstick 3
            var pink = new TintedChapstick("EOS")
            {
                Color = "pink"
            };

            // methods
            pink.WhatFlavor();
            Console.WriteLine($"Your {pink.Brand} chapstick is {pink.Flavor}.");
            burtsBees.ApplyChapstick();

        }
    }
}
