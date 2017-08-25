using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.Algorithms.Implementation
{
    public class BetweenTwoSets
    {
        public int Run(int[] a, int[] b)
        {
            var maxElementInA = a.Max();
            var xValues = maxElementInA;
            var elementCounter = 0;

            xValues = lcm(a);

            for (; xValues <= b[0]; xValues += maxElementInA)
            {
                if (b.All(p => p % xValues == 0))
                    elementCounter++;
            }

            return elementCounter;
        }

        private static int gcd(int a, int b)
        {
            while (b > 0)
            {
                int temp = b;
                b = a % b; // % is remainder
                a = temp;
            }
            return a;
        }

        private static int gcd(int[] input)
        {
            int result = input[0];
            for (int i = 1; i < input.Length; i++)
            {
                result = gcd(result, input[i]);
            }
            return result;
        }

        private static int lcm(int a, int b)
        {
            return a * (b / gcd(a, b));
        }

        private static int lcm(int[] input)
        {
            int result = input[0];
            for (int i = 1; i < input.Length; i++)
            {
                result = lcm(result, input[i]);
            }
            return result;
        }
    }
}
