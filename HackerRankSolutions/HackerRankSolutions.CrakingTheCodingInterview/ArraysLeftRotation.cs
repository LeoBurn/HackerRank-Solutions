using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.CrakingTheCodingInterview
{
    public class ArraysLeftRotation
    {
        //O(n * 2) = O(N)
        public int[] Run(int[] arr, int n, int rotate)
        {
            int[] copy = new int[n];
            Array.Copy(arr, copy, n);

            for(int i =0; i < n; ++i)
            {

                var idx = i - (rotate % n);
                if (idx < 0)
                    idx = n + idx;
                arr[idx] = copy[i];
            }

            return arr;
        }
    }
}
