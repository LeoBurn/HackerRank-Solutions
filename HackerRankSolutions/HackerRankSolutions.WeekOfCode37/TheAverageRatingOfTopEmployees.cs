using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.WeekOfCode37
{
    public class TheAverageRatingOfTopEmployees
    {
        public double Run(int [] rating, int numOfElements)
        {
            int sum = 0;
            int counter = 0;
            for (int idx = 0; idx < numOfElements; ++idx)
            {
                if (rating[idx] >= 90)
                {
                    sum += rating[idx];
                    counter++;
                }
            }

            return Math.Round((sum/(double)counter), 2, MidpointRounding.AwayFromZero);
        }
    }
}
