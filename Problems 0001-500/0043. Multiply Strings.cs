using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0043
    {
        #region answer
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
        #endregion
        #region 08/02/2022
        public string Multiply_20200802(string num1, string num2)
        {
            int zeroCount = 0;
            string answer = "";
            if(num1.Length==1 && num1[0]=='0' )
            for(int i = num2.Length-1; i >= 0; i--)
            {
                string temp = helper_multi_20200802(num1, num2[i] - '0', zeroCount);
                answer = helper_add_20200802(temp, answer);
                zeroCount++;
            }
            return answer;
        }
        public string helper_multi_20200802(string source, int multiply,int zeroCount)
        {
            if (multiply == 0) return "0";
            if (source == "0") return "0";
            int carry = 0;
            string res = "";
            for(int i = source.Length - 1; i >= 0; i--)
            {
                int temp = (source[i] - '0') * multiply;
                int num = (temp + carry) % 10;
                res += num;
                carry = (temp + carry) / 10;
            }
            if(carry > 0)
            {
                res += carry.ToString();
            }
            res = new string(res.ToCharArray().Reverse().ToArray());
            while (zeroCount > 0)
            {
                res += "0";
                zeroCount--;
            }
            return res;
        }
        public string helper_add_20200802(string s1,string s2)
        {
            int i = s1.Length - 1;
            int j = s2.Length - 1;
            string result = "";
            int carry = 0;
            while(i>=0 || j >= 0)
            {
                int first = i>=0?s1[i] - '0':0;
                int second = j>=0?s2[j] - '0':0;
                int num = (first + second + carry) % 10;
                carry = (first + second + carry) / 10;
                result += num.ToString();
                i--;
                j--;

            }
            if(carry > 0)
            {
                result += "1";
            }
            return new string(result.ToCharArray().Reverse().ToArray()); ;

        }

        #endregion
    }
}
