using leetcode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

#region Test Data

//var obj = new _0032();
//obj.longestValidParentheses_20230725_DP("(()())");
#endregion

namespace leetcode.Problems
{
    class _0032
    {
        #region solution 1 
        public int LongestValidParentheses(string s)
        {
            int max = 0;
            for (int i = 0; i < s.Length; i++)
            {
                max = Math.Min(helper(i, s), max);
            }
            return max;
        }
        public int helper(int i, string s)
        {
            int count = 0;
            int l = 0;
            for (int j = i; j < s.Length; j++)
            {
                if (s[j] == ')')
                {
                    l--;
                    if (l == 0)
                    {
                        count = j - i + 1;
                    }
                    else if (l < 0)
                    {
                        return count;
                    }
                }
                else
                {
                    l++;
                }
            }
            return count;
        }
        #endregion

        #region 07/24/2023 Attemp but time limit exceed

        public int longestValidParentheses_20230724(string s)
        {
            if (s.Length == 0 || s.Length == 1) return 0;
            if (s.Length == 2) return s[0] == '(' && s[1] == ')' ? 2 : 0;

            int max = 0;
            bool[][] matric = new bool[s.Length][];
            for (int i = 0; i < matric.Length; i++)
            {
                matric[i] = Enumerable.Repeat(false, s.Length).ToArray();
            }


            for (int len = 1; len <= s.Length; len++)
            {
                for (int i = 0; i < s.Length - len + 1; i++)
                {
                    if (len % 2 == 1) matric[i][i + len - 1] = false;
                    else
                    {
                        if (s[i] == '(' && s[i + len - 1] == ')' && (len == 2))
                        {
                            matric[i][i + len - 1] = true;
                            max = len;
                        }
                        else
                        {
                            if (s[i] != '(' || s[i + len - 1] != ')') matric[i][i + len - 1] = false;
                            else
                            {
                                if (matric[i + 1][i + len - 2])
                                {
                                    matric[i][i + len - 1] = true;
                                    max = len;
                                }
                                else
                                {
                                    bool isvalid = false;
                                    for (int j = i + 1; j < i + len - 1; j++)
                                    {
                                        if (matric[i][j] && matric[j + 1][i + len - 1])
                                        {
                                            isvalid = true;
                                            max = len;
                                            break;
                                        }
                                    }
                                    matric[i][i + len - 1] = isvalid;
                                    if (isvalid) max = len;
                                }

                            }


                        }

                    }
                }
            }
            return max;
        }

        #endregion

        #region 07/24/2023

        public int longestValidParentheses_20230724_attemp2(string s)
        {
            int max = 0;
            for (int i = 0; i < s.Length; i++)
            {
                max = Math.Max(helper_20230724_attemp2(i, s), max);
            }
            return max;
        }
        public int helper_20230724_attemp2(int i, string s)
        {
            int l = 0;
            int start = i;
            int count = 0;
            while (i < s.Length)
            {
                if (s[i] == ')')
                {
                    l--;
                    if (l < 0) return i - start;
                    if (l == 0)
                    {
                        count = i - start + 1;
                    }
                }
                else
                {
                    l++;
                }
                i++;
            }
            return count;
        }
        #endregion

        #region 07/25/2023
        public int longestValidParentheses_20230725_DP(string s)
        {
            int[] dp = Enumerable.Repeat(0, s.Length).ToArray();

            int max = 0;
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == ')')
                {
                    if (s[i - 1] == '(')
                    {
                        dp[i] = (i - 2 >= 0 ? dp[i - 2]  : 0) + 2;
                    }
                    else
                    {
                        if (i - dp[i - 1] - 1 >= 0 && s[i - dp[i - 1] - 1] == '(')
                        {
                            dp[i] = i - dp[i - 1] - 2 >= 0 ? dp[i - 1] + dp[i - dp[i - 1] - 2] + 2 : dp[i - 1] + 2;
                        }
                    }
                }
                max = Math.Max(max, dp[i]);
            }
            return max;
        }

        #endregion

        #region 07/25/2023 Stack attempt
        public int LongestValidParentheses_07252023_stack(string s)
        {
            Stack<int> stack = new Stack<int> ();
            int max = 0;

            stack.Push(-1);
            for(int i =0; i < s.Length; i++)
            {
                if (s[i] == '(')
                {
                    stack.Push(i);
                }
                else
                {
                    stack.Pop();
                    if (stack.Count == 0)
                    {
                        stack.Push(i);
                    }
                    else
                    {
                        max = Math.Max(max, i - stack.Peek());
                    }
                }
            }

            return max;
        }

        #endregion

        #region 07/25/2023 right/left attempt
        public int LongestValidParentheses_07252025_rightleft(string s)
        {
            int open = 0;
            int close = 0;
            int max = 0;
            for(int i =0; i < s.Length; ++i)
            {
                if (s[i] == '(')
                {
                    open++;
                }
                else
                {
                    close++;
                }
                if(close == open)
                {
                    max = Math.Max(max,close * 2);
                }else if(close > open)
                {
                    close = 0;open = 0;
                }


            }
            close = 0; open = 0;
            for (int i = s.Length-1; i >=0; i--)
            {
                if (s[i] == '(')
                {
                    close++;
                }
                else
                {
                    open++;
                }
                if (close == open)
                {
                    max = Math.Max(max, close * 2);
                }
                else if (close > open)
                {
                    close = 0; open = 0;
                }


            }
            return max;

        }

        #endregion
    }
}
