using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0008
    {
        #region answer
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
        #endregion

        #region 07/11/2022

        public int MyAtoi_R1(string s)
        {
            int sum = 0;
            int indx = 0;
            while(indx < s.Length)
            {
                if (char.IsDigit(s[indx])){
                    bool isNegative = indx - 1 >= 0 && s[indx - 1] == '-';
                    while(indx < s.Length && char.IsDigit(s[indx]))
                    {
                        int num = isNegative ? '0' - s[indx] : s[indx] - '0';
                        if(sum > Int32.MaxValue/10 || (sum == Int32.MaxValue/10 && num > Int32.MaxValue % 10))
                        {
                            sum = Int32.MaxValue;
                            break;
                        }
                        if(sum < Int32.MinValue/10 || (sum == Int32.MinValue/10 && num < Int32.MinValue % 10))
                        {
                            sum = Int32.MinValue;
                            break;
                        }
                        sum = sum * 10 + num;
                        indx++;

                    }
                    break;
                }
                else if(s[indx] == ' ' )
                {
                    indx++;
                }else if (s[indx] == '-' || s[indx] == '+')
                {
                    if(indx +1 <s.Length && char.IsDigit(s[indx+1]))
                    {
                        indx++;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    break;
                }
            }

            return sum;
        }

        #endregion
    }
}
