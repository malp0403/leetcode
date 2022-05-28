using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Recursive
{
    class Q5_FibonaccinNumber
    {
        Dictionary<int, int> dic = new Dictionary<int, int>() { };
        public int Fib(int n)
        {
            if (dic.ContainsKey(n)) return dic[n];
            if (n == 0) {
                dic.Add(0, 0); return 0;
            }
            if (n == 1)
            {
                dic.Add(0, 1); return 1;
            }
            return Fib(n - 1) + Fib(n - 2);
        }
    }
}
