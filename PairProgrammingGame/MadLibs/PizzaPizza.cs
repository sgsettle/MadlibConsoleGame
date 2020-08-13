using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgrammingGame.MadLibs
{
    class Pizza
    {
        private readonly MadLibRepository _madLibRepo = new MadLibRepository();

        public void PizzaPizza()
        {
            Console.WriteLine("I don't know about you but for my money, nothing can beat\n" +
                "a good PIZZA. I love almost everything about pizza, but if you want really\n" +
                "really good pizza, it cost a ton of money, and until I get a good paying\n" +
                "SoftWare Development job, I'm stuck making my own. I would love to teach\n" +
                "you how to make a good pizza, but before I do I need some information");
            Console.WriteLine();
            Console.WriteLine("Enter an adjective: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            _madLibRepo.AdjectiveOne = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter a nationality: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            _madLibRepo.Nationality = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter a person: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            _madLibRepo.Person = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter a noun: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            _madLibRepo.NounOne = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter another adjective: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            _madLibRepo.AdjectiveTwo = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter another noun: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            _madLibRepo.NounTwo = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter another adjective: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            _madLibRepo.AdjectiveThree = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter another adjective: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            _madLibRepo.AdjectiveFour = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter a plural noun: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            _madLibRepo.PluralNounOne = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter another noun: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            _madLibRepo.NounThree = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter a number: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            _madLibRepo.NumOne = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter a shape: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            _madLibRepo.Shapes = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter a food: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            _madLibRepo.FoodOne = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter another food: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            _madLibRepo.FoodTwo = Console.ReadLine().ToUpper();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Enter another number: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            _madLibRepo.NumTwo = Console.ReadLine().ToUpper();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("Perfect. Let me add it into my MadLib Mania Machine...");
            Console.WriteLine("DONE! Press any key to see your results...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"{ _madLibRepo.MadLibThree()}");
            Console.WriteLine();
            Console.WriteLine("\t\t\tLETS DO SOME MORE!");
            Console.WriteLine("\t\t\tPress Any Key To Continue");
            Console.ReadKey();
        }
    }
}
