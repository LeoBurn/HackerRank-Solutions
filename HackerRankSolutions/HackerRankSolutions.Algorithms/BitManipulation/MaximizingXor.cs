using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.Algorithms.BitManipulation
{
    public class MaximizingXor
    {
        public int Run(int a,int b)
        {
            int xoredResult = a ^ b;
            int maximumBit = GetMaximumBit(xoredResult);
            var result = (1 << maximumBit) - 1;
            return result;
        }

        private int GetMaximumBit(int number)
        {
            return Convert.ToString(number, 2).Length;
        }
    }
}
