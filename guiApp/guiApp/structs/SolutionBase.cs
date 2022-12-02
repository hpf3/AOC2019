using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guiApp.structs
{
    public abstract class SolutionBase
    {
        /// <summary>
        /// return solution name
        /// </summary>
        public abstract string Name { get; }
        /// <summary>
        /// return your name
        /// </summary>
        public abstract string Creator { get; }
        /// <summary>
        /// input will be raw text with /n and all
        /// </summary>
        /// <param name="input">raw challenge input</param>
        /// <returns>solution output</returns>
        public abstract string Solve(string input);

        /// <summary>
        /// Allows solution to perform a test function (like calculating a dictionary), any output will be handled by the solution.
        /// </summary>
        /// <param name="input">raw challenge input</param>
        public virtual void Test(string input)
        {
            throw new NotImplementedException();
        }
    }
}
