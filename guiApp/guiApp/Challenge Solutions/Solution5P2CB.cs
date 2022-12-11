using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guiApp.Challenge_Solutions
{
    internal class Solution5P2CB : structs.SolutionBase
    {
        public override string Name => "Day 5 Part 2 CB";

        public override string Creator => "CB";

        public override string Solve(string input)
        {
            //Cargo container stack string parsing
            //converts to an array of Stack<char> since that seemed the closest to the problem at hand
            string[] RawData = input.Split("\n\n");
            int columns = int.Parse(RawData[0][RawData[0].Length - 2].ToString());
            string[] rows = RawData[0].Split("\n");
            Stack<char>[] stack = new Stack<char>[columns];
            for (int i = 0; i < columns; i++)
            {
                stack[i] = new Stack<char>();
            }



            for (int i = rows.Length - 2; i >= 0; i--)
            {
                int columnIndex = 0;
                for (int c = 0; c < rows[i].Length; c++)
                {
                    switch (c % 4)
                    {
                        case (0):
                            break;
                        case (1):
                            if (rows[i][c] != ' ')
                            {
                                stack[columnIndex].Push(rows[i][c]);
                            }
                            columnIndex++;
                            break;
                        case (2):
                            break;
                        case (3):
                            break;
                    }
                }
            }

            //movement command parsing, each command has 3 parts: repeat count, target column, and destination column
            List<int[]> commands = new List<int[]>();
            string[] lines = RawData[1].Split("\n");
            for (int i = 0; i < lines.Length; i++)
            {
                int repeat = int.Parse(lines[i].Split(' ')[1]);
                int target = int.Parse(lines[i].Split(' ')[3]);
                int destination = int.Parse(lines[i].Split(' ')[5]);
                commands.Add(new int[] { repeat, target - 1, destination - 1 });//subtrack by one, since input expects to start at 1 instead of 0
            }

            //Apply Movement commands to Stacks, now with an additional crane stack!
            Stack<char> crane = new Stack<char>();
            for (int i = 0; i < commands.Count; i++)
            {
                for (int x = 0; x < commands[i][0]; x++)
                {
                    crane.Push(stack[commands[i][1]].Pop());
                }
                while (crane.Any())
                {
                    stack[commands[i][2]].Push(crane.Pop());
                }
            }


            string output = "";
            for (int i = 0; i < stack.Length; i++)
            {
                output += stack[i].Peek();
            }
            return output;
        }
    }
}
