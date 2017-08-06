using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.Algorithms.Warmup
{
    public class MiniMaxSum
    {
        public void Run(int[] values)
        {
            BigInteger maxSum = 0;
            BigInteger minSum = 0;

            for (var i = 0; i < 5; ++i)
            {
                var subValues = values.ToList();
                subValues.RemoveAt(i);
                var sum = Sum(subValues);
                if (sum > maxSum)
                    maxSum = sum;
                if (sum < minSum || minSum == 0)
                    minSum = sum;
            }
        }

        //Because the Output Can Be greater than int
        public BigInteger Sum(List<int> values)
        {
            return values.Aggregate<int, BigInteger>(0, (current, value) => current + value);
        }
    }
}
