using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _1011
    {
        int min = int.MaxValue;
        public int ShipWithinDays(int[] weights, int days)
        {
            travel(weights, 0, days, 0);

            return min;
        }

        public void travel(int[] weights, int start, int days, int max)
        {
            if (days == 1)
            {
                var temp = Math.Max(weights.Sum(), max);
                Console.WriteLine(temp);
                min = Math.Min(min, temp);
                return;
            }

            for (int i = start + 1; i < weights.Length; i++)
            {
                var sum = weights.Skip(i-start-1).Take(i - start).Sum();
                travel(weights.Skip(i-start).ToArray(), i, days - 1, Math.Max(max, sum));
            }

        }
    }
}
