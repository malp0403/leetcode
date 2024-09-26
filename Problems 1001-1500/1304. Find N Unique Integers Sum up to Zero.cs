using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems_1001_1500._1301_1350
{
    public class _1304
    {
        public int[] SumZero(int n)
        {
            List<int> list = new List<int>();
            if (n % 2 == 1) { list.Add(0); }
            for(int i =1; i <= n / 2; i++)
            {
                list.Add(i);
                list.Add(-i);
            }
            return list.ToArray();
        }
    }
}
