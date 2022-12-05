using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guiApp.Challenge_Solutions
{
    internal class Solution4CB : structs.SolutionBase
    {
        public override string Name => "Day 4 Part 1 CB";

        public override string Creator => "CB";

        public override string Solve(string input)
        {
            int count = 0;
            foreach (var group in input.Split("\n"))
            {
                string[] people = group.Split(",");
                int[,] zones = new int[2, 2];
                zones[0,0] = int.Parse(people[0].Split("-")[0]);
                zones[0, 1] = int.Parse(people[0].Split("-")[1]);
                zones[1, 0] = int.Parse(people[1].Split("-")[0]);
                zones[1, 1] = int.Parse(people[1].Split("-")[1]);

                if ((zones[0,0] <= zones[1,0] && zones[0,1] >= zones[1,1]) || (zones[0, 0] >= zones[1, 0] && zones[0, 1] <= zones[1, 1]))
                {
                    count++;
                }
            }
            return count.ToString();
        }
    }
}
