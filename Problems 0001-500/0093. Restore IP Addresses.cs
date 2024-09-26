using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
#region Examples
/*
 A valid IP address consists of exactly four integers separated by single dots. Each integer is between 0 and 255 (inclusive) and cannot have leading zeros.

For example, "0.1.2.201" and "192.168.1.1" are valid IP addresses, but "0.011.255.245", "192.168.1.312" and "192.168@1.1" are invalid IP addresses.
Given a string s containing only digits, return all possible valid IP addresses that can be formed by inserting dots into s. You are not allowed to reorder or remove any digits in s. You may return the valid IP addresses in any order.

 

Example 1:

Input: s = "25525511135"
Output: ["255.255.11.135","255.255.111.35"]
Example 2:

Input: s = "0000"
Output: ["0.0.0.0"]
Example 3:

Input: s = "101023"
Output: ["1.0.10.23","1.0.102.3","10.1.0.23","10.10.2.3","101.0.2.3"]
 

Constraints:

1 <= s.length <= 20
s consists of digits only.
 */
#endregion

#region Test
/*
             var obj = new _0093();
            obj.RestoreIpAddresses_2023_11_15("25525511135");
 */
#endregion

namespace leetcode.Problems
{
    class _0093
    {
        #region LeetCode Solution2 Iterative; split it into len1,len2,len3,len4

        #endregion
        #region Solution
        IList<string> answer = new List<string>() { };
        public IList<string> RestoreIpAddresses(string s)
        {
            backTracking(s, 0, new List<string>() { });
            return answer;
        }
        public void backTracking(string s, int start, List<string> list)
        {
            if (list.Count == 4 && start == s.Length)
            {
                answer.Add(string.Join('.', list));
                return;
            }
            for (int i = 1; i <= 3; i++)
            {
                string sub = s.Substring(start, i);
                if (isValidString(sub))
                {
                    list.Add(sub);
                    backTracking(s, start + i, list);
                    list.RemoveAt(list.Count - 1);
                }
            }
        }

        public bool isValidString(string s)
        {
            if (s == "") return false;
            if (s[0] == '0' && s.Length > 1) return false;
            if (int.Parse(s) >= 255) return false;
            return true;
        }
        #endregion

        #region 11/15/2023 BackTracking  as leetCode Solution1
        IList<string> ans = new List<string>();
        public IList<string> RestoreIpAddresses_2023_11_15(string s)
        {
            int total = dfs_2023_11_15(0, 4, s, new List<int>());
            return ans;
        }
        public int dfs_2023_11_15(int index, int count, string s, List<int> list)
        {
            if (index == s.Length)
            {
                if (count == 0)
                {
                    ans.Add(String.Join('.', list));
                    return 1;
                }
                return 0;
            }
            int total = 0;
            if (s[index] == '0')
            {
                list.Add(0);
                total += dfs_2023_11_15(index + 1, count - 1, s, list);
                list.RemoveAt(list.Count - 1);
            }
            else
            {
                list.Add(int.Parse(s.Substring(index, 1)));
                total += dfs_2023_11_15(index + 1, count - 1, s, list);
                list.RemoveAt(list.Count - 1);
                if (index + 1 < s.Length)
                {
                    list.Add(int.Parse(s.Substring(index, 2)));
                    total += dfs_2023_11_15(index + 2, count - 1, s, list);
                    list.RemoveAt(list.Count - 1);

                }
                if (index + 2 < s.Length && int.Parse(s.Substring(index, 3)) <= 255)
                {
                    list.Add(int.Parse(s.Substring(index, 3)));
                    total += dfs_2023_11_15(index + 3, count - 1, s, list);
                    list.RemoveAt(list.Count - 1);

                }
            }
            return total;

        }
        #endregion

        #region 03/18/2024
        IList<string> answer_2024_03_18;
        public IList<string> RestoreIpAddresses_2024_03_18(string s)
        {
            answer_2024_03_18 = new List<string>();
            backTracking(0, s, new List<string>(), 0);
            return answer_2024_03_18;
        }
        public void backTracking(int index, string s, List<string> list, int added)
        {
            if (index == s.Length && added == 4)
            {
                answer_2024_03_18.Add(String.Join(".", list));
                return;
            }
            if (added > 4) return;
            if (index >= s.Length) return;

            char c1 = s[index];
            list.Add(c1.ToString());
            backTracking(index + 1, s, list, added + 1);
            list.RemoveAt(list.Count - 1);

            if (c1 != '0')
            {
                if (index + 1 < s.Length)
                {
                    list.Add(s.Substring(index, 2));
                    backTracking(index + 2, s, list, added + 1);
                    list.RemoveAt(list.Count - 1);
                }
                if (index + 2 < s.Length && int.Parse(s.Substring(index, 3)) <= 255)
                {
                    list.Add(s.Substring(index, 3));
                    backTracking(index + 3, s, list, added + 1);
                    list.RemoveAt(list.Count - 1);
                }
            }


        }

        #endregion

    }
}
