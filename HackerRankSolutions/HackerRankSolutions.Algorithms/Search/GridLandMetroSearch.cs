using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.Algorithms.Search
{
    public class GridLandMetroSearch
    {
        public class Interval
        {
            public int Begin { get; set; }
            public int End { get; set; }
            public bool IsMerged { get; set; }
        }

        public BigInteger Run(BigInteger numberOflines, BigInteger numberOfColumns, int[][] trains)
        {
            var lines = new Dictionary<int, List<Interval>>();
            //Get All Intervals By Line
            foreach (int[] t in trains)
            {
                var line = t[0];
                if (!lines.ContainsKey(line))
                    lines.Add(line, new List<Interval>());
                lines[line].Add(new Interval() { Begin = t[1], End = t[2] });
            }

            var mergedLines = new Dictionary<int, List<Interval>>();
            //Merge Intervals

            foreach (var line in lines)
            {
                var intervalsInLineList = line.Value;
                var mergedLine = MergeOneLine(intervalsInLineList);
                mergedLines.Add(line.Key, mergedLine);

            }

            //Count
            BigInteger NumberOfRows = numberOflines * numberOfColumns;
            long cellFiled = 0;
            foreach (var line in mergedLines)
            {
                Console.WriteLine($"Line -> {line.Key.ToString("#,#", CultureInfo.InvariantCulture)}");
                foreach (var interval in line.Value)
                {

                    var cellFilledInLine = (interval.End - interval.Begin) + 1;
                    Console.WriteLine($"\t Trains -> {cellFilledInLine.ToString("#,#", CultureInfo.InvariantCulture)} || Empty {(numberOfColumns - cellFilledInLine).ToString("#,#", CultureInfo.InvariantCulture)}");
                    cellFiled += cellFilledInLine;
                }
                Console.WriteLine($"Tolta Sum : {cellFiled.ToString("#,#", CultureInfo.InvariantCulture)} || Empty {(NumberOfRows - cellFiled).ToString("#,#", CultureInfo.InvariantCulture)}");
            }
            return NumberOfRows - cellFiled;
        }

        public List<Interval> MergeOneLine(List<Interval> interval)
        {
            var mergedLine = new List<Interval>();
            for (var i = 0; i < interval.Count; ++i)
            {

                if (!interval[i].IsMerged)
                {
                    Interval merged = interval[i]; // Always One or More
                    for (var j = i + 1; j < interval.Count; ++j)
                    {
                        var mergedScope = MergeIntervals(merged, interval[j]);
                        if (mergedScope != null)
                        {
                            interval[j].IsMerged = true;
                            merged = mergedScope;
                        }
                    }
                    mergedLine.Add(merged);
                }

            }
            return mergedLine;
        }

        public Interval MergeIntervals(Interval one, Interval two)
        {
            Interval mergeInterval = null;
            if (ItsOverlap(one, two))
                mergeInterval = new Interval() { Begin = Math.Min(one.Begin, two.Begin), End = Math.Max(one.End, two.End) };
            return mergeInterval;
        }

        public bool ItsOverlap(Interval one, Interval two)
        {
            var min = Math.Min(one.Begin, two.Begin);
            var max = Math.Max(one.End, two.End);

            if (one.Begin == min && one.End + 1 >= two.Begin)
                return true;
            return two.Begin == min && two.End + 1 >= one.Begin;
        }
    }
}
