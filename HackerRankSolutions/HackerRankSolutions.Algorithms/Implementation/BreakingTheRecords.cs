using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.Algorithms.Implementation
{
    public class BreakingTheRecords
    {
        public class Points
        {
            public int MinCounter { get; set; }
            public int MaxCounter { get; set; }
        }    

        public Points Run(int[] arr, int n)
        {
            int minCounter = 0;
            int min = arr[0];
            int maxCounter = 0;
            int max = arr[0];

            for (int i = 1; i < n; ++i)
            {
                var value = arr[i];
                if (value > max)
                {
                    max = value;
                    maxCounter++;
                }
                if (value < min)
                {
                    min = value;
                    minCounter++;
                }
            }
            return new Points() {MaxCounter = maxCounter, MinCounter = minCounter};
        }
        
    }
}
