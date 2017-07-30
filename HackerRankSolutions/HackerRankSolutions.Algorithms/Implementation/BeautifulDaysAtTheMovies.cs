using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.Algorithms.Implementation
{
    public class BeautifulDaysAtTheMovies
    {
        public int Run(int i,int j,int k)
        {
            int beautifulDayCounter = 0;
            for (; i <= j; ++i)
            {
                var result = (i - Reverse(i))%k;
                if (result == 0)
                    beautifulDayCounter++;
            }
            return beautifulDayCounter;
        }

        public int Reverse(int n)
        {
            int result = 0;
            while (n >0)
            {
                result = result * 10;
                result = result + n%10;
                n = n/10;
            }
            return result;
        }
    }
}
