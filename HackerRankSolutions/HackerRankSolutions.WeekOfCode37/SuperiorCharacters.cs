using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.WeekOfCode37
{
    public class SuperiorCharacters
    {
        public void Run(int[][] matrix , int numberOfLines)
        {
            
        }

        public long MaximumSuperiorCharacters(int[] words, int numberOfLines)
        {
            int totalChars = words.Sum(p => p);
            int numberOfCombinations = ((int)Math.Round((totalChars / (double)2), 0, MidpointRounding.AwayFromZero))-1 ;
            int numberOfDiferentChars = words.Count(p => p > 0);
            int morechars = words.Max(p => p);

            if (numberOfDiferentChars <= 1 && totalChars <= 2)
                return 0;

            if ((totalChars / 2) < morechars)
            {
                var mid = totalChars / 2;
                var diffMidToMoreChars = morechars - mid;
                return numberOfCombinations - diffMidToMoreChars;
            }

            if (numberOfDiferentChars == 2)
            {
                int left = words.First(p => p > 0);
                int right = words.Last(p => p > 0);
                if (left <= right)
                    return left - 1;
                return right;
            }


            return numberOfCombinations;
        }


   


        //*************************************************************************
        //This is CopyWrite Code Not Mine
        //https://stackoverflow.com/questions/26311984/permutation-and-combination-in-c-sharp
        public long nCr(int n, int r)
        {
            // naive: return Factorial(n) / (Factorial(r) * Factorial(n - r));
            return nPr(n, r) / Factorial(r);
        }

        public static long nPr(int n, int r)
        {
            // naive: return Factorial(n) / Factorial(n - r);
            return FactorialDivision(n, n - r);
        }

        private static long FactorialDivision(int topFactorial, int divisorFactorial)
        {
            long result = 1;
            for (int i = topFactorial; i > divisorFactorial; i--)
                result *= i;
            return result;
        }

        private  long Factorial(int i)
        {
            if (i <= 1)
                return 1;
            return i * Factorial(i - 1);
        }

        //******************************************************************************
    }
}
