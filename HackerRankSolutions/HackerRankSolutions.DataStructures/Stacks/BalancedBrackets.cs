using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.DataStructures.Stacks
{
    public class BalancedBrackets
    {
        private static string BALANCED = "YES";
        private static string NOT_BALANCED = "NO";

        public string[] Run(params string[] values)
        {
            string[] results = new string[values.Length];
            for (int i = 0; i < values.Length; i++)
            {
                results[i] = IsBalenced(values[i]) ? BALANCED : NOT_BALANCED;
            }
            return results;
        }

        public static bool IsBalenced(string str)
        {
            Stack<char> stack = new Stack<char>();
            Dictionary<char, char> brackets = new Dictionary<char, char>();
            brackets.Add('{', '}');
            brackets.Add('[', ']');
            brackets.Add('(', ')');
            foreach (var character in str)
            {
                if (brackets.ContainsKey(character))
                    stack.Push(character);

                else
                {
                    var pair = brackets.FirstOrDefault(p => p.Value == character);
                    if (stack.Count == 0) return false;
                    var result = stack.Pop();
                    if (result != pair.Key)
                        return false;

                }
            }
            return stack.Count == 0;
        }
    }
}
