using FavoriteThings.Things;
using System;

namespace FavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            // BOOK BOOK BOOK
            // book 1
            var nightCircus = new Book
            {
                Title = "The Night Circus",
                Author = "Erin Morgenstern",
                YearRead = 2018,
                Rating = 5,
                IsOwned = true,
            };

            // book 2
            var goodOmens = new Book
            {
                Title = "Good Omens",
                Author = "Neil Gaiman and Terry Pratchett",
                YearRead = 2020,
                Rating = 5,
                IsOwned = true,
            };

            // call methods from Book Class on book 1 & 2
            nightCircus.StartABookClub();
            goodOmens.ReadBook();


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
