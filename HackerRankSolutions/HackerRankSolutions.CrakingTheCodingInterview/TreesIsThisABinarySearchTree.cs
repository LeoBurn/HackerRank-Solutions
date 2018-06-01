using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.CrakingTheCodingInterview
{
    public class TreesIsThisABinarySearchTree
    {
        public bool Run(Node root)
        {
            return IsBST(root,Int32.MinValue, Int32.MaxValue);
        }

        public bool IsBST(Node root, int min,int max)
        {
            if (root == null)
                return true;

            if (root.Data < min || root.Data > max)
                return false;

            return (IsBST(root.Left, min, root.Data - 1) &&
                    IsBST(root.Right, root.Data + 1, max));
        }
    }

    public class Node
    {
        public int Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
    }
}
