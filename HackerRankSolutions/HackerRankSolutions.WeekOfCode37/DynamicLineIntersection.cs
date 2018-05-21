using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.WeekOfCode37
{
    public class DynamicLineIntersection
    {
        public class Line
        {
            public int M { get; set; }
            public int B { get; set; }
            public int NumberOfTimes { get; set; }
        }

        public List<int> Run(string[] operations, int numberOfLines)
        {
            List<Line> lines = new List<Line>();
            List<int> result = new List<int>();

            foreach (var operation in operations)
            {
                var columns = operation.Split(' ');
                if(columns[0] == "+")
                    lines.Add(new Line(){M = Int32.Parse(columns[1]), B = Int32.Parse(columns[2]) });
                if (columns[0] == "-")
                {
                    var single = lines.FirstOrDefault(p =>
                        p.M == Int32.Parse(columns[1]) && p.B == Int32.Parse(columns[2]));
                    if (single != null)
                        lines.Remove(single);
                }

                if (columns[0] == "?")
                {
                    result.Add(IntersectLines(lines, new Line() {B = Int32.Parse(columns[1]), M = 0}));
                }
            }
            return result;


        }

        public int IntersectLines(List<Line> lines, Line line)
        {
            int sum = 0;
            foreach (var actualLine in lines)
            {
                var p = actualLine.M - line.M;
                var d = line.B - actualLine.B;
                var xIsInter = d % p == 0;
                if (xIsInter)
                    sum++;
            }
            return sum;
        }
    }

    
}
