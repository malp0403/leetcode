using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0415
    {
        public string AddStrings(string num1, string num2)
        {
            int len = Math.Max(num1.Length, num2.Length);
            int carry = 0;
            string s = "";
            for (int i = 0; i < len; i++)
            {
                int n1 = num1.Length - i - 1 < num1.Length && num1.Length - i - 1 >=0 ? num1[num1.Length - i - 1] - '0' : 0;
                int n2 = num2.Length - i - 1 < num2.Length && num2.Length - i - 1 >= 0 ? num2[num2.Length - i - 1] - '0' : 0;
                int sum = n1 + n2;
                s += (sum  + carry) % 10;
                carry = (sum + carry)  / 10;

            }
            if (carry != 0) s += carry;
            string result = "";
            for (int j = s.Length - 1; j >= 0; j--)
            {
                result += s[j].ToString();
            }
            return result;

        }

        public string AddStrings_R2(string num1, string num2)
        {
            int l = num1.Length-1;
            int r = num2.Length-1;
            string ans = "";
            int increase = 0;
            int sum;
            while (l >=0 || r >=0)
            {
                int n1 = l >= 0 ? num1[l]-'0' : 0;
                int n2= r >=0? num2[r] - '0' : 0;
                l--;r--;
                sum = (n1 + n2 + increase) % 10;
                increase = (n1 + n2 + increase) / 10;
                ans = sum.ToString() + ans;
            }
            if (increase ==1)
            {
                ans = "1" + ans;
            }
            return ans;
        }
        public int helper(string s)
        {
            int ans = 0;
            for(int i = 0; i < s.Length; i++)
            {
                
                ans = ans * 10 + Int32.Parse(s[i].ToString());
            }
            return ans;
        }
    }
}
