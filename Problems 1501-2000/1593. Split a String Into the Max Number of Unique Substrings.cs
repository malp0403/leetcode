using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Examples
/*
 Given a string s, return the maximum number of unique substrings that the given string can be split into.

You can split string s into any list of non-empty substrings, where the concatenation of the substrings forms the original string. However, you must split the substrings such that all of them are unique.

A substring is a contiguous sequence of characters within a string.

 

Example 1:

Input: s = "ababccc"
Output: 5
Explanation: One way to split maximally is ['a', 'b', 'ab', 'c', 'cc']. Splitting like ['a', 'b', 'a', 'b', 'c', 'cc'] is not valid as you have 'a' and 'b' multiple times.
Example 2:

Input: s = "aba"
Output: 2
Explanation: One way to split maximally is ['a', 'ba'].
Example 3:

Input: s = "aa"
Output: 1
Explanation: It is impossible to split the string any further.
 

Constraints:

1 <= s.length <= 16

s contains only lower case English letters.
 */
#endregion

namespace leetcode.Problems_1501_2000._1551_1600
{
    internal class _1593
    {
        #region 10/19/2023 DFS + backtracking
        int max = 0;
        public int MaxUniqueSplit_Dfs(string s)
        {
            dfs(s, new HashSet<string>());
            return max;
        }
        public void dfs(string s,HashSet<string> seen)
        {
            if(s == "")
            {
                max = Math.Max(max, seen.Count);
                return;
            }

            for(int len =1; len <= s.Length; len++)
            {
                string str = s.Substring(0, len);
                if (seen.Contains(str)) continue;
                seen.Add(str);
                dfs(s.Substring(len), seen);
                seen.Remove(str);
            }
        }
        #endregion
    }
}
