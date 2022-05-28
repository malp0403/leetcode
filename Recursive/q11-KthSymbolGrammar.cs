using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Recursive
{
    class q11_KthSymbolGrammar
    {
        public int KthGrammar(int n, int k)
        {
            string ans = helper(n);
            return ans[k - 1] - '0';
        }
        public string helper(int n)
        {
            if (n == 0) return "0";
            string s = helper(n - 1);
            StringBuilder sb = new StringBuilder();
            foreach (var c in s)
            {
                if (c == '0') sb.Append("01");
                else sb.Append("10");
            }
            return sb.ToString();
        }
    }
}
