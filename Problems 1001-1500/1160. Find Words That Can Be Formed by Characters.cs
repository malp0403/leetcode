using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _1160
    {
        public int CountCharacters(string[] words, string chars)
        {
            int[] reference = Enumerable.Repeat(0, 26).ToArray();
            foreach(var c in chars)
            {
                reference[c - 'a']++;
            }
            int sum = 0;
            for(int i=0; i < words.Length; i++)
            {
                if (helper(words[i], reference))
                {
                    sum += words[i].Length;
                }
            }
            return sum;
        }
        public bool helper(string target,int[] reference)
        {
            int[] copyArray = Enumerable.Repeat(0, 26).ToArray();
            Array.Copy(reference,copyArray,26);
            foreach(var c in target)
            {
                copyArray[c - 'a']--;
                if (copyArray[c - 'a'] < 0) return false;
            }
            return true;
        }
    }
}
