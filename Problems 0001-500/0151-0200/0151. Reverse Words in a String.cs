using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0151
    {
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
            for(int i =s.Length-1; i >=0;)
            {
                if (s[i] != ' ')
                {
                    int start = i;
                    while (i >= 0 && s[i] != ' ')
                    {
                        i--;
                    }
                    string str = i == 0 ? s.Substring(i, start-i+1) : s.Substring(i + 1, start-i);
                    list.Add(str);

                }
                else
                {
                    i--;
                }
            }
            return  string.Join(" ", list);
        }
        #endregion

    }
}
