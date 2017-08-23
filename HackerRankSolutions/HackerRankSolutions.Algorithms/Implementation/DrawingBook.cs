using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.Algorithms.Implementation
{
    public class DrawingBook
    {
        public int Run(int n, int p)
        {
            int begin = p / 2;
            int end = (n % 2 == 0 && p % 2 != 0) ? ((n - p) / 2) + 1 : (n - p) / 2;
            return begin > end ? end : begin;
        }
    }
}
