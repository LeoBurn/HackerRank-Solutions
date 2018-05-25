using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankSolutions.CrakingTheCodingInterview
{
    public class HashTableRansomNote
    {
        public bool Run(string s1, string s2)
        {
            Hashtable wordsHashtable = new Hashtable();

            var splitValues = s1.Split(' ');

            foreach (var word in splitValues)
            {
                if (wordsHashtable.ContainsKey(word))
                {
                    var counter = (int)wordsHashtable[word];
                    wordsHashtable[word] = ++counter;
                }
                else
                {
                    wordsHashtable.Add(word,1);
                }
            }

            splitValues = s2.Split(' ');

            foreach (var word in splitValues)
            {
                if (!wordsHashtable.ContainsKey(word))
                    return false;
                else
                {
                    var counter =(int) wordsHashtable[word];
                    --counter;
                    if(counter == 0)
                        wordsHashtable.Remove(word);
                    else
                        wordsHashtable[word] = counter;
                }
            }

            return true;
        }
    }
}
