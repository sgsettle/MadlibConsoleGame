using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgrammingGame
{
    public class MadLibUI
    {
        private bool _isRunning = true;
        private readonly MadLibRepository _madLibRepo = new MadLibRepository();
        public void Start()
        {
            OpeningGreeting();
        }
        private void OpeningGreeting()
        {
            Console.WriteLine("Enter any number: ");
            _madLibRepo.NumOne = Console.ReadLine();
            Console.WriteLine("That's great. Now enter an Adjective");
            _madLibRepo.AdjectiveOne = Console.ReadLine().ToUpper();
            Console.WriteLine("Perfect. Let me add it into my madlib");
            Console.WriteLine($"{ _madLibRepo.MadLibOne()}");
            Console.ReadLine();
        }

        private void DisplayMadLibByTitle()
        {

        }

        private void MadLibs()
        {
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

            Console.WriteLine($"{_madLibRepo.MadLibTwo()}");

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

            Console.WriteLine($"{_madLibRepo.MadLibThree()}");

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
