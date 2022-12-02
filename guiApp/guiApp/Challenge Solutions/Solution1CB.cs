using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guiApp.Challenge_Solutions
{
    public class Solution1CB : structs.SolutionBase//using the interface solution base forces you to have its two members, but allows the class to be grouped with other classes that also use the interface
    {
        public override string Name => "Solution1 CB";

        public override string Creator => "CB";

        public override string Solve(string input)
        {
            int highest = 0;
            foreach (var elf in input.Split("\n\n"))//split the string on each paragraph, and process each one
            {
                int ElfCalories = 0;
                foreach (var ration in elf.Split("\n"))//split paragraphs into lines
                {
                    ElfCalories+= int.Parse(ration);
                }
                if (ElfCalories>highest)
                {
                    highest = ElfCalories;
                }
            }


            return highest.ToString();//finaly return the highest after processing
        }
    }
}
