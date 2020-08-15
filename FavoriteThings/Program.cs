using FavoriteThings.Things;
using FavoriteThings.Things.Books;
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

            // call methods from Book Class on book 1 & 2
            nightCircus.StartABookClub();
            goodOmens.ReadBook();
            nightCircus.Learn();


            // HOBBY HOBBY HOBBY
            // hobby 1
            var painting = new Hobby("painting");

            // hobby 2
            var archery = new Hobby("archery");

            // assign a type and a level to each hobby
            // hobby 1
            painting.HobbyType = Things.Type.Artistic;
            painting.Level = Skill.MidLevel;

            // hobby 2
            archery.HobbyType = Things.Type.PhysicalActivity;
            archery.Level = Skill.Beginner;

            // use a method from the Hobby Class on an instance
            painting.LevelUp();
            archery.DoTheHobby();


            // SNACK SNACK SNACK
            // snack 1
            var pie = new Snack
            {
                Name = "Cherry Pie",
                isHot = true,
                MainInregredient = "cherries",
                Flavor = Flavour.Sweet
            };

            // snack 2
            var roastedChickpeas = new Snack
            {
                Name = "Roasted Chickpeas",
                isHealthy = true,
                MainInregredient = "Chickpeas",
                Flavor = Flavour.Savory
            };

            // call methods for Snacks
            pie.EatSnack();
            roastedChickpeas.MakeSnack();

            // CHAPSTICK CHAPSTICK CHAPSTICK
            // chapstick 1
            var burtsBees = new Chapstick("Burt's Bees", true);

            // chapstick 2
            var cucumber = new Chapstick("Burt's Bees", true);

            // methods
            cucumber.WhatFlavor();
            Console.WriteLine($"Your {cucumber.Brand} chapstick is {cucumber.Flavor}.");
            burtsBees.ApplyChapstick();

        }
    }
}
