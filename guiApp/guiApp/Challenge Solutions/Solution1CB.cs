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
            int total = 0;
            foreach (var item in input.Split("\n"))//split the string on each line, and process each one
            {
                double value = double.Parse(item);//convert the string to double instead of int, since double allows decimals and we are doing division
                total += (int)(Math.Floor(value / 3) - 2);//after the required math we need to force the double->int conversion since int holds less data than double
            }


            return total.ToString();//finaly return the total after processing
        }
    }
}
