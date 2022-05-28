using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0067
    {
        public string AddBinary(string a, string b)
        {
            int increase = 0;
            int maxLengh = Math.Max(a.Length, b.Length);
            int curr = 0;
            Stack<int> stack = new Stack<int>() { };
            while(curr >=0)
            {
                int c1 = a.Length-curr <a.Length ? Int32.Parse(a[a.Length - curr - 1].ToString()) : 0;
                int c2 = b.Length - curr < b.Length ? Int32.Parse(b[b.Length-curr-1].ToString()) : 0;
                int sum = c1 + c2;
                stack.Push((sum + increase )% 2);
                increase = (sum + increase) / 2;
                curr++;
            }
            if (increase != 0) stack.Push(1);

            string answer = "";
            while(stack.Count > 0)
            {
                answer += stack.Pop().ToString();
            }
            return answer;
        }
        //-----------------12-27-2021--------------
        public string AddBinary_R1(string a,string b)
        {
            string ans = "";
            int increase = 0;
            int l = a.Length-1; int r = b.Length-1;
            while(l>=0 || r >= 0)
            {
                int c1 = l >= 0 ? a[l] - '0' : 0;
                int c2 = r >= 0 ? b[r] - '0' : 0;
                int sum = c1 + c2 + increase;
                ans = sum % 2 + ans;
                increase = sum / 2;
                l--;r--;
            }
            if(increase == 1)
            {
                ans = increase + ans;
            }
            return ans;

        }

        //02/05/2022------------------
        public string AddBinary_R2(string a,string b)
        {
            int incre = 0;
            StringBuilder sb = new StringBuilder() { };
            int p1 = a.Length - 1;
            int p2 = b.Length - 1;
            while (p1 >= 0 || p2 >= 0)
            {
                int num1 = p1 >= 0 ? a[p1] - '0' : 0;
                int num2 = p2 >= 0 ? b[p2] - '0' : 0;
                int sum = num1 + num2 + incre;
                sb.Append(sum % 2);
                incre = sum / 2;
            }
            if (incre > 0) {
                sb.Append(incre);
            }
            char[] arr = sb.ToString().ToCharArray().Reverse().ToArray();
            return new string(arr);
        }
    }
}
