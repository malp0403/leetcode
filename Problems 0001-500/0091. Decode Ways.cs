using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Transactions;

#region examples
/*
 A message containing letters from A-Z can be encoded into numbers using the following mapping:

'A' -> "1"
'B' -> "2"
...
'Z' -> "26"
To decode an encoded message, all the digits must be grouped then mapped back into letters using the reverse of the mapping above (there may be multiple ways). For example, "11106" can be mapped into:

"AAJF" with the grouping (1 1 10 6)
"KJF" with the grouping (11 10 6)
Note that the grouping (1 11 06) is invalid because "06" cannot be mapped into 'F' since "6" is different from "06".

Given a string s containing only digits, return the number of ways to decode it.

The test cases are generated so that the answer fits in a 32-bit integer.

 

Example 1:

Input: s = "12"
Output: 2
Explanation: "12" could be decoded as "AB" (1 2) or "L" (12).
Example 2:

Input: s = "226"
Output: 3
Explanation: "226" could be decoded as "BZ" (2 26), "VF" (22 6), or "BBF" (2 2 6).
Example 3:

Input: s = "06"
Output: 0
Explanation: "06" cannot be mapped to "F" because of the leading zero ("6" is different from "06").
 

Constraints:

1 <= s.length <= 100
s contains only digits and may contain leading zero(s).
 */
#endregion

namespace leetcode.Problems
{
    class _0091
    {
        #region Solution
        int count = 0;
        HashSet<string> set;
        List<string> records = new List<string>() { };
        public int NumDecodings(string s)
        {
            set = new HashSet<string>() { };
            for (int i = 1; i <= 26; i++)
            {
                set.Add(i.ToString());
            }
            helper(0, s, new StringBuilder() { });
            return count;

        }
        public void helper(int startIndx, string s, StringBuilder sb)
        {
            if (sb.Length >= s.Length)
            {
                if (sb.Length == s.Length)
                {
                    count++;
                }
                return;
            }
            //string s1 = s.Substring(startIndx, 1);
            if (startIndx + 1 <= s.Length
                && set.Contains(s.Substring(startIndx, 1)))
            {
                sb.Append(s.Substring(startIndx, 1));
                helper(startIndx + 1, s, sb);
                sb.Remove(sb.Length - 1, 1);
            }

            if (startIndx + 2 <= s.Length
                && set.Contains(s.Substring(startIndx, 2)))
            {
                sb.Append(s.Substring(startIndx, 2));
                helper(startIndx + 2, s, sb);
                sb.Remove(sb.Length - 2, 2);
            }
        }
        #endregion

        #region 11/13/2023 directly DFS will give TLE
        int count_20231113 = 0;
        public int NumDecodings_20231113(string s)
        {
            dfs(0, s);
            return count_20231113;
        }
        public void dfs(int index, string s)
        {
            if (index == s.Length)
            {
                count_20231113++;
                return;
            }
            int num1 = int.Parse(s.Substring(index, 1));
            if (num1 != 0)
            {
                dfs(index + 1, s);
            }
            if (num1 != 0 && index < s.Length - 1)
            {
                int num2 = int.Parse(s.Substring(index, 2));
                if (num2 <= 26)
                {
                    dfs(index + 2, s);
                }
            }
        }
        #endregion

        #region 2023/11/14 bottom up
        public int NumDecodings_20231113_BU(string s)
        {
            if (s[0] == '0') return 0;

            int[][] arr = new int[2][];
            int[] take = Enumerable.Repeat(0, s.Length).ToArray();
            int[] merge = Enumerable.Repeat(0, s.Length).ToArray();
            take[0] = 1;

            for (int i = 1; i < s.Length; i++)
            {
                int num = int.Parse(s.Substring(i - 1, 2));
                if (num == 0) return 0;

                take[i] = s[i] == '0' ? 0 : (take[i - 1] + merge[i - 1]);
                merge[i] = num <= 26 ? take[i - 1] : 0;

            }
            return take[s.Length - 1] + merge[s.Length - 1];

        }
        #endregion

