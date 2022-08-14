using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guiApp.structs
{
    public interface SolutionBase
    {
        string GetCreator();//return your name
         string Solve(string input);//input will be raw text with /n and all
    }
}
