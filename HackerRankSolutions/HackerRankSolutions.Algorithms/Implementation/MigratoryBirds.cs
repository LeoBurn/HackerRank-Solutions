using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.Algorithms.Tests.Implementation
{
    public class MigratoryBirds
    {
        public int Run(int[] ar,int n)
        {
            int[] types = new int[5];
            for (int i = 0; i < n; i++)
            {
                types[ar[i] - 1]++;
            }

            int max = 0;
            int type= 0;
            for (int i = 0; i < types.Length; ++i)
            {
                if (max < types[i])
                {
                    max = types[i];
                    type = i+1;
                }
                    
            }

            return type;
        }
    }
}
