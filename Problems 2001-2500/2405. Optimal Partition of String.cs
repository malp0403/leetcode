using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems_2001_2500
{
    internal class _2405
    {

        #region My Solution using set
        public int PartitionString(string s)
        {
            int start = 0;
            int count = 0;
            while (start < s.Length)
            {
                HashSet<char> set = new HashSet<char>();
                while (start < s.Length && !set.Contains(s[start]))
                {
                    set.Add(s[start]);
                    start++;
                }
                count++;
            }
            return count;
        }
        #endregion

        #region Solution using arr
        public int PartitionString_arr(string s)
        {
            int start = 0;
            int count = 0;
            while (start < s.Length)
            {
                int[] arr= Enumerable.Repeat(0,26).ToArray();
                while (start < s.Length && arr[s[start]-'a'] == 0)
                {
                    arr[s[start] - 'a']++;
                    start++;
                }
                count++;
            }
            return count;
        }
        #endregion


    }
}
