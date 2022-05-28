using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0394
    {
        public string DecodeString(string s)
        {
            s= s.Replace('[', '.');
            s =s.Replace(']', '.');
            var arr = s.Split('.');
            int count = 1;
            string answer = "";
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (Int32.TryParse(arr[i], out temp))
                {
                    count = Int32.Parse(arr[i]);
                }
                else
                {
                    int c = count;
                    while (c > 0)
                    {
                        answer += arr[i];
                        c--;
                    }
                    count = 1;

                  
                }
            }
            return answer;
        }
    }
}
