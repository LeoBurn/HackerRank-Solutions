using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.CrakingTheCodingInterview
{
    public class HeapsFindTheRunningMedian
    {
        public double[] Run(int[] values, int numberOfElements)
        {
            var lowerValues = new MaxHeap(numberOfElements/2 +1);
            var greaterValues = new MinHeap(numberOfElements / 2 +1);
            double[] medians = new double[numberOfElements];

            for (int i = 0; i < numberOfElements; ++i)
            {
                //Add Values
                var value = values[i];
                if (lowerValues.Size == 0 || lowerValues.Peek() > value)
                    lowerValues.Insert(value);
                else
                    greaterValues.Insert(value);

                //Rebalance
                EquityHeaps(lowerValues, greaterValues);

                medians[i] = GetMedian(lowerValues, greaterValues);
            }
            return medians;
        }

        public double GetMedian(Heap lower, Heap higher)
        {
            return (lower.Size == higher.Size)
                ? ((lower.Peek() + higher.Peek()) / (double) 2)
                : (higher.Size > lower.Size ? higher.Peek() : lower.Peek());

        }

        public void EquityHeaps(Heap lower, Heap higher)
        {
            Heap smallHeap, bigHeap;

            if (lower.Size < higher.Size)
            {
                smallHeap = lower;
                bigHeap = higher;
            }
            else
            {
                smallHeap = higher;
                bigHeap = lower;
            }

            if (bigHeap.Size - smallHeap.Size >= 2)
            {
                smallHeap.Insert(bigHeap.Pop());
            }
        }
    }


    public abstract class Heap
    {
        public int Capacity { get; protected set; }

        public int[] Elements { get; protected set; }
        public int Size { get; protected set; }

        protected Heap(int capacity)
        {
            Capacity = capacity;
            Elements = new int[capacity];
            Size = 0;
        }



        /// <summary>
        /// Verifity if heap needs to GrowUp then insert element and after
        /// that heapifyUp element
        /// </summary>
        /// <param name="element"></param>
        public void Insert(int element)
        {
            //Validate If needs to GrowUp
            GrowUpHeap();

            Elements[Size] = element;
            ++Size;
            HeapifyUp();
        }

        /// <summary>
        /// Return the root of heap without remove the element
        /// </summary>
        /// <returns></returns>
        public int Peek()
        {
            if (Size == 0) throw new InvalidOperationException("Empty Heap");
            return Elements[0];
        }

        /// <summary>
        /// Return the root of heap and remove the item
        /// </summary>
        /// <returns></returns>
        public int Pop()
        {
            if (Size == 0) throw new InvalidOperationException("Empty Heap");
            int item = Elements[0];
            Elements[0] = Elements[Size - 1];
            --Size;
            HeapifyDown();
            return item;
        }

        public bool IsEmpty => Size == 0;

        #region Abstract Members

        public abstract void HeapifyDown();

        public abstract void HeapifyUp();

        #endregion

        #region Private Members


        protected int Parent(int idx) => Elements[ParentIdx(idx)];
        protected int LeftChild(int idx) => Elements[LeftChildIdx(idx)];
        protected int RightChild(int idx) => Elements[RightChildIdx(idx)];

        protected int ParentIdx(int idx) => (idx - 1) / 2;
        protected int LeftChildIdx(int idx) => (idx * 2) + 1;
        protected int RightChildIdx(int idx) => (idx * 2) + 2;

        protected bool HasParent(int idx) => ParentIdx(idx) >= 0;
        protected bool HasLeftChild(int idx) => LeftChildIdx(idx) < Size;
        protected bool HasRightChild(int idx) => RightChildIdx(idx) < Size;

        private void GrowUpHeap()
        {
            if (Size == Capacity)
            {
                Capacity = Capacity * 2;
                var newHeap = new int[Capacity];
                Array.Copy(Elements, newHeap, Capacity / 2);
                Elements = newHeap;
            }
        }

        protected void Swap(int source, int dest)
        {
            var temp = Elements[source];
            Elements[source] = Elements[dest];
            Elements[dest] = temp;
        }

        #endregion


    }

    public class MinHeap : Heap
    {
        public MinHeap(int capacity) : base(capacity)
        {
        }

        public override void HeapifyDown()
        {
            int index = 0;

            while (HasLeftChild(index))
            {
                int smallValueIndex = LeftChildIdx(index);
                if (HasRightChild(index) && RightChild(index) < LeftChild(index))
                    smallValueIndex = RightChildIdx(index);

                if (Elements[index] < Elements[smallValueIndex])
                    break;
                else
                {
                    Swap(index, smallValueIndex);
                }
                index = smallValueIndex;
            }
        }

        public override void HeapifyUp()
        {
            int index = Size - 1;

            while (HasParent(index) && Elements[index] < Parent(index))
            {
                Swap(index, ParentIdx(index));
                index = ParentIdx(index);
            }
        }
    }

    public class MaxHeap : Heap
    {
        public MaxHeap(int capacity) : base(capacity)
        {
        }

        public override void HeapifyDown()
        {
            var index = 0;

            while (HasLeftChild(index))
            {
                var bigestValueIdx = LeftChildIdx(index);
                if (HasRightChild(index) && RightChild(index) > LeftChild(index))
                    bigestValueIdx = RightChildIdx(index);

                if (Elements[index] < Elements[bigestValueIdx])
                    break;
                else
                {
                    Swap(index, bigestValueIdx);
                }
                index = bigestValueIdx;
            }
        }

        public override void HeapifyUp()
        {
            var index = Size - 1;

            while (HasParent(index) && Elements[index] > Parent(index))
            {
                Swap(index, ParentIdx(index));
                index = ParentIdx(index);
            }
        }


    }

}
