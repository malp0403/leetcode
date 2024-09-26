using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0038
    {
        #region answer
        public string CountAndSay_1(int n)
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

        #region 02/19/2024
        public string CountAndSay(int n)
        {
            if (n == 1) return "1";

            string str = "1";
            while(n > 1)
            {
                str = helper_2024_02_19(str);
                n--;

            }

            return str;
        }

        public string helper_2024_02_19(string s)
        {
            StringBuilder sb = new StringBuilder();
            char cur = 'a';
            int count = 1;
            for(int i =0; i < s.Length; i++)
            {
                if (s[i] != cur)
                {
                    sb.Append(count);
                    sb.Append(cur);

                    //reset
                    cur = s[i];
                    count = 1;
                }
                else
                {
                    count++;
                }

                if (i == s.Length - 1)
                {
                    sb.Append(count);
                    sb.Append(cur);
                }

            }
            return sb.ToString().Substring(2);
        }
        #endregion
    }
}
