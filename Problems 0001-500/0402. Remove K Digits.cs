using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0401_0450
{
    internal class _0402
    {
        #region 09/04/2024 Approach 2: Greedy with Stack
        public string RemoveKdigits(string num, int k)
        {
            string res = "";
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < num.Length; i++)
            {
                int cur = num[i] - '0';
                while (stack.Count > 0 && stack.Peek() > cur && k > 0)
                {
                    stack.Pop();
                    k--;
                }
                stack.Push(cur);
            }

            while (k > 0 && stack.Count > 0)
            {
                stack.Pop();
                k--;
            }

            while (stack.Count > 0)
            {
                res = stack.Pop() + res;
            }

            int index = 0;
            while (index < res.Length && res[index] == '0')
            {
                index++;
            }

            return index != res.Length ? res.Substring(index) : "0";
        }
        #endregion
    }
}
