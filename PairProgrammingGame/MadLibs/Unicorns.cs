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
            Console.WriteLine("Enter a plural noun: ");
            _madLibRepo.PluralNounOne = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter an adjective: ");
            _madLibRepo.AdjectiveOne = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter an animal plural noun: ");
            _madLibRepo.PluralNounTwo = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter another plural noun: ");
            _madLibRepo.PluralNounThree = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter another adjective: ");
            _madLibRepo.AdjectiveTwo = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter a color: ");
            _madLibRepo.Color = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter another adjective: ");
            _madLibRepo.AdjectiveThree = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter a noun: ");
            _madLibRepo.NounOne = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter another plural noun: ");
            _madLibRepo.PluralNounFour = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter another adjective: ");
            _madLibRepo.AdjectiveFour = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter a verb: ");
            _madLibRepo.VerbOne = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter another plural noun: ");
            _madLibRepo.PluralNounFive = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter a verb that ends with -ed: ");
            _madLibRepo.VerbTwo = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter another verb: ");
            _madLibRepo.VerbThree = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter another noun: ");
            _madLibRepo.NounTwo = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter another adjective: ");
            _madLibRepo.AdjectiveFive = Console.ReadLine().ToUpper();

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
