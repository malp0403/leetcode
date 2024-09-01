using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0349
    {
        #region 08/31/2022
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
                if (reference[num] == 0)
                {
                    list.Add(num);
                }
            }
            return list.ToArray();
        }
        #endregion

        #region 08/31/2024
        public int[] Intersection_2024_08_31(int[] nums1, int[] nums2)
        {
           HashSet<int> set = new HashSet<int>();
            foreach (var num in nums1)
            {
                set.Add(num);
            }
            HashSet<int> set2 = new HashSet<int>();
            foreach (var num in nums2)
            {
                if (set.Contains(num))
                {
                    set2.Add(num);
                }
            }

            return set2.ToArray();
        }
        #endregion
    }
}
