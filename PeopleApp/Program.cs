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

            var alice = new Person
            {
                Name = "Alice Jones",
                DateOfBirth = new DateTime(1998, 3, 7)
            };

            WriteLine($"{alice.Name} was born on {alice.DateOfBirth}");

            BankAccount.InterestRate = 0.012M; //instance member

            var jonesAccount = new BankAccount();
            jonesAccount.AccountName = "Mrs. Jones";
            jonesAccount.Balance = 2400;

            WriteLine($"{jonesAccount.AccountName} earned {jonesAccount.Balance * BankAccount.InterestRate:C} interest");

            var gerrierAccount = new BankAccount();
            gerrierAccount.AccountName = "Ms. Gerrier";
            gerrierAccount.Balance = 98;

            WriteLine($"{gerrierAccount.AccountName} earned {gerrierAccount.Balance * BankAccount.InterestRate:C} interest");

        }
    }
}
