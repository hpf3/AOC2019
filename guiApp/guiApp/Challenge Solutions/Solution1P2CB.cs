using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guiApp.Challenge_Solutions
{
    internal class Solution1P2CB : structs.SolutionBase
    {
        public override string Name => "Solution1 part2 CB";

        public override string Creator => "CB";

        public override string Solve(string input)
        {
            int total = 0;
            foreach (var item in input.Split("\n"))//split the string on each line, and process each one
            {
                double moduleFuel = 0;
                double current = double.Parse(item);
                while (current >= 9)
                {
                    current =(Math.Floor(current / 3) - 2);
                    moduleFuel += current;
                }
                total+=(int)moduleFuel;
            }


            return total.ToString();//finaly return the total after processing
        }
    }
}
