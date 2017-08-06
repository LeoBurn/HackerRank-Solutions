using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.Algorithms.Warmup
{
    public class BirthdayCakeCandles
    {
        public int Run(int[] candles)
        {
            var biggestCandle = 0;
            var counter = 0;
            for (int i = 0; i < candles.Length; ++i)
            {
                if (candles[i] > biggestCandle)
                {
                    biggestCandle = candles[i];
                    counter = 0;
                }
                if (candles[i] == biggestCandle)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
}
