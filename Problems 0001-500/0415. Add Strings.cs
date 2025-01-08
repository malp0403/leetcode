using leetcode.Problems;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

#region Question
/*
 Given two non-negative integers, num1 and num2 represented as string, return the sum of num1 and num2 as a string.

You must solve the problem without using any built-in library for handling large integers (such as BigInteger). You must also not convert the inputs to integers directly.

 

Example 1:

Input: num1 = "11", num2 = "123"
Output: "134"
Example 2:

Input: num1 = "456", num2 = "77"
Output: "533"
Example 3:

Input: num1 = "0", num2 = "0"
Output: "0"
 

Constraints:

1 <= num1.length, num2.length <= 104
num1 and num2 consist of only digits.
num1 and num2 don't have any leading zeros except for the zero itself.
 */
#endregion

#region test
/*
      var obj = new _0415();
            var res = obj.AddStrings_2024_09_05("456", "77");
            res = obj.AddStrings_2024_09_05("11","123");
 */
#endregion
namespace leetcode.Problems
{
    class _0415
    {
        #region Solution
        public string AddStrings(string num1, string num2)
        {
            int len = Math.Max(num1.Length, num2.Length);
            int carry = 0;
            string s = "";
            for (int i = 0; i < len; i++)
            {
                int n1 = num1.Length - i - 1 < num1.Length && num1.Length - i - 1 >= 0 ? num1[num1.Length - i - 1] - '0' : 0;
                int n2 = num2.Length - i - 1 < num2.Length && num2.Length - i - 1 >= 0 ? num2[num2.Length - i - 1] - '0' : 0;
                int sum = n1 + n2;
                s += (sum + carry) % 10;
                carry = (sum + carry) / 10;

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
            int l = num1.Length - 1;
            int r = num2.Length - 1;
            string ans = "";
            int increase = 0;
            int sum;
            while (l >= 0 || r >= 0)
            {
                int n1 = l >= 0 ? num1[l] - '0' : 0;
                int n2 = r >= 0 ? num2[r] - '0' : 0;
                l--; r--;
                sum = (n1 + n2 + increase) % 10;
                increase = (n1 + n2 + increase) / 10;
                ans = sum.ToString() + ans;
            }
            if (increase == 1)
            {
                ans = "1" + ans;
            }
            return ans;
        }
        public int helper(string s)
        {
            int ans = 0;
            for (int i = 0; i < s.Length; i++)
            {

                ans = ans * 10 + Int32.Parse(s[i].ToString());
            }
            return ans;
        }
        #endregion

        #region 2024_09_05 two pointers
        public string AddStrings_2024_09_05(string num1, string num2)
        {
            Stack<int> stack = new Stack<int>();
            int incre = 0;
            int index1 = num1.Length - 1;
            int index2 = num2.Length - 1;

            while(index1 >=0 || index2 >= 0)
            {
                int n1 = index1 >= 0 ? num1[index1] - '0' : 0;
                int n2 = index2 >= 0 ? num2[index2] - '0' : 0;

                int val = (n1 + n2 + incre) % 10;
                incre = (n1 + n2 + incre) / 10;
                stack.Push(val);
                index1--;
                index2--;
            }
            if(incre != 0)
            {
                stack.Push(incre);
            }
            StringBuilder sb = new StringBuilder();
            while(stack.Count > 0)
            {
                sb.Append(stack.Pop());
            }

            return sb.ToString();
        }
        #endregion
    }
}
