using System;
using System.Collections.Generic;

namespace Packt.Shared
{
    public class Person : object
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
    }
}
