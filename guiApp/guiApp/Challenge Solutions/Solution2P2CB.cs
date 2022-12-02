using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guiApp.Challenge_Solutions
{
    internal class Solution2P2CB : structs.SolutionBase
    {
        public override string Name => "Day 2 part 2 CB";

        public override string Creator => "CB";

        public override string Solve(string input)
        {
            Dictionary<string, int> Scores = MakeScores();
            int Total = 0;
            foreach (var round in input.Split("\n"))
            {
                Total += Scores.GetValueOrDefault(round);
            }
            return Total.ToString();
        }

        private Dictionary<string, int> MakeScores()
        {
            var Dict = new Dictionary<string, int>();
            Dict.Clear();
            Dict.Add("A X", (3 + 0));//rock,lose=scissors
            Dict.Add("A Y", (1 + 3));//rock,draw=rock
            Dict.Add("A Z", (2 + 6));//rock,win=paper

            Dict.Add("B X", (1 + 0));//paper,lose=rock
            Dict.Add("B Y", (2 + 3));//paper,draw=paper
            Dict.Add("B Z", (3 + 6));//paper,win=scissors
            
            Dict.Add("C X", (2 + 0));//scissors,lose=paper
            Dict.Add("C Y", (3 + 3));//scissors,draw=scissors
            Dict.Add("C Z", (1 + 6));//scissors,win=rock
            return Dict;
        }
    
    }
}