        #region LeetCode Solution 1 Memorizon
        public int NumDecodings_20231113_Memo(string s)
        {
            int[] memo = Enumerable.Repeat(-1, s.Length+1).ToArray();
            return reCursive(0, s, memo);
        }
        public int reCursive(int index,string s, int[] memo)
        {

            if (index == s.Length) return 1;
            if (s[index] == '0') return 0;
            if (index == s.Length - 1) return 1;

            if (memo[index] != -1) return memo[index];

            int ans = reCursive(index + 1, s, memo);
            if(int.Parse(s.Substring(index,2)) <= 26)
            {
                ans += reCursive(index + 2, s, memo);
            }
            memo[index] = ans;
            return ans;
        }
        #endregion

        #region MyRegion LeetCodeSolution Itera2
        public int NumDecodings_Iterative(string s)
        {
            int[] dp = Enumerable.Repeat(0, s.Length + 1).ToArray();
            dp[0] = 1;
            dp[1] = s[0] == '0' ? 0 : 1;
            for (int i = 2; i < dp.Length; i++)
            {
                if (s[i - 1] != '0')
                {
                    dp[i] = dp[i - 1];
                }

                int nums = int.Parse(s.Substring(i - 2, 2));
                if (nums >= 10 && nums <= 26)
                {
                    dp[i] += dp[i - 2];
                }
            }




            return dp[s.Length];
        }

        #endregion

        #region LeetCodeSolution Itera3 //Approach 3: Iterative, Constant Space
        public int NumDecodings_Iterative3(string s)
        {
            int prepre = 1;
            int pre = 0;

            if (s[0] == '0') return 0;
            pre = s[0] == '0' ? 0 : 1;

            int index = 1;
            while (index < s.Length){
                int cur = 0;

                if (s[index] != '0')
                {
                    cur = pre;
                }
                int num = int.Parse(s.Substring(index - 1,2));
                if(num >=10 && num <= 26)
                {
                    cur += prepre;
                }

                prepre = pre;
                pre = cur;

                index++;

            }



            return pre;
        }
        #endregion

        #region 03/18/2024
        int count_2024_03_18 = 0;
        Dictionary<int, int> dic_2024_03_18 = new Dictionary<int, int>();
        public int NumDecodings_2024_03_18(string s)
        {
            HashSet<string> set = new HashSet<string>();
            for(int i =1; i <= 26; i++)
            {
                set.Add(i.ToString());
            }

            return helper_2024_03_18(0, s, set);

        }

        public int helper_2024_03_18(int index, string s, HashSet<string> set)
        {

            if (dic_2024_03_18.ContainsKey(index)) return dic_2024_03_18[index];

            if(index == s.Length)
            {
                return 1;
            }
           
            string firstLetter = s.Substring(index, 1);

            if (firstLetter == "0") return 0;
            if (index == s.Length - 1) return 1;

            int ans = helper_2024_03_18(index + 1, s, set);
            if(index<s.Length-1 && set.Contains(s.Substring(index, 2))){
                ans += helper_2024_03_18(index + 2, s, set);
            }

            dic_2024_03_18.Add(index, ans);

            return ans;
        }

        #endregion

        #region 03/18/2024 constant space
        public int NumDecodings_2024_03_18_constant(string s)
        {
            if (s.Length == 0 || s[0]=='0') return 0;
            int n = s.Length;
            int twoBack = 1;
            int oneBack = 1;
            for(int i=1; i< n; i++)
            {
                int cur = 0;
                if (s[i] != '0')
                {
                    cur = oneBack;
                }
                int twoDigit = int.Parse( s.Substring(i - 1, 2));
                if(twoDigit>=10&& twoDigit<=26)
                {
                    cur += twoBack;
                }
                twoBack = oneBack;
                oneBack = cur;
            }
            return oneBack;
        }

        #endregion
    }
}
