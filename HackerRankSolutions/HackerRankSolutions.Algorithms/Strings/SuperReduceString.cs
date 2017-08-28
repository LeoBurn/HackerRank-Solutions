using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.Algorithms.Strings
{
    public class SuperReduceString
    {
        public string Run(string input)
        {
           
            string result = input;
            string nextResult = string.Empty;
            
            while (!nextResult.Equals(result))
            {   
                nextResult = result;
                
                StringBuilder sb = new StringBuilder();
                int beginIdx = 0;
                int endIdx = 1;
                char? buffuredChar = null;
                for (int i = 1; i < result.Length; i++)
                {
                    if (result[i] == result[i - 1])
                    {
                        endIdx++;
                    }
                    else
                    {
                        if ((endIdx - beginIdx) % 2 != 0)
                            sb.Append(result[i - 1]);

                        beginIdx = i;
                        endIdx = beginIdx + 1;

                    }
                }
                if (result.Length != 0 &&(endIdx - beginIdx) % 2 != 0)
                    sb.Append(result[result.Length - 1]);
                
                result = sb.ToString();
            }
        

            //LastIteration
            return result.Length == 0? "Empty String": result;
        }
    }
}
