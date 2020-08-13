using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgrammingGame.MadLibs
{
    class Unicorns
    {
        private readonly MadLibRepository _madLibRepo = new MadLibRepository();

        public void UnicornPoops()
        {
            Console.WriteLine("Have you ever stepped in Unicorn Poop ? Me to...\n" +
                "It's kinda like stepping into a bowl of soggy Skittles that has\n" +
                "been set out in the sun to long.\n" +
                " What I really wonder is what happens when a Unicorn Poops and what\n" +
                "do they have to be eating to produce that nasty rainbow of sludge?\n" +
                "Will you come on an exploritory adventure with me? I will need some\n" +
                "information from you before we can answer these mind boggling questions\n" +
                "\n" +
                "\n");
            Console.WriteLine("Enter a plural noun: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            _madLibRepo.PluralNounOne = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter an adjective: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            _madLibRepo.AdjectiveOne = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter an animal plural noun: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            _madLibRepo.PluralNounTwo = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter another plural noun: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            _madLibRepo.PluralNounThree = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter another adjective: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            _madLibRepo.AdjectiveTwo = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter a color: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            _madLibRepo.Color = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter another adjective: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            _madLibRepo.AdjectiveThree = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter a noun: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            _madLibRepo.NounOne = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter another plural noun: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            _madLibRepo.PluralNounFour = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter another adjective: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            _madLibRepo.AdjectiveFour = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter a verb: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            _madLibRepo.VerbOne = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter another plural noun: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            _madLibRepo.PluralNounFive = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter a verb that ends with -ed: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            _madLibRepo.VerbTwo = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter another verb: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            _madLibRepo.VerbThree = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter another noun: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            _madLibRepo.NounTwo = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter another adjective: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            _madLibRepo.AdjectiveFive = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("Perfect. Let me add it into my MadLib Mania Machine...");
            Console.WriteLine("DONE! Press any key to see your results...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"{ _madLibRepo.MadLibFive()}");
            Console.WriteLine();
            Console.WriteLine("\t\t\tLETS DO SOME MORE!");
            Console.WriteLine("\t\t\tPress Any Key To Continue");
            Console.ReadKey();
        }
    }
}
