using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0266
    {
        public bool CanPermutePalindrome(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>() { };

            int singleCount = 0;
            bool valid = true;

            foreach (char c in s)
            {
                if (dic.ContainsKey(c)) dic[c]++;
                else { dic.Add(c, 1); }
                if (dic[c] % 2 != 0) singleCount++;
                else
                {
                    singleCount--;
                }

            }

            return singleCount >= 1;
            
            //if( s.Length %2 == 0)
            //{
            //    valid = singleCount == 0;
            //}
            //else
            //{
            //    valid = singleCount == 1;
            //}
            //return valid;
        }
//********************** 12/16/2021 **********
        public bool CanPermutePalindrome_R2(string s)
        {
            Dictionary<char, int> d = new Dictionary<char, int>() { };
            foreach (var c in s)
            {
                if (!d.ContainsKey(c)) d[c] = 1;
                else d[c]++;
            }
            int single = 0;
            foreach (var item in d.Keys)
            {
                if (d[item] %2 == 1) single++;
                if (single >= 2) return false;
            }
            return true;
        }
    }
}
