using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Examples
/*
 Given a binary string s, you can split s into 3 non-empty strings s1, s2, and s3 where s1 + s2 + s3 = s.

Return the number of ways s can be split such that the number of ones is the same in s1, s2, and s3. Since the answer may be too large, return it modulo 109 + 7.

 

Example 1:

Input: s = "10101"
Output: 4
Explanation: There are four ways to split s in 3 parts where each part contain the same number of letters '1'.
"1|010|1"
"1|01|01"
"10|10|1"
"10|1|01"
Example 2:

Input: s = "1001"
Output: 0
Example 3:

Input: s = "0000"
Output: 3
Explanation: There are three ways to split s in 3 parts.
"0|0|00"
"0|00|0"
"00|0|0"
 

Constraints:

3 <= s.length <= 105
s[i] is either '0' or '1'.
 */
#endregion
#region Test
/*
 
            var obj = new _1573();
            obj.NumWays("0000");

            obj.NumWays("10101");
 */
#endregion
namespace leetcode.Problems_1501_2000._1551_1600
{
    internal class _1573
    {
        #region 10/22/2023  records index with 1; pick 1 from range1, pick 1 from rang2
        public int NumWays_202311022(string s)
        {
            long mod = 1_000_000_007;
            List<int> list = new List<int>();
            for(int i =0; i < s.Length; i++)
            {
                if (s[i] == '1') list.Add(i);
            }

            if (list.Count % 3 != 0) return 0;
            long res = 0;
            if (list.Count == 0)
            {
                long x = s.Length - 1;
                long y = s.Length - 2;
                res = x * y % mod;
            }
            else
            {
                long x = list[list.Count % 3] - list[list.Count % 3 - 1];
                long y = list[2 * list.Count % 3] - list[2 * list.Count % 3 - 1];
                res = x * y % mod;
            }
            return (int)res;

        }
        #endregion
    }
}
