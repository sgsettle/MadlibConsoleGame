using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgrammingGame.MadLibs
{
    class Instructions
    {
        private readonly MadLibRepository _madLibRepo = new MadLibRepository();
        private bool _returnToMainMenu = true;

        public void RunMadLibOne()
        {
            while (_returnToMainMenu)
            {
                string userInput = OpeningComments();
                UserChoice(userInput);
            }
        }
        public string OpeningComments()
        {
            Console.WriteLine("Mad Libs are a fun fill-in-the blank stories.\n" +
                "\n" +
                "Before I can make a Mad Lib I need to get some information from you.\n" +
                "I am going to ask for things like verbs, nouns, and adjectives.\n" +
                "The more creative you are the more fun and FUNNY a Mad Lib can be.\n" +
                "\n" +
                "Once I have all the information needed, I will send it through\n" +
                "the MAD LIB MANIA MACHINE for the results.\n" +
                "\n" +
                "PRESS 1 To Continue.\n" +
                "PRESS 2 To Return To The Main Menu");
            string userInput = Console.ReadLine();
            return userInput;
        }
        private void UserChoice(string userInput)
        {
            switch (userInput)
            {
                case "1":
                    Console.Clear();
                    Console.WriteLine("AWESOME... COOL... Let's get started!");
                    Console.WriteLine();
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

                    Console.Write("Now enter a Plural Noun. For example cars, dishes, mice, or geese: ");
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
                    break;
                case "2":
                    _returnToMainMenu = false;
                    var madLibUI = new MadLibUI();
                    madLibUI.RunMenu();
                    break;
            }
            return;
        }
    }
}
