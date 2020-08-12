using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgrammingGame
{
    public class MadLibRepository
    {
        public string NumOne { get; set; }
        public string NumTwo { get; set; }
        public string PluralNounOne { get; set; }
        public string PluralNounTwo { get; set; }
        public string PluralNounThree { get; set; }
        public string PossessiveNounOne { get; set; }
        public string NounOne { get; set; }
        public string NounTwo { get; set; }
        public string NounThree { get; set; }
        public string NounFour { get; set; }
        public string AdjectiveOne { get; set; }
        public string AdjectiveTwo { get; set; }
        public string AdjectiveThree { get; set; }
        public string AdjectiveFour { get; set; }
        public string AdjectiveFive { get; set; }
        public string AdjectiveSix { get; set; }
        public string OccNumOne { get; set; }
        public string OccNumTwo { get; set; }
        public string VerbOne { get; set; }
        public string VerbTwo { get; set; }
        public string VerbThree { get; set; }
        public string VerbFour { get; set; }
        public string ActionVerbOne { get; set; }
        public string ActionVerbTwo { get; set; }
        public string PlaceOne { get; set; }
        public string PlaceTwo { get; set; }
        public string Time { get; set; }

        public string MadLibOne()
        {
            string madLibOne = $"MY IDEAL PRESIDENT\n" +
                $"\n" +
                $"\t There are {NumOne} qualities I admire in a leader.\n" +
                $"\t First, he or she must be {AdjectiveOne} Because {VerbOne} \n" +
                $"\t the {NounOne} is a sign of {AdjectiveOne} character.\n" +
                $"\t Second, a good President should be {AdjectiveTwo}, always making\n " +
                $"\t sure people feel {AdjectiveThree} and {AdjectiveFour}.Third, a President\n" +
                $"\t represents our Country around the {PlaceOne} and should be \n" +
                $"\t {AdjectiveFive} when {VerbTwo} with other world {PluralNounOne}.Strength \n" +
                $"\t of {NounTwo}, a good sense of {NounThree}, and {AdjectiveSix}\n" +
                $"\t leadership are all things my ideal president would have.";

            return madLibOne;
        }

        public string MadLibTwo()
        {
            string madLibTwo = $"ROAD TRIP WITH MY FRIEND\n" +
                $"\n" +
                $"On the {AdjectiveOne} trip to {PlaceOne}, my {AdjectiveTwo} friend and I decided to invent a game. Since this would be a rather {AdjectiveThree} trip, it would need to be a game with {PluralNounOne} and {PluralNounTwo}. Using our {NounOne} to {VerbOne}, we tried to get the {NounTwo} next to us to play too, but they just {VerbTwo}ed at us and {ActionVerbOne} a way. After a few rounds, we thought the game could use some {PluralNounThree} so we turned on the {NounThree} and started {VerbThree} to the {NounFour} that came on. This lasted for {Time} before I got {AdjectiveFour} and decided to {ActionVerbTwo}. I'll never {VerbFour} that trip, it was the {AdjectiveFive} road trip of my {PossessiveNounOne}.";

                return madLibTwo;
        }
    }
}
