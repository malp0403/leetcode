using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0091
    {
        int count = 0;
        HashSet<string> set;
        List<string> records = new List<string>() { };
        public int NumDecodings(string s)
        {
            set = new HashSet<string>() { };
            for(int i =1; i <= 26; i++)
            {
                set.Add(i.ToString());
            }
            helper(0, s,new StringBuilder() { });
            return count;

        }
        public void helper(int startIndx, string s,StringBuilder sb)
        {
            if(sb.Length >= s.Length)
            {
                if(sb.Length == s.Length)
                {
                    count++;
                }
                return;
            }
            //string s1 = s.Substring(startIndx, 1);
            if (startIndx +1 <=s.Length 
                && set.Contains(s.Substring(startIndx, 1)))
            {
                sb.Append(s.Substring(startIndx, 1));
                helper(startIndx + 1, s, sb);
                sb.Remove(sb.Length-1,1);
            }

            if (startIndx +2 <= s.Length 
                && set.Contains(s.Substring(startIndx, 2)))
            {
                sb.Append(s.Substring(startIndx, 2));
                helper(startIndx + 2, s, sb);
                sb.Remove(sb.Length - 2, 2);
            }
        }
    }
}
