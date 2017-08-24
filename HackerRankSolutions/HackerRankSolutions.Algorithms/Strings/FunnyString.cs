using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.Algorithms.Strings
{
    public class FunnyString
    {
        public string Run(string s)
        {

            for(int beginIdx = 1, endIdx = s.Length - 2; beginIdx < s.Length && endIdx >= 0;beginIdx++,endIdx--)
            {
                var firstValue = Math.Abs(s[beginIdx] - s[beginIdx - 1]);
                var lastValue = Math.Abs(s[endIdx] - s[endIdx + 1]);

                if (firstValue != lastValue)
                    return "Not Funny";
                
                

            }
            return "Funny";
        }
    }
}
