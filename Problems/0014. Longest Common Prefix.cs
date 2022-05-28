using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0014
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 1) return strs[0];

            string answer = strs[0];
            for(int i=1; i < strs.Length; i++)
            {
                string temp = helper(answer, strs[i]);
                if (temp == "") return "";
                answer = answer.Length < temp.Length ? answer : temp;
            }
            return answer;
        }
        public string helper(string s1, string s2)
        {
            int n = Math.Min(s1.Length, s2.Length);
            string ans = "";
            for(int i = 0; i < n; i++)
            {
                if (s1[i] != s2[i]) break;
                ans += s1[i];
            }
            return ans;
        }
    }
}
