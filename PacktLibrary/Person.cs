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

        public string Name;
        public DateTime DateOfBirth;
        public WondersOfTheAncientWorld FavoriteAncientWonder;
        public List<Person> Children = new List<Person>();


    }
}
