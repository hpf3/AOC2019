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
            int highest1 = 0;
            int highest2 = 0;
            int highest3 = 0;
            foreach (var elf in input.Split("\n\n"))//split the string on each paragraph, and process each one
            {
                int ElfCalories = 0;
                foreach (var ration in elf.Split("\n"))//split paragraphs into lines
                {
                    ElfCalories += int.Parse(ration);
                }
                if (ElfCalories > highest1)
                {
                    highest3 = highest2;
                    highest2 = highest1;
                    highest1 = ElfCalories;
                }
                else if (ElfCalories > highest2)
                {
                    highest3 = highest2;
                    highest2 = ElfCalories;
                }
                else if (ElfCalories > highest3)
                {
                    highest3 = ElfCalories;
                }
            }


            return (highest1+ highest2+ highest3).ToString();//finaly return the highest after processing
        }
    }
}
