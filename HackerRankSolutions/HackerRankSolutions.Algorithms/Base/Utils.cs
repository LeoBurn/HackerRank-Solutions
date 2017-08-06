using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.Algorithms.Base
{
    public class Utils
    {
        public void ReadFromStdIn(string[] args)
        {
            string[] tokens_s = Console.ReadLine().Split(' ');
            int numberOfColumns = Convert.ToInt32(tokens_s[0]);
            int numberOfLine = Convert.ToInt32(tokens_s[1]);
            int numberOfTrains = Convert.ToInt32(tokens_s[2]);
            int[][] grid = new int[numberOfTrains][];

            for (int i = 0; i < numberOfTrains; ++i)
            {
                tokens_s = Console.ReadLine().Split(' ');
                var line = Convert.ToInt32(tokens_s[0]);
                var begin = Convert.ToInt32(tokens_s[1]);
                var end = Convert.ToInt32(tokens_s[2]);
                grid[i] = new int[] {line, begin, end};
            }

        }
    }
}
