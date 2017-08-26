using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.Algorithms.Search
{
    public class MissingNumbers
    {
        public int[] Run(int[] a, int[] b)
        {
            int[] freqMap = new int[10001];

            for (int i = 0; i < a.Length; i++)
                freqMap[a[i]]--;
            
            for (int i = 0; i < b.Length; i++)
                freqMap[b[i]]++;
            
            return Enumerable.Range(0, freqMap.Length)
            .Where(p => freqMap[p] > 0).ToArray();
        }
    }
}
