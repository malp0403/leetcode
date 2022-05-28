using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0022
    {
        IList<string> ans = new List<string>() { };
        public IList<string> GenerateParenthesis(int n)
        {
            backTracking(0, 0, new StringBuilder { }, n);
            return ans;
        }
        public void backTracking(int open,int close,StringBuilder s,int max)
        {
            if(s.Length == max * 2)
            {
                
                ans.Add(s.ToString());
                return;
            }
            if(open < max)
            {
                s.Append('(');
                backTracking(open + 1, close, s, max);
                s.Remove(s.Length - 1,1);
            }
            if (close < open)
            {
                s.Append(')');
                backTracking(open, close + 1, s, max);
                s.Remove(s.Length - 1,1);
            }
        }
    }
}
