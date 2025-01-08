using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
#region 12/08/2023
/*
 You're given strings jewels representing the types of stones that are jewels, and stones representing the stones you have. Each character in stones is a type of stone you have. You want to know how many of the stones you have are also jewels.

Letters are case sensitive, so "a" is considered a different type of stone from "A".

 

Example 1:

Input: jewels = "aA", stones = "aAAbbbb"
Output: 3
Example 2:

Input: jewels = "z", stones = "ZZ"
Output: 0
 

Constraints:

1 <= jewels.length, stones.length <= 50
jewels and stones consist of only English letters.
All the characters of jewels are unique.
*/
#endregion

namespace leetcode.Problems_0501_1000._0751_0800
{
    internal class _0771
    {
        #region 12/08/2023 LeetCode Approach #2: Hash Set
        public int NumJewelsInStones_2023_12_08(string jewels, string stones)
        {
            HashSet<char> j = new HashSet<char>();
            foreach (char c in jewels)
            {
                j.Add(c);
            }
            int count = 0;
            foreach (char c in stones)
            {
                if (j.Contains(c))
                {
                    count++;
                }
                
            }
            return count;

        }
        #endregion
    }
}
