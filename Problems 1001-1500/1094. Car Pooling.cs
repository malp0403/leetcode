using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _1094
    {
        public bool CarPooling(int[][] trips, int capacity)
        {
            int[] arr = Enumerable.Repeat(0, 10001).ToArray();
            foreach (var ele in trips)
            {
                int num = ele[0];
                int start = ele[1];
                int end = ele[2];
                for(int i = start; i < end; i++)
                {
                    int total = arr[i] + num;
                    if(total > capacity)
                    {
                        return false;
                    }
                    arr[i] = total;
                }
            }
            return true;
        }
    }
}
