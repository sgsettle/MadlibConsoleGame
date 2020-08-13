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
            Console.WriteLine("Enter an adjective: ");
            _madLibRepo.AdjectiveOne = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter a nationality: ");
            _madLibRepo.Nationality = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter a person: ");
            _madLibRepo.Person = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter a noun: ");
            _madLibRepo.NounOne = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter another adjective: ");
            _madLibRepo.AdjectiveTwo = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter another noun: ");
            _madLibRepo.NounTwo = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter another adjective: ");
            _madLibRepo.AdjectiveThree = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter another adjective: ");
            _madLibRepo.AdjectiveFour = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter a plural noun: ");
            _madLibRepo.PluralNounOne = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter another noun: ");
            _madLibRepo.NounThree = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter a number: ");
            _madLibRepo.NumOne = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter a shape: ");
            _madLibRepo.Shapes = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter a food: ");
            _madLibRepo.FoodOne = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter another food: ");
            _madLibRepo.FoodTwo = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter another number: ");
            _madLibRepo.NumTwo = Console.ReadLine().ToUpper();

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
