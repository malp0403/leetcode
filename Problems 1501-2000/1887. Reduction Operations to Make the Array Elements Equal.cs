using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_1501_2000._1851_1900
{
    internal class _1887
    {
        public int ReductionOperations(int[] nums)
        {
            int count = 0;
            int N = 0;
            int min = int.MaxValue;
            foreach (int i in nums)
            {
                N = Math.Max(i, N);
                min = Math.Min(i, min);
            }
            int[] records = Enumerable.Repeat(0, N+1).ToArray();

            foreach (var item in nums)
            {
                records[item]++;
            }

            int accumulate = 0;
            for(int i = records.Length-1;i >= 0; i--)
            {
                if(i > min && records[i] >0)
                {
                    accumulate += records[i];
                    count += accumulate;
                }
            }

            return count;

        }
    }
}
