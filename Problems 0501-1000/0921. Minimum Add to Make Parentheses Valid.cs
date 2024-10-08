using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0921
    {
        #region LeetCode Approach: Open Bracket Counter

        #endregion


        #region Solution
        public int MinAddToMakeValid_s(string s)
        {
            int count = 0;
            Stack<char> stack = new Stack<char>() { };
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ')')
                {
                    if (stack.Count == 0) count++;
                    else stack.Pop();
                }
                else if (s[i] == '(')
                {
                    stack.Push('(');
                }
            }



            return count + stack.Count;
        }

        #endregion

        #region 01/03/2022
        public int MinAddToMakeValid_R2(string s)
        {
            Stack<char> stack = new Stack<char>() { };
            int count = 0;
            foreach (var c in s)
            {
                if (c == '(')
                {
                    stack.Push('(');
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        count++;
                    }
                    else
                    {
                        stack.Pop();

                    }
                }
            }
            count += stack.Count;
            return count;
        }
        #endregion

        #region 10/07/2024
        public int MinAddToMakeValid(string s)
        {
            int left = 0;
            int count = 0;
            foreach (var item in s)
            {
                if(item == '(')
                {
                    left++;
                }
                else
                {
                    if(left == 0)
                    {
                        count++;
                    }
                    else
                    {
                        left--;
                    }
                }
            }
            count += left;
            return count;
        }
        #endregion

    }
}
