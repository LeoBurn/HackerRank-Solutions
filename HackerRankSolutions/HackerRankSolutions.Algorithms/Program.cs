using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HackerRankSolutions.Algorithms.BitManipulation;
using HackerRankSolutions.Algorithms.Implementation;
using HackerRankSolutions.Algorithms.Search;

namespace HackerRankSolutions.Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            MaximizingXor runner = new MaximizingXor();
            runner.Run(10, 15);
            int value = 2;
            var result = (1 << 2+1)-1;
        }
    }
}
