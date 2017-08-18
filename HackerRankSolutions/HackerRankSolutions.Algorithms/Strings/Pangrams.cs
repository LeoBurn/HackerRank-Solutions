using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HackerRankSolutions.Algorithms.Strings
{
    public class Pangrams
    {
        public string Run(string s)
        {
            s = new String(s.Where(Char.IsLetter).ToArray()).ToLower();
            var chars = new int[26];

            foreach (var charValue in s)
            {
                chars[((int) (charValue - 'a'))]++;
            }

            return chars.Any(p => p == 0) ? "not pangram" : "pangram";
        }
    }
}
