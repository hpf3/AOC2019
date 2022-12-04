using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guiApp.Challenge_Solutions
{
    internal class Solution3P2CB:structs.SolutionBase
    {
        public override string Name => "Day 3 Part 2 CB";

        public override string Creator => "CB";

        private List<char> letterNumber = new List<char>
        {
            'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',
            'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'
        };
        public override string Solve(string input)
        {
            int total = 0;
            string[] bags = input.Split("\n");
            for (int i = 0; i < bags.Length; i+=3)
            {
                char badge = bags[i].Intersect(bags[i + 1]).Intersect(bags[i + 2]).First();
                total+= letterNumber.FindIndex((x) => (x == badge)) + 1;
            }
            return total.ToString();
        }
    }
}
