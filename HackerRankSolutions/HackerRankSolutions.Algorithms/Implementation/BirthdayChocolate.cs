using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.Algorithms.Implementation
{
    public class BirthdayChocolate
    {
        public int Run(int n, int[] s, int d, int m)
        {
            int minIdx = 0;
            int maxIdx = 0;
            int counter = 0;
            int sum = 0;

            if (m > n) return 0;

            for (int i = 0; i < n; ++i)
            {
                //First Time
                if ((maxIdx - minIdx) != m && minIdx == 0)
                {
                    sum += s[i];
                    maxIdx = i;
                }

                if ((maxIdx - minIdx) + 1 == m)
                {
                    if (sum == d)
                        counter++;
                    if (maxIdx < n - 1)
                    {
                        sum -= s[minIdx];
                        minIdx++;
                        maxIdx++;
                        sum += s[maxIdx];
                    }
                }
            }
            return counter;
        }
    }
}
