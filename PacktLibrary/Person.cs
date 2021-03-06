using System;
using static System.Console;
using System.Collections.Generic;

namespace Packt.Shared
{
    public partial class Person : object
    {
        //constants
        public const string Species = "Homo sapien";

        //read-only fields
        public readonly string HomePlanet = "Earth";
        public readonly DateTime Instantiated;

        public string Name;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld FavoriteAncientWonder;
        public List<Person> Children = new List<Person>();

        //constructors
        public Person()
        {
            Name = "Unknown";
            Instantiated = DateTime.Now;
        }

        public Person(string initialName, string homePlanet)
        {
            Name = initialName;
            HomePlanet = homePlanet;
            Instantiated = DateTime.Now;
        }

        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on {DateOfBirth:dddd}.");
        }

        public string GetOrigin()
        {
            return $"{Name} was born on {HomePlanet}.";
        }

        //Tuples
        public (string, int) GetFruit()
        {
            return ("Apples", 5);
        }

        public (string Name, int Number) GetNamedFruit()
        {
            return (Name: "Apples", Number: 3);
        }

        //Different parameter types
        public void PassingParameters(int x, ref int y, out int z)
        {
            //out params cannot have a default and MUST be initialised in the method
            z = 99;
            //increment
            x++;
            y++;
            z++;
        }
    }
}
