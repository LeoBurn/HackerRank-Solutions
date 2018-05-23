using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.CrakingTheCodingInterview
{
    public class MakingAnagrams
    {
        //O(N) + O(N) + O(26) = O(N)
        public int Run(string s1,string s2)
        {
            var alphabet = new int?[26];
            s1 = s1.ToLower();
            s2 = s2.ToLower();

            foreach(var ch in s1)
            {
                var idx = ch - 'a';
                var value = alphabet[idx] == null ? 1 : ++alphabet[idx];
                alphabet[idx] = value;
            }

            foreach (var ch in s2)
            {
                var idx = ch - 'a';
                var value = alphabet[idx] == null ? -1 : --alphabet[idx];
                alphabet[idx] = value;
            }

            return alphabet.Sum(number => Math.Abs(number ?? 0));
        }
    }
}
