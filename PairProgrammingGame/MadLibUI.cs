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
        private readonly President _idealPresident = new President();
        private readonly Roadtrip _roadtrip = new Roadtrip();
        private readonly Pizza _pizzaPizza = new Pizza();
        private readonly Dates _firstDates = new Dates();

        public void Start()
        {
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
                       "1. My Ideal President.\n" +
                       "2. Road Trip with my Friend.\n" +
                       "3. COMMING SOON.\n" +
                       "4. Exit Game.");

            string userInput = Console.ReadLine();
            return userInput;
        }

        private void OpenMenuItem(string userInput)
        {
            Console.Clear();
            switch (userInput)
            {
                case "1":
                    _idealPresident.MyIdealPresident();
                    GetMenuSelection();
                    break;
                case "2":
                    _roadtrip.RoadTripWithFriend();
                    GetMenuSelection();
                    break;
                case "3":
                    _pizzaPizza.PizzaPizza();
                    GetMenuSelection();
                    break;
                case "4":
                    _firstDates.FirstDates();
                    GetMenuSelection();
                    break;
            }
            return;

        }
        private void OpeningGreeting()
        {
            Console.WriteLine("  __  __           _ _     _ _     
                                |  \/  | __ _  __ | | | (_) | __
                                | |\/| |/ _` |/ _` | |   | | '_ \ 
                                | |  | | (_ | | (_ | | | ___ | | | _) | 
                                | _ |  | _ |\__, _ |\__, _ | _____ | _ | _.__ /
                                |  \/  | __ _ _ __(_) __ _
                                | |\/| |/ _` | '_ \| |/ _` |      
                                | |  | | (_ | | | | | | (_ | |
                              | _ |  | _ |\__, _ | _ | | _ | _ |\__, _ | ");
        }

        
    }
}
