using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.Algorithms.Implementation
{
    public class DesignerPDFViewer
    {
        public int Run(string word, int[] sizes)
        {
            var maxHeight = 1;
            for (int i = 0; i < word.Length; i++)
            {
                var height = sizes[word[i] - 'a'];
                if (height > maxHeight)
                    maxHeight = height;
            }

            return maxHeight*word.Length;
        }
    }
}
