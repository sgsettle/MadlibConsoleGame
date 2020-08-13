using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgrammingGame.MadLibs
{
    class President
    {
        private readonly MadLibRepository _madLibRepo = new MadLibRepository();

        public void MyIdealPresident()
        {

            Console.Write("Enter any number: ");
            Console.ForegroundColor = ConsoleColor.Red;
            _madLibRepo.NumOne = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("That's great. Now enter an Adjective. Like bald, huge, green or itchy: ");
            Console.ForegroundColor = ConsoleColor.Red;
            _madLibRepo.AdjectiveOne = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Excellent! Now enter a Verb. Like Slip, Throw, Wash, or Tolerate: ");
            Console.ForegroundColor = ConsoleColor.Red;
            _madLibRepo.VerbOne = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Perfect! Now enter a Noun. Like Plate, Ball, or Car: ");
            Console.ForegroundColor = ConsoleColor.Red;
            _madLibRepo.NounTwo = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Now enter another Adjective: ");
            Console.ForegroundColor = ConsoleColor.Red;
            _madLibRepo.AdjectiveTwo = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("That's great. Give me another Adjective: ");
            Console.ForegroundColor = ConsoleColor.Red;
            _madLibRepo.AdjectiveThree = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Give me one more Adjective: ");
            Console.ForegroundColor = ConsoleColor.Red;
            _madLibRepo.AdjectiveFour = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Make it two more Adjective: ");
            Console.ForegroundColor = ConsoleColor.Red;
            _madLibRepo.AdjectiveFive = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("You are almost done! Now enter a Place. Like Minnesota, Bathroom, Mejier, or Casino: ");
            Console.ForegroundColor = ConsoleColor.Red;
            _madLibRepo.PlaceOne = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("I need another of of those Adjectives: ");
            Console.ForegroundColor = ConsoleColor.Red;
            _madLibRepo.AdjectiveSix = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("WOW! You are on a roll. I need a few more from you. Give me a Verb: ");
            Console.ForegroundColor = ConsoleColor.Red;
            _madLibRepo.VerbTwo = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Now enter a Plural Noun. For example cars, dishes, mice, or geese: ");
            Console.ForegroundColor = ConsoleColor.Red;
            _madLibRepo.PluralNounOne = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Give me another one of those regular Nouns: ");
            Console.ForegroundColor = ConsoleColor.Red;
            _madLibRepo.NounThree = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("I need one more Noun. ");
            Console.ForegroundColor = ConsoleColor.Red;
            _madLibRepo.NounFour = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Finally the last one! Give me one more Adjective: ");
            Console.ForegroundColor = ConsoleColor.Red;
            _madLibRepo.AdjectiveSeven = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("Perfect. Let me add it into my MadLib Mania Machine...");
            Console.WriteLine("DONE! Press any key to see your results...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"{ _madLibRepo.MadLibOne()}");
            Console.WriteLine();
            Console.WriteLine("\t\t\tLETS DO SOME MORE!");
            Console.WriteLine("\t\t\tPress Any Key To Continue");
            Console.ReadKey();
        }
    }
}
