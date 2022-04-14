using System;
using Packt.Shared;
using static System.Console;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var bob = new Person();
            bob.Name = "Bob Smith";
            bob.DateOfBirth = new DateTime(1965,12,22);
            bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
            bob.Children.Add(new Person {Name = "Alfred" });
            bob.Children.Add(new Person {Name = "Zoe" });

            bob.WriteToConsole();
            WriteLine();
            WriteLine(bob.GetOrigin());
            WriteLine();
            WriteLine($"{bob.Name} is a {Person.Species} from planet {bob.HomePlanet} and has {bob.Children.Count} children: ");

            //for (int child = 0; child < bob.Children.Count; child++)
            //{
                //WriteLine($"{bob.Children[child].Name}");
            //}

            foreach (Person child in bob.Children)
            {
                WriteLine($"{child.Name}");
            }

            //WriteLine(
                //format: "{0}'s favorite wonder is {1}. Its integer is {2}",
                //arg0 : bob.Name,
                //arg1 : bob.FavoriteAncientWonder,
                //arg2 : (int)bob.FavoriteAncientWonder);
            WriteLine();
            var alice = new Person
            {
                Name = "Alice Jones",
                DateOfBirth = new DateTime(1998, 3, 7)
            };

            WriteLine($"{alice.Name} was born on {alice.DateOfBirth}");

            WriteLine();
            var blankPerson = new Person();
            WriteLine($"{blankPerson.Name} of {blankPerson.HomePlanet} was created at {blankPerson.Instantiated:hh:mm:ss} on a {blankPerson.Instantiated:dddd}");
            var gunny = new Person("Gunny", "Mars");
            WriteLine($"{gunny.Name} of {gunny.HomePlanet} was created at {gunny.Instantiated:hh:mm:ss} on a {gunny.Instantiated:dddd}");

            WriteLine();
            BankAccount.InterestRate = 0.012M; //instance member

            var jonesAccount = new BankAccount();
            jonesAccount.AccountName = "Mrs. Jones";
            jonesAccount.Balance = 2400;

            WriteLine($"{jonesAccount.AccountName} earned {jonesAccount.Balance * BankAccount.InterestRate:C} interest");

            var gerrierAccount = new BankAccount();
            gerrierAccount.AccountName = "Ms. Gerrier";
            gerrierAccount.Balance = 98;

            WriteLine($"{gerrierAccount.AccountName} earned {gerrierAccount.Balance * BankAccount.InterestRate:C} interest");

            WriteLine();
            (string, int) fruit = bob.GetFruit();
            // Tuple fields are by default named Item1, Item2 etc.
            WriteLine($"There are {fruit.Item1}, {fruit.Item2} there are.");
            //WriteLine($"There are {fruitNamed.Number} {fruitNamed.Name}.");
             WriteLine();
            var fruitNamed = bob.GetNamedFruit();
            WriteLine($"There are {fruitNamed.Number} {fruitNamed.Name}.");

            //Deconstruct tuple
            (string fruitName, int fruitNumber) = bob.GetFruit();
            WriteLine($"Deconstructed: {fruitName}, {fruitNumber}");

            int a = 10;
            int b = 20;
            int c = 30;

            WriteLine($"Before: a = {a}, b = {b}, c = {c}");
            bob.PassingParameters(a, ref b, out c); 
            // a is passed default as a value i.e. a copy of the variable so keeps the original value of 10
            // b is passed as a reference, y(in the method) is a reference to b, so b is incremented when y is incremented
            // z (in the method) is a reference to c, but c is always replaced by whatever code is returned from the executed method
            WriteLine($"After: a = {a}, b = {b}, c = {c}"); // a = 10, b = 21, c = 100

            int d = 10;
            int e = 20;

            WriteLine($"Before: d = {d}, e = {e}, f doesn't exist yet!");

            //C# 7.0 syntax for out parameter
            bob.PassingParameters(d, ref e, out int f);
            WriteLine($"After: d = {d}, e = {e}, f = {f}");  //d = 10, e = 21, f = 100
            // f is not initialized in main, but is returned as an out from the called method

            var sam = new Person
            {
                Name = "Sam",
                DateOfBirth = new DateTime(1972, 1, 27)
            };

            WriteLine(sam.Origin);
            WriteLine(sam.Greeting);
            WriteLine(sam.Age);

            sam.FavoriteIceCream = "Chocolate fudge";

            WriteLine($"Sam's favorite ice cream flavor is: {sam.FavoriteIceCream}.");
            sam.FavoritePrimaryColor = "Red";
            WriteLine($"Sam's favorite primary color is: {sam.FavoritePrimaryColor}.");
        }
    }
}
