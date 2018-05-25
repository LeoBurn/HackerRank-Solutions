using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.CrakingTheCodingInterview
{
    public class StacksBalancedBrackets
    {
        public bool Run(string brackets)
        {
            var stackBracket = new Stack<char>();
            foreach (var actualChar in brackets)
            {
                if(actualChar.Equals('{') || actualChar.Equals('[') || actualChar.Equals('(') )
                    stackBracket.Push(actualChar);
                else
                {
                    if (stackBracket.Count == 0) return false;

                    var previousChar = stackBracket.Pop();

                    if (!(actualChar.Equals('}') && previousChar.Equals('{')) &&
                        !(actualChar.Equals(']') && previousChar.Equals('[')) &&
                        !(actualChar.Equals(')') && previousChar.Equals('(')))
                        return false;

                }
            }

            return stackBracket.Count == 0;
        }

    }
}
