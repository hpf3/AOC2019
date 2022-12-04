using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guiApp.Challenge_Solutions
{
    internal class Solution3CB : structs.SolutionBase
    {
        public override string Name => "Day 3 Part 1 CB";

        public override string Creator => "CB";

        private List<char> letterNumber = new List<char>
        {
            'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',
            'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'
        };
        public override string Solve(string input)
        {
            int total = 0;
            foreach (var bag in input.Split("\n"))
            {
                int bagTotal = 0;
                char[] compartment1=new char[(bag.Length / 2)];
                char[] compartment2 = new char[bag.Length-(bag.Length / 2)];
                bag.CopyTo(0,compartment1,0,compartment1.Length);
                bag.CopyTo(compartment1.Length, compartment2, 0, compartment2.Length);
                foreach (var intersect in compartment1.Intersect(compartment2))
                {
                    bagTotal+=letterNumber.FindIndex((x) => (x == intersect))+1;
                }
                total += bagTotal;
            }
            return total.ToString();
        }
    }
}
