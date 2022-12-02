using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guiApp.Challenge_Solutions
{
    internal class Solution2CB : structs.SolutionBase
    {
        public override string Name => "Solution 2 CB";

        public override string Creator => "CB";
        /// <summary>
        /// col1(oponent):
        ///   A=Rock
        ///   B=Paper
        ///   C=Scissors
        /// 
        /// col2(counter):
        ///   X=Rock
        ///   Y=Paper
        ///   Z=Scissors
        /// 
        /// score:
        ///   Rock=1
        ///   Paper=2
        ///   Scissors=3
        ///   result:
        ///     Lose=0
        ///     draw=3
        ///     win=6
        ///add type to result for round, sum all rounds
        /// 
        /// </summary>
        public override string Solve(string input)
        {
            Dictionary<string, int> Scores = MakeScores();
            int Total = 0;
            foreach (var round in input.Split("\n"))
            {
                Total+= Scores.GetValueOrDefault(round);
            }
            return Total.ToString();
        }
        private Dictionary<string,int> MakeScores()
        {
            var Dict = new Dictionary<string, int>();
            Dict.Clear();
            Dict.Add("A X", 4);
            Dict.Add("A Y", 8);
            Dict.Add("A Z", 3);
            Dict.Add("B X", 1);
            Dict.Add("B Y", 5);
            Dict.Add("B Z", 9);
            Dict.Add("C X", 7);
            Dict.Add("C Y", 2);
            Dict.Add("C Z", 6);
            return Dict;
        }


    }
}
