using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProgrammingGame
{
    public class MadLibRepository
    {
        public string Title { get; set; }
        public string Animal { get; set; }
        public string BodyPart { get; set; }
        public string Color { get; set; }
        public string NumOne { get; set; }
        public string NumTwo { get; set; }
        public string PluralNounOne { get; set; }
        public string PluralNounTwo { get; set; }
        public string PluralNounThree { get; set; }
        public string PluralNounFour { get; set; }
        public string PluralNounFive { get; set; }
        public string PossessiveNounOne { get; set; }
        public string NounOne { get; set; }
        public string NounTwo { get; set; }
        public string NounThree { get; set; }
        public string NounFour { get; set; }
        public string NounFive { get; set; }
        public string NounSix { get; set; }
        public string Nationality { get; set; }
        public string AdjectiveOne { get; set; }
        public string AdjectiveTwo { get; set; }
        public string AdjectiveThree { get; set; }
        public string AdjectiveFour { get; set; }
        public string AdjectiveFive { get; set; }
        public string AdjectiveSix { get; set; }
        public string AdjectiveSeven { get; set; }
        public string FoodOne { get; set; }
        public string FoodTwo { get; set; }
        public string Liquid { get; set; }
        public string OccNumOne { get; set; }
        public string OccNumTwo { get; set; }
        public string VerbOne { get; set; }
        public string VerbTwo { get; set; }
        public string VerbThree { get; set; }
        public string VerbFour { get; set; }
        public string ActionVerbOne { get; set; }
        public string ActionVerbTwo { get; set; }
        public string Person { get; set; }
        public string PlaceOne { get; set; }
        public string PlaceTwo { get; set; }
        public string Shapes { get; set; }
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
            string madLibTwo = $"\n" +
                 $"\n" +
                 $"\n" +
                 $"\t\t\tROAD TRIP WITH MY FRIEND\n" +
                 $"\n" +
                 $"On the {AdjectiveOne} trip to {PlaceOne}, my {AdjectiveTwo} friend\n" +
                 $" and I decided to invent a game. Since this would be a rather \n" +
                 $"{AdjectiveThree} trip, it would need to be a game with \n" +
                 $"{PluralNounOne} and {PluralNounTwo}. Using our {NounOne} to \n" +
                 $"{VerbOne}, we tried to get the {NounTwo} next to us to play\n" +
                 $" too, but they just {VerbTwo}ed at us and {ActionVerbOne} a \n" +
                 $"way. After a few rounds, we thought the game could use some\n" +
                 $" {PluralNounThree} so we turned on the {NounThree} and started\n" +
                 $" {VerbThree} to the {NounFour} that came on. This lasted for\n" +
                 $" {Time} before I got {AdjectiveFour} and decided to {ActionVerbTwo}.\n" +
                 $" I'll never {VerbFour} that trip, it was the {AdjectiveFive}\n" +
                 $" road trip of my {PossessiveNounOne}.\n" +
                 $"\n" +
                 $"\n" +
                 $"\t\t\tNICE JOB!";

            return madLibTwo;
        }

        public string MadLibThree()
        {
            string madLibThree = $"\n" +
                $"\n" +
                $"\n" +
                $"\t\t\tPIZZA PIZZA\n" +
                $"\n" +
                $"Pizza was invented by a {AdjectiveOne} {Nationality} chef named\n" +
                $" {Person}. To make pizza, you need to take a lump of {NounOne},\n" +
                $" and make a thin, round {AdjectiveTwo} {NounTwo}. Then you cover\n" +
                $" it with {AdjectiveThree} sauce, {AdjectiveFour} cheese, and fresh\n" +
                $" chopped {PluralNounOne}. Next you have to bake it in a very hot\n" +
                $" {NounThree}. When it is done, cut it into {NumOne} {Shapes}.\n" +
                $" Some kids like {FoodOne} pizza the best, but my favorite is the\n" +
                $" {FoodTwo} pizza. If I could, I would eat pizza {NumTwo} times a day!\n" +
                $"\n" +
                $"\n" +
                $"\t\t\tNICE JOB!";

            return madLibThree;
        }

        public string MadLibFour()
        {
            string madLibFour = $"\n" +
                $"\n" +
                $"\n" +
                $"\t\t\tFIRST DATES\n" +
                $"\n" +
                $"The best first dates involve grand romatic {PluralNounOne} like these:\n" +
                $"Charter a private {NounOne} and fly to (the) {PlaceOne}, also known as\n" +
                $"the {NounTwo} of Love, for a/an {NumOne}-course dinner followed by a \n" +
                $"moonlit ride in a/an {NounThree} along the canals. Prepare a/an\n" +
                $"{AdjectiveOne} gourmet picnic complete with a/an ${NumTwo} bottle of\n" +
                $"{Liquid} and a quartet serenading you with {AdjectiveTwo} songs.\n" +
                $"Rent a space on the Jumbo-{NounFour} during a/an {NounFive}-ball game\n" +
                $"and post a super {AdjectiveThree} message like Glad we're {VerbOne}\n" +
                $"together here today!Send a bouquet of long-stemmed red {PluralNounTwo}\n" +
                $"before and after the date, and for good measure, send one to the\n" +
                $"{AdjectiveFour} restaurant where you're wining and {VerbTwo} your date.\n" +
                $"Take a nighttime hot-air {NounSix} ride to check out the stars.\n" +
                $"\n" +
                $"\n" +
                $"\t\t\tNICE JOB!";

            return madLibFour;
        }

        public string MadLibFive()
        {
            string madLibFive = $"\n" +
                $"\n" +
                $"\n" +
                $"\t\t\tWHAT HAPPENS WHEN A UNICORN POOPS?\n" +
                $"\n" +
                $"Unicorns aren't like other {PluralNounOne}; they're {AdjectiveOne}.\n" +
                $"They look like {PluralNounTwo}, with {PluralNounThree} for feet and\n" +
                $"a/an {AdjectiveTwo} mane of hair. But unicorns are {Color} and have a\n" +
                $"{AdjectiveThree} {NounOne} on their heads. Some {PluralNounFour}\n" +
                $"don't believe unicorns are {AdjectiveFour} but I believe in them.\n" +
                $"I would love to {VerbOne} a unicorn faraway {PluralNounFive}.\n" +
                $"One thing I've always {VerbTwo} about is whether unicorns\n" +
                $"{VerbThree} rainbows, or is their {NounTwo} {AdjectiveFive}\n" +
                $"like any other animal's?\n" +
                $"\n" +
                $"\n" +
                $"\t\t\tNICE JOB!";
            return madLibFive;
        }
    }
}
