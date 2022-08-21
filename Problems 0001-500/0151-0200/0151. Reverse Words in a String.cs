using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0151
    {
        public string ReverseWords(string s)
        {
            s=s.Trim();
            var arr = s.Split(' ');
            string answer = "";
            for(int i = arr.Length-1; i >= 0; i--)
            {
                if(arr[i] != "") {
                    answer += arr[i];
                    answer += " ";
                }
            }
            if(answer[answer.Length-1] == ' ')
            {
                answer = answer.Substring(0, answer.Length - 1);
            }
            return answer;
        }
    }
}
