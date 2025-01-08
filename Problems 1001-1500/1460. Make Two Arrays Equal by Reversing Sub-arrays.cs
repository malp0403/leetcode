using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _1460
    {
        public bool CanBeEqual(int[] target, int[] arr)
        {
            int[] check = Enumerable.Repeat(0, 1001).ToArray();
            foreach (var num in target)
            {
                check[num]++;
            }
            foreach (var num in arr)
            {
                check[num]--;
                if (check[num] < 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
