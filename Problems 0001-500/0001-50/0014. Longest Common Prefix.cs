using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0014
    {
        #region answer
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
        #endregion

        #region 07/18/2022 Approach 1: Horizontal scanning
        public string LongestCommonPrefix_R1_1(string[] strs)
        {
            StringBuilder result = new StringBuilder() { };
            bool stop = false;
            int i = 0;
            while (!stop)
            {
                for(int j=0; j < strs.Length; j++)
                {
                    if (i >= strs[j].Length) { stop = true;break; }
                    if (j == 0) continue;
                    if(strs[j][i] != strs[j - 1][i]) { stop = true;break; }
                }
                if (!stop)
                {
                    result.Append(strs[0][i]);
                    i++;
                }
            }
            return result.ToString();

        }

        #endregion

        #region Approach 2: Vertical scanning
        public string LongestCommonPrefix_R1_2(string[] strs)
        {
            StringBuilder result = new StringBuilder() { };

            if (strs.Length == 0) return "";
            string prefix = strs[0];

            for (int j = 1; j < strs.Length; j++)
            {
                while (strs[j].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (prefix.Length == 0) return "";
                }
            }
            return prefix;

        }
        #endregion



        #region 01/14/2024
        public string LongestCommonPrefix_2024_01_14(string[] strs)
        {
            StringBuilder result = new StringBuilder();
            int index = 0;
            bool stop = false;
            while (!stop)
            {
                if (index >= strs[0].Length) break;
                char c = strs[0][index];
                for (int i = 1; i < strs.Length; i++)
                {
                    if (index >= strs[i].Length || strs[i][index] !=c)
                    {
                        stop = true;
                        break;
                    }

                }
                if (!stop)
                {
                    result.Append(c);
                }
                index++;
            }

            return result.ToString();
  
        }
        #endregion
    }
}
