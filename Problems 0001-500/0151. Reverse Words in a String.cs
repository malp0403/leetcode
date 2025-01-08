using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace leetcode.Problems
{
    class _0151
    {
        #region  not o(1) solution provided in LeetCode Solutions

        #endregion

        #region Solution
        public string ReverseWords_solution(string s)
        {
            s = s.Trim();
            var arr = s.Split(' ');
            string answer = "";
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] != "")
                {
                    answer += arr[i];
                    answer += " ";
                }
            }
            if (answer[answer.Length - 1] == ' ')
            {
                answer = answer.Substring(0, answer.Length - 1);
            }
            return answer;
        }
        #endregion

        #region 03/28/2024
        public string ReverseWords(string s)
        {
            s = s.Trim();
            List<string> list = new List<string>();
            for (int i = s.Length - 1; i >= 0;)
            {
                if (s[i] != ' ')
                {
                    int start = i;
                    while (i >= 0 && s[i] != ' ')
                    {
                        i--;
                    }
                    string str = i == 0 ? s.Substring(i, start - i + 1) : s.Substring(i + 1, start - i);
                    list.Add(str);

                }
                else
                {
                    i--;
                }
            }
            return string.Join(" ", list);
        }
        #endregion

        #region 09/16/2024 O(n) space.
        public string ReverseWords_2024_09_16_0n(string s)
        {
            Stack<string> stack = new Stack<string>();

            for(int i =0; i < s.Length; i++)
            {

                if (char.IsLetterOrDigit(s[i]))
                {
                    int start = i;
                    while(i< s.Length && char.IsLetterOrDigit(s[i]))
                    {
                        i++;
                    }

                    stack.Push(s.Substring(start,i - start));

                }
            }

            StringBuilder sb = new StringBuilder();
            while(stack.Count > 0){
                sb.Append(stack.Pop());
                if (stack.Count > 0)
                {
                    sb.Append(" ");
                }
            }

            return sb.ToString();

        }
        #endregion

    }
}
