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
            Console.WriteLine("Enter a plural noun: ");
            _madLibRepo.PluralNounOne = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter a noun: ");
            _madLibRepo.NounOne = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter a place: ");
            _madLibRepo.PlaceOne = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter another noun: ");
            _madLibRepo.NounTwo = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter a number: ");
            _madLibRepo.NumOne = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter another noun: ");
            _madLibRepo.NounThree = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter an adjective: ");
            _madLibRepo.AdjectiveOne = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter another number: ");
            _madLibRepo.NumTwo = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter a liquid: ");
            _madLibRepo.Liquid = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter another adjective: ");
            _madLibRepo.AdjectiveTwo = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter another noun: ");
            _madLibRepo.NounFour = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter another noun: ");
            _madLibRepo.NounFive = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter another adjective: ");
            _madLibRepo.AdjectiveThree = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter a verb ending in -ing: ");
            _madLibRepo.VerbOne = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter another plural noun: ");
            _madLibRepo.PluralNounTwo = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter another adjective: ");
            _madLibRepo.AdjectiveFour = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter another verb ending in -ing: ");
            _madLibRepo.VerbTwo = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter another noun: ");
            _madLibRepo.NounSix = Console.ReadLine().ToUpper();

            Console.WriteLine($"{_madLibRepo.MadLibFour()}");
        }
    }
}
