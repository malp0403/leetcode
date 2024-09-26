using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems._0101_150
{
    class _0131
    {
        #region solution 1
        IList<IList<string>> answer;
        public IList<IList<string>> Partition_(string s)
        {
            answer = new List<IList<string>>() { };
            helper(s, 0, s.Length, new List<string>() { });
            return answer;
        }
        public void helper(string s, int start, int end, List<string> list)
        {
            if (start >= s.Length)
            {
                answer.Add(list.Select(x => x).ToList());
                return;
            }
            for (int i = start; i < end; i++)
            {
                string temp = s.Substring(start, i - start + 1);
                if (isPali(temp))
                {
                    list.Add(temp);
                    helper(s, i + 1, end, list);
                    list.RemoveAt(list.Count - 1);
                }
            }
        }
        public bool isPali(string s)
        {
            if (s.Length == 1) return true;
            int left = 0;
            int right = s.Length - 1;
            while (left < right)
            {
                if (s[left] != s[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
        #endregion
        #region solution 1 with Dynamic

        IList<IList<string>> answer2 = new List<IList<string>>() { };
        public IList<IList<string>> Partition_v2(string s)
        {
            bool[][] dp = new bool[s.Length][];
            for (int i = 0; i < s.Length; i++)
            {
                dp[i] = Enumerable.Repeat(false, s.Length).ToArray();
            }
            helper_v2(s, 0, new List<string>() { }, dp);
            return answer2;

        }
        public void helper_v2(string s, int start, List<string> list, bool[][] dp)
        {
            if (start >= s.Length)
            {
                answer2.Add(list.Select(x => x).ToList());
                return;
            }
            for (int i = start; i < s.Length; i++)
            {
                if (s[start] == s[i] && (i - start <= 2 || dp[start + 1][i - 1]))
                {
                    dp[start][i] = true;
                    list.Add(s.Substring(start, i - start + 1));
                    helper_v2(s, i + 1, list, dp);
                    list.RemoveAt(list.Count - 1);
                }
            }
        }
        #endregion

        #region 03/25/2024
        public IList<IList<string>> Partition(string s)
        {
            List<IList<string>> res = new List<IList<string>>();
            if (s.Length == 0)
            {
                return res;
            }
            else if (s.Length == 1)
            {
                res.Add(new List<string>() { s });
            }
            else
            {
                for (int i = 1; i <= s.Length; i++)
                {
                    IList<IList<string>> list = new List<IList<string>>();
                    string firstPart = s.Substring(0, i);
                    string secondPart = i == s.Length ? "" : s.Substring(i);
                    if (isPal_2024_03_24(firstPart))
                    {
                        list = Partition(secondPart);

                        if (list.Count > 0)
                        {
                            foreach (var item in list)
                            {
                                List<string> newList = new List<string>() { firstPart };
                                newList.AddRange(item);
                                res.Add(newList);
                            }
                        }
                        else
                        {
                            res.Add(new List<string>() { firstPart });
                        }


                    }


                }
            }

            return res;
        }

        public bool isPal_2024_03_24(string s)
        {

            if (s.Length == 0 || s.Length == 1) return true;
            int l = 0;
            int r = s.Length - 1;
            while (l < r)
            {
                if (s[l] != s[r]) return false;
                l++;
                r--;
            }
            return true;
        }
        #endregion
    }
}
