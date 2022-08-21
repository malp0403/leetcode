using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0349
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            List<int> list = new List<int>() { };
            int[] reference = Enumerable.Repeat(0, 1001).ToArray();
            foreach (var num in nums1)
            {
                reference[num] = 1;
            }
            foreach (var num in nums2)
            {
                reference[num]--;
                if(reference[num] == 0)
                {
                    list.Add(num);
                }
            }
            return list.ToArray();
        }
    }
}
