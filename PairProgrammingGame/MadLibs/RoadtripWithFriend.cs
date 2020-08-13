using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgrammingGame.MadLibs
{
    class Roadtrip
    {
        private readonly MadLibRepository _madLibRepo = new MadLibRepository();

        public void RoadTripWithFriend()
        {
            Console.WriteLine("I hope you are ready to go on a fun wild adventure!\n" +
                "I need to get some information from you before\n" +
                " we can go on our trip. HERE WE GO!");
            Console.WriteLine();
            Console.WriteLine("Enter an adjective: ");
            _madLibRepo.AdjectiveOne = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter a place: ");
            _madLibRepo.PlaceOne = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter another adjective: ");
            _madLibRepo.AdjectiveTwo = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter another adjective: ");
            _madLibRepo.AdjectiveThree = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter a plural noun: ");
            _madLibRepo.PluralNounOne = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter another plural noun: ");
            _madLibRepo.PluralNounTwo = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter a noun: ");
            _madLibRepo.NounOne = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter a verb: ");
            _madLibRepo.VerbOne = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter another noun: ");
            _madLibRepo.NounTwo = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter another verb: ");
            _madLibRepo.VerbTwo = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter an action verb: ");
            _madLibRepo.ActionVerbOne = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter another plural noun: ");
            _madLibRepo.PluralNounThree = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter another noun: ");
            _madLibRepo.NounThree = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter a verb that ends with -ing: ");
            _madLibRepo.VerbThree = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter another noun: ");
            _madLibRepo.NounFour = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter a time: ");
            _madLibRepo.Time = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter another adjective: ");
            _madLibRepo.AdjectiveFour = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter another action verb: ");
            _madLibRepo.ActionVerbTwo = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter another verb: ");
            _madLibRepo.VerbFour = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter another adjective: ");
            _madLibRepo.AdjectiveFive = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter a possessive noun: ");
            _madLibRepo.PossessiveNounOne = Console.ReadLine().ToUpper();
            Console.WriteLine("Ready to read your MadLib?");

            Console.WriteLine();
            Console.WriteLine("Perfect. Let me add it into my MadLib Mania Machine...");
            Console.WriteLine("DONE! Press any key to see your results...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"{ _madLibRepo.MadLibTwo()}");
            Console.WriteLine();
            Console.WriteLine("\t\t\tLETS DO SOME MORE!");
            Console.WriteLine("\t\t\tPress Any Key To Continue");
            Console.ReadKey();
        }
    }
}
