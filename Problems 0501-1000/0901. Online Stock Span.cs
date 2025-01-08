using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0501_1000
{
    internal class _0901
    {
        #region 09/30/2024
        Stack<(int stock, int days)> stack;
        public _0901()
        {
            stack = new Stack<(int stock, int days)>();
        }

        public int Next(int price)
        {
            int res = 1;
            while (stack.Count > 0 && price >= stack.Peek().stock)
            {
                var element = stack.Pop();
                res += element.days;
            }

            stack.Push((price, res));
            return res;
        }
        #endregion
    }
}
