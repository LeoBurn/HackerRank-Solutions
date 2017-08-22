using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.Algorithms.Strings
{
    public class HackerRankInAString
    {
        public string Run(string s)
        {
            string find = "hackerrank";
            int idx = 0;
            foreach (var charValue in s)
            {
                if (charValue == find[idx])
                {
                    idx++;
                }
                if (idx == find.Length - 1)
                    break;
            }

            return idx == find.Length - 1 ? "YES" : "NO";
        }
    }
}
