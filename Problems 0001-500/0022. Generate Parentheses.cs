using leetcode.Class;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0022
    {
        #region answer
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
        #endregion

        #region 07/19/2022
        IList<string> re_20220719;
        public IList<string> GenerateParenthesis_20220719(int n)
        {
            re_20220719 = new List<string>() { };
            helper(0, 0, new StringBuilder() { }, n);
            return re_20220719;
        }
        public void helper(int open, int close , StringBuilder s, int n)
        {
            if (open == n && close == n) re_20220719.Add(s.ToString());
            if(open < n)
            {
                s.Append('(');
                helper(open + 1, close, s, n);
                s.Remove(s.Length - 1,1);
            }
            if (close < open)
            {
                s.Append(')');
                helper(open, close + 1, s, n);
                s.Remove(s.Length - 1, 1);

            }
        }
        #endregion

        #region 01/29/2024 greedy
        IList<string> result_2024_01_29;
        public IList<string> GenerateParenthesis_2024_01_29(int n)
        {
            result_2024_01_29 = new List<string>();
            helper(2 * n, 0, new StringBuilder());
            return result_2024_01_29;
        }

        public void helper(int operation, int open,StringBuilder sb)
        {
            if(operation == 0)
            {
                result_2024_01_29.Add(sb.ToString());
            }
            else
            {
                if(operation > open)
                {
                    sb.Append('(');
                    helper(operation - 1, open + 1, sb);
                    sb.Remove(sb.Length - 1, 1);
                }

                if(open > 0)
                {
                    sb.Append(')');
                    helper(operation - 1, open - 1, sb);
                    sb.Remove(sb.Length - 1, 1);
                }
            }
        }
        #endregion
    }
}
