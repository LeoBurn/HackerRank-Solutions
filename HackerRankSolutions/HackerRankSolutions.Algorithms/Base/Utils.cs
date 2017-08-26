using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.Algorithms.Base
{
    public class Utils
    {
        public void ReadFromStdIn(string[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int aSize = Convert.ToInt32(tokens_n[0]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            tokens_n = Console.ReadLine().Split(' ');
            int bSize = Convert.ToInt32(tokens_n[0]);
            string[] b_temp = Console.ReadLine().Split(' ');
            int[] b = Array.ConvertAll(b_temp, Int32.Parse);
        }
    }
}
