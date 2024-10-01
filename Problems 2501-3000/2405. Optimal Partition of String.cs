using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_2501_3000._2401_2450
{
    internal class _2405
    {
        #region 09/26/2023
        public int PartitionString(string s)
        {
            int count = 0;
            HashSet<char> seen = new HashSet<char>();
            for(int i =0; i < s.Length; i++)
            {
                if (seen.Contains(s[i]))
                {
                    count++;
                    seen = new HashSet<char> { s[i]};
                }
                else
                {
                    seen.Add(s[i]);
                }
                if(i== s.Length - 1)
                {
                    count++;
                }
            }
            return count;


        }
        #endregion

        #region LeetCode Bit Manipulation ; need to learn more.

        #endregion
    }
}
