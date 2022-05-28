using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0008
    {
        public int MyAtoi(string s)
        {
            int test = Int32.MinValue;
            bool isPositive = true;
            for(int i =0; i < s.Length; i++)
            {
                if(s[i] == ' ')
                {
                    continue;
                }else if(!char.IsDigit(s[i])&& s[i] != '-'&& s[i] != '+')
                {
                    return 0;
                }
                if(s[i] == '-' || s[i] == '+')
                {
                    if (i < s.Length - 1&& !char.IsDigit(s[i+1])) return 0;
                    isPositive = s[i] == '+';
                }
                else if(char.IsDigit(s[i]))
                {
                    int result = 0;
                    int j = i;
                    while (j < s.Length && char.IsDigit(s[j]))
                    {
                        int digit = s[j] - '0';
                        if(result > Int32.MaxValue/10 
                            || ( result == Int32.MaxValue/10 && digit > Int32.MaxValue%10))
                        {
                            return isPositive ? Int32.MaxValue : Int32.MinValue;
                        }
                        result = result * 10 + digit;
                        j++;
                    }
                    return isPositive?result:0-result;
                }
            }
            return 0;
        }
    }
}
