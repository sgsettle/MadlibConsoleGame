using Figgle;
using PairProgrammingGame.MadLibs;
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
        private readonly Instructions _instructions = new Instructions();
        private readonly President _idealPresident = new President();
        private readonly Roadtrip _roadtrip = new Roadtrip();
        private readonly Pizza _pizzaPizza = new Pizza();
        private readonly Dates _firstDates = new Dates();
        private readonly Unicorns _unicorns = new Unicorns();

        public void Start()
        {
            OpeningGreeting();
            RunMenu();
        }

        private void RunMenu()
        {
            while (_isRunning)
            {
                string userInput = GetMenuSelection();
                OpenMenuItem(userInput);
            }

        }

        public string GetMenuSelection()
        {
            Console.Clear();
            Console.WriteLine(
                       "Welcome to MadLib Mania!!!\n" +
                       "Select from the menu below:\n" +
                       "1. Beginner? Start Here!" +
                       "2. My Ideal President\n" +
                       "3. Road Trip with my Friend\n" +
                       "4. Pizza Pizza\n" +
                       "5. First Dates\n" +
                       "6. What happens when a unicorn poops?\n" +
                       "7. Exit Game");

            string userInput = Console.ReadLine();
            return userInput;
        }

        private void OpenMenuItem(string userInput)
        {
            Console.Clear();
            switch (userInput)
            {
                case "1":
                    _instructions.RunMadLibOne();
                    GetMenuSelection();
                    break;
                case "2":
                    _idealPresident.MyIdealPresident();
                    GetMenuSelection();
                    break;
                case "3":
                    _roadtrip.RoadTripWithFriend();
                    GetMenuSelection();
                    break;
                case "4":
                    _pizzaPizza.PizzaPizza();
                    GetMenuSelection();
                    break;
                case "5":
                    _firstDates.FirstDates();
                    GetMenuSelection();
                    break;
                case "6":
                    _unicorns.UnicornPoops();
                    GetMenuSelection();
                    break;
                case "7":
                    _isRunning = false;
                    return;
                default:
                    Console.WriteLine("Invalid Selection. Please try again.");
                    Console.WriteLine("Press any key to return to the menu.");
                    Console.ReadKey();
                    return;
            }
            // return;

        }
        private void OpeningGreeting()
        {
            Console.WriteLine(
                FiggleFonts.Standard.Render("MadLib\n" +
                 "\n" +
                "Mania"));

            Console.WriteLine("Press any key to enter MadLib Mania!");
            Console.ReadLine();
        }
    }
}
