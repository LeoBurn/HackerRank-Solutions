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
            int i = Convert.ToInt32(tokens_s[0]);
            int j = Convert.ToInt32(tokens_s[1]);
            int k = Convert.ToInt32(tokens_s[2]);
        }
    }
}
