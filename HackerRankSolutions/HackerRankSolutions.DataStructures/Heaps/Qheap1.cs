using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.DataStructures.Heaps
{
    public class QHeap1
    {
        public int[] Run(string[] commands, int numberOfCommands)
        {
            MinHeap minHeap = new MinHeap(numberOfCommands);
            List<int> results = new List<int>();

            foreach(var command in commands)
            {
                var commandsSplit = command.Split(' ');
                int commandType = Int32.Parse(commandsSplit[0]);

                switch (commandType)
                {
                    case 1:
                    {
                        minHeap.Insert(Int32.Parse(commandsSplit[1]));
                        break;
                    }
                    case 2:
                    {
                        minHeap.Delete(Int32.Parse(commandsSplit[1]));
                        break;
                    }
                    case 3:
                    {
                        results.Add(minHeap.Peek());
                        break;
                    }
                }
            }

            return results.ToArray();
        }
    }
}
