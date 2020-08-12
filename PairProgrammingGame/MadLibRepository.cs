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
        public string PlurlNounOne { get; set; }
        public string PlurlNounTwo { get; set; }
        public string NounNumOne { get; set; }
        public string NounNumTwo { get; set; }
        public string NounNumThree { get; set; }
        public string NounNumFour { get; set; }
        public string AdjNumOne { get; set; }
        public string AdjNumTwo { get; set; }
        public string AdjNumThree { get; set; }
        public string AdjNumFour { get; set; }
        public string AdjNumFive { get; set; }
        public string AdjNumSix { get; set; }
        public string OccNumOne { get; set; }
        public string OccNumTwo { get; set; }
        public string VerbOne { get; set; }
        public string VerbTwo { get; set; }
        public string VerbThree { get; set; }
        public string PlaceOne { get; set; }
        public string PlaceTwo { get; set; }
        public string AddLibOne()
        {
            string libOne = $"MY IDEAL PRESIDENT\n" +
                $"\n" +
                $"\t There are {NumOne} qualities I admire in a leader.\n" +
                $"\t First, he or she must be {AdjNumOne} Because {VerbOne} \n" +
                $"\t the {NounNumTwo} is a sign of {AdjNumOne} character.\n" +
                $"\t Second, a good President should be {AdjNumTwo}, always making\n " +
                $"\t sure people feel {AdjNumThree} and {AdjNumFour}.Third, a President\n" +
                $"\t represents our Country around the {PlaceOne} and should be \n" +
                $"\t {AdjNumFive} when {VerbTwo} with other world {PlurlNounOne}.Strength \n" +
                $"\t of {NounNumThree}, a good sense of {NounNumFour}, and {AdjNumSix}\n" +
                $"\t leadership are all things my ideal president would have.";

            return libOne;
        }
    }
}
