using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.CrakingTheCodingInterview
{
    public class QueuesATaleOfTwoStacks
    {
        public Queue<int> _queue;

        public QueuesATaleOfTwoStacks()
        {
            _queue = new Queue<int>();
        }

        public int?[] Run(int[] operation, int?[] value)
        {
            int?[] result = new int?[operation.Length];
            for (int i = 0; i < operation.Length; ++i)
            {
                result[i] = RunSingle(operation[i], value[i]);
            }

            return result;
        }

        public int? RunSingle(int operation, int? value)
        {
            switch (operation)
            {
                case 1:
                    if (value != null) _queue.Enqueue(value.Value);
                    break;
                case 2:
                    _queue.Dequeue();
                    break;
                case 3:
                    var element = _queue.FirstOrDefault();
                    return element;
            }

            return null;
        }
    }
}
