using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _003
    {
        public int LengthOfLongestSubstring(string s)
        {
            Dictionary<char, int> dic = new Dictionary<char, int>();
            int left = 0;
            int right = 0;
            int res = 0;
            while(right < s.Length)
            {
                char r = s[right];

                if (dic.ContainsKey(r)&& dic[r] >=left && dic[r] < right)
                {
                    left = dic[r] + 1;
                }
                res = Math.Max(res, right - left + 1);

                dic[r] = right;
                right++;

        
                var str = string.Format("left {0}, right {1} res {2}",left, right,res);
                Console.WriteLine( str);
            }
            return res;
        }
    }
}
