using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Recursive
{
    class Q7_ClimbingStairs
    {
        Dictionary<int, int> d = new Dictionary<int, int>() { };
        public int ClimbStairs(int n)
        {
            if (d.ContainsKey(n)) return d[n];
            if (n == 1)
            {
                d.Add(1, 1);
                return 1;
            }
            if (n == 2)
            {
                d.Add(2, 2);
                return 2;
            }
            int total = ClimbStairs(n - 1) + ClimbStairs(n - 2);
            d.Add(n,total);
            return total;
        }
    
    }
}
