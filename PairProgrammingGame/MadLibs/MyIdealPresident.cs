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
            _madLibRepo.NumOne = Console.ReadLine();

            Console.Write("That's great. Now enter an Adjective. Like bald, huge, green or itchy: ");
            _madLibRepo.AdjectiveOne = Console.ReadLine().ToUpper();

            Console.Write("Excellent! Now enter a Verb. Like Slip, Throw, Wash, or Tolerate: ");
            _madLibRepo.VerbOne = Console.ReadLine().ToUpper();

            Console.Write("Perfect! Now enter a Noun. Like Plate, Ball, or Car: ");
            _madLibRepo.NounTwo = Console.ReadLine().ToUpper();

            Console.Write("Now enter another Adjective: ");
            _madLibRepo.AdjectiveTwo = Console.ReadLine().ToUpper();

            Console.Write("That's great. Give me another Adjective: ");
            _madLibRepo.AdjectiveThree = Console.ReadLine().ToUpper();

            Console.Write("Give me one more Adjective: ");
            _madLibRepo.AdjectiveFour = Console.ReadLine().ToUpper();

            Console.Write("Make it two more Adjective: ");
            _madLibRepo.AdjectiveFive = Console.ReadLine().ToUpper();

            Console.Write("You are almost done! Now enter a Place. Like Minnesota, Bathroom, Mejier, or Casino: ");
            _madLibRepo.PlaceOne = Console.ReadLine().ToUpper();

            Console.Write("I need another of of those Adjectives: ");
            _madLibRepo.AdjectiveSix = Console.ReadLine().ToUpper();

            Console.Write("WOW! You are on a roll. I need a few more from you. Give me a Verb: ");
            _madLibRepo.VerbTwo = Console.ReadLine().ToUpper();

            Console.Write("Now enter a Plurl Noun. For example cars, dishes, mice, or geese: ");
            _madLibRepo.PluralNounOne = Console.ReadLine().ToUpper();

            Console.Write("Give me another one of those regular Nouns: ");
            _madLibRepo.NounThree = Console.ReadLine().ToUpper();

            Console.Write("I need one more Noun. ");
            _madLibRepo.NounFour = Console.ReadLine().ToUpper();

            Console.Write("Finally the last one! Give me one more Adjective: ");
            _madLibRepo.AdjectiveSeven = Console.ReadLine().ToUpper();

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
