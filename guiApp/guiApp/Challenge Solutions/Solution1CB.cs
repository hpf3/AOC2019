using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guiApp.Challenge_Solutions
{
    public class Solution1CB : structs.SolutionBase//using the interface solution base forces you to have its two members, but allows the class to be grouped with other classes that also use the interface
    {
        public string GetCreator()//this allows the gui to show the name of who made it.
        {
            return "CB";
        }

        public string Solve(string input)//this will be called to solve the problem
        {
            throw new NotImplementedException();
        }
    }
}
