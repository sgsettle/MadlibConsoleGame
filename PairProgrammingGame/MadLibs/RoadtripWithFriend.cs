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
            Console.ForegroundColor = ConsoleColor.Cyan;
            _madLibRepo.AdjectiveOne = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter a place: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            _madLibRepo.PlaceOne = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter another adjective: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            _madLibRepo.AdjectiveTwo = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter another adjective: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            _madLibRepo.AdjectiveThree = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter a plural noun: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            _madLibRepo.PluralNounOne = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter another plural noun: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            _madLibRepo.PluralNounTwo = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter a noun: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            _madLibRepo.NounOne = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter a verb: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            _madLibRepo.VerbOne = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter another noun: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            _madLibRepo.NounTwo = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter another verb: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            _madLibRepo.VerbTwo = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter an action verb: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            _madLibRepo.ActionVerbOne = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter another plural noun: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            _madLibRepo.PluralNounThree = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter another noun: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            _madLibRepo.NounThree = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter a verb that ends with -ing: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            _madLibRepo.VerbThree = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter another noun: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            _madLibRepo.NounFour = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter a time: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            _madLibRepo.Time = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter another adjective: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            _madLibRepo.AdjectiveFour = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter another action verb: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            _madLibRepo.ActionVerbTwo = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter another verb: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            _madLibRepo.VerbFour = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter another adjective: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            _madLibRepo.AdjectiveFive = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter a possessive noun: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            _madLibRepo.PossessiveNounOne = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
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
