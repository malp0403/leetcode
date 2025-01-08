using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_2501_3000._2501_2550
{
    internal class _2540
    {
        #region 09/25/2023
        public int GetCommon(int[] nums1, int[] nums2)
        {
            int l1 = 0;
            int l2 = 0;
            while(l1 < nums1.Length && l2< nums2.Length)
            {
                if (nums1[l1] == nums2[l2]) return nums1[l1];

                if (nums1[l1] < nums2[l2])
                {
                    l1++;
                }
                else
                {
                    l2++;
                }
            }

            return 0;
        }
        #endregion
    }
}
