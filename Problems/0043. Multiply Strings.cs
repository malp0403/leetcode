using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0043
    {
        public string Multiply(string num1, string num2)
        {
            string ans = "0";
            if (num1.Length == 0 || num2.Length == 0) return "0";
            int zeroCount = 0;
            for (int i = num1.Length - 1; i >= 0; i--)
            {

                string res = helper(num1[i], num2, zeroCount);
                ans = AddString(ans, res);
            }
            return ans;
        }
        public string helper(char c, string str, int numsOfZero)
        {
            if (c == '0' || (str.Length == 1 && str[0] == '0')) return "0";
            int increase = 0;
            StringBuilder sb = new StringBuilder() { };
            while (numsOfZero > 0)
            {
                sb.Append('0');
                numsOfZero--;
            }
            for (int i = str.Length-1; i >=0; i--)
            {
                int temp = (c - '0') * (str[i] - '0');
                int num = (temp + increase) % 10;
                increase = (temp + increase) / 10;
                sb.Append(num);
            }
            if (increase > 0)
            {
                sb.Append(increase);
            }
            char[] arr = sb.ToString().ToCharArray().Reverse().ToArray();
            return new string(arr);
        }
        public string AddString(string s1, string s2)
        {
            int p1 = s1.Length - 1;
            int p2 = s2.Length - 1;
            StringBuilder sb = new StringBuilder() { };
            int increase = 0;
            while (p1 >= 0 || p2 >= 0)
            {
                int num1 = p1 >= 0 ? s1[p1] -'0': 0;
                int num2 = p2 >= 0 ? s2[p2] -'0' : 0;
                int sum = num1 + num2 + increase;
                sb.Append(sum % 10);
                increase = sum / 10;
                p1--;
                p2--;
            }
            if (increase > 0)
            {
                sb.Append(increase);
            }
            char[] arr = sb.ToString().ToArray().Reverse().ToArray();
            return new string(arr);
        }
    }
}
