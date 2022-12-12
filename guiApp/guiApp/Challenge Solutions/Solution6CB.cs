using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guiApp.Challenge_Solutions
{
    internal class Solution6CB : structs.SolutionBase
    {
        public override string Name => "Day 6 Part 1 CB";

        public override string Creator => "CB";

        public override string Solve(string input)
        {
            return get_unique(input, 4);
            
        }
        private string get_unique(string input,int size)
        {
            char[] chars = new char[size];
            for (int i = 0; i < input.Length; i++)
            {
                if (i > 3 && chars.Distinct().Count() == size)
                {
                    return (i).ToString();
                }
                chars[i % size] = input[i];
            }
            return $"Failed to find unique sequence of {size}";
        }
        public override void Test(string input)
        {
            Windows.UI.Popups.MessageDialog dialog = new Windows.UI.Popups.MessageDialog(get_unique(input, 6));
            dialog.ShowAsync();
        }
    }
}
