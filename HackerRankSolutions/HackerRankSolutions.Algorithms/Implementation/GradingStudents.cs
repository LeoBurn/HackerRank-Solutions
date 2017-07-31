using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.Algorithms.Implementation
{
    public class GradingStudents
    {
        public int[] Run(int[] grades)
        {
            int[] result = new int[grades.Length];
            for (int i = 0; i < grades.Length; i++)
            {
                result[i] = Rounded(grades[i]);
            }
            return result;
        }

        public int Rounded(int number)
        {
            var multipleOfFive = 0;
            var ResultOfMultipleFive = 0;
            if (number >= 38)
            {
                multipleOfFive = number%5 == 0 ? number/5 : (number/5) + 1;
                ResultOfMultipleFive = multipleOfFive * 5;
                if (ResultOfMultipleFive - number < 3)
                    return ResultOfMultipleFive;
            }
            return number;
        }
    }
}
