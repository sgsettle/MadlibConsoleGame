using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgrammingGame.MadLibs
{
    class Dates
    {
        private readonly MadLibRepository _madLibRepo = new MadLibRepository();

        public void FirstDates()
        {
            Console.WriteLine("I don't know about you but going out on a first dates can be\n" +
                "super stressful. Making sure you don't forget deodorant or that you don't\n" +
                "eat a huge pot of cabbage before hand is stressful enough, but figuring out\n" +
                "what to do is mind blowing. Instead of stressing out about your next first date,\n" +
                "let me help you. Before I get started, I need some information from you...");
            Console.WriteLine();
            Console.WriteLine("Enter a plural noun: ");
            Console.ForegroundColor = ConsoleColor.Green;
            _madLibRepo.PluralNounOne = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter a noun: ");
            Console.ForegroundColor = ConsoleColor.Green;
            _madLibRepo.NounOne = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter a place: ");
            Console.ForegroundColor = ConsoleColor.Green;
            _madLibRepo.PlaceOne = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter another noun: ");
            Console.ForegroundColor = ConsoleColor.Green;
            _madLibRepo.NounTwo = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter a number: ");
            Console.ForegroundColor = ConsoleColor.Green;
            _madLibRepo.NumOne = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter another noun: ");
            Console.ForegroundColor = ConsoleColor.Green;
            _madLibRepo.NounThree = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter an adjective: ");
            Console.ForegroundColor = ConsoleColor.Green;
            _madLibRepo.AdjectiveOne = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter another number: ");
            Console.ForegroundColor = ConsoleColor.Green;
            _madLibRepo.NumTwo = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter a liquid: ");
            Console.ForegroundColor = ConsoleColor.Green;
            _madLibRepo.Liquid = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter another adjective: ");
            Console.ForegroundColor = ConsoleColor.Green;
            _madLibRepo.AdjectiveTwo = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter another noun: ");
            Console.ForegroundColor = ConsoleColor.Green;
            _madLibRepo.NounFour = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter another noun: ");
            Console.ForegroundColor = ConsoleColor.Green;
            _madLibRepo.NounFive = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter another adjective: ");
            Console.ForegroundColor = ConsoleColor.Green;
            _madLibRepo.AdjectiveThree = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter a verb ending in -ing: ");
            Console.ForegroundColor = ConsoleColor.Green;
            _madLibRepo.VerbOne = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter another plural noun: ");
            Console.ForegroundColor = ConsoleColor.Green;
            _madLibRepo.PluralNounTwo = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter another adjective: ");
            Console.ForegroundColor = ConsoleColor.Green;
            _madLibRepo.AdjectiveFour = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter another verb ending in -ing: ");
            Console.ForegroundColor = ConsoleColor.Green;
            _madLibRepo.VerbTwo = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter another noun: ");
            Console.ForegroundColor = ConsoleColor.Green;
            _madLibRepo.NounSix = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine();
            Console.WriteLine("Perfect. Let me add it into my MadLib Mania Machine...");
            Console.WriteLine("DONE! Press any key to see your results...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"{ _madLibRepo.MadLibFour()}");
            Console.WriteLine();
            Console.WriteLine("\t\t\tLETS DO SOME MORE!");
            Console.WriteLine("\t\t\tPress Any Key To Continue");
            Console.ReadKey();
        }
    }
}
