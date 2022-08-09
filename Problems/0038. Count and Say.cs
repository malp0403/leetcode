using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0038
    {
        #region answer
        public string CountAndSay(int n)
        {
            string answer = "1";
            if (n == 1) return answer;
            else
            {
                while (n > 1)
                {
                    answer = helper(answer);
                    n--;
                }
                return answer;
            }
        }
        public string helper(string s)
        {
            int count = 1;
            StringBuilder sb = new StringBuilder { };
            string result = "";
            for(int i =0; i < s.Length; i++)
            {
                if( i == 0)
                {
                    if(i == s.Length - 1)
                    {
                        sb.Append(count);
                        sb.Append(s[i]);
                        result += sb.ToString();
                    }
                }else if(i == s.Length - 1)
                {
                    if(s[i] != s[i - 1])
                    {
                        sb.Append(count);
                        sb.Append(s[i - 1]);
                        result += sb.ToString();
                        result += ("1" + s[i].ToString());
                        break;
                    }
                    else
                    {
                        count++;
                        sb.Append(count);
                        sb.Append(s[i]);
                        result += sb.ToString();
                    }
                }
                else
                {
                    if(s[i] != s[i - 1])
                    {
                        sb.Append(count);
                        sb.Append(s[i - 1]);
                        result += sb.ToString();
                        //reset
                        sb = new StringBuilder { };
                        count = 1;
                    }
                    else
                    {
                        count++;
                    }
                }
            }
            return result;
        }
        #endregion
    }
}
