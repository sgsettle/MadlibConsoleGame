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
            Console.WriteLine("Enter any number.");
            _madLibRepo.NumOne = Console.ReadLine();
            Console.WriteLine("That's great. Now enter an Adjective");
            _madLibRepo.AdjNumOne = Console.ReadLine().ToUpper();
            Console.WriteLine("Perfect. Let me add it into my madlib");
            Console.WriteLine($"{ _madLibRepo.AddLibOne()}");
            Console.ReadLine();
        }
    }
}
