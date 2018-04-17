using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.WeekOfCode37
{
    public class SimpleLanguage
    {
        public long Run(string[] lines , int numeOfLines)
        {
            long actualValue = 0;
            long max = 0;
            for (int i = 0; i < numeOfLines; ++i)
            {
                var line = lines[i];

                var operations = line.Split(' ');
                if (operations[0].Equals("add", StringComparison.InvariantCultureIgnoreCase))
                {
                    var value = long.Parse(operations[1]);
                    if (value > 0)
                        actualValue += value;

                }
                if (operations[0].Equals("set", StringComparison.InvariantCultureIgnoreCase))
                {
                    var value = long.Parse(operations[1]);
                    if (value > actualValue)
                        actualValue = long.Parse(operations[1]);
                }

                if (actualValue > max)
                    max = actualValue;
            }
            return max;
        }
    }
}
