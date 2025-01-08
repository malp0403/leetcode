using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_1501_2000._1951_2000
{
    internal class _1983
    {
        #region 10/10/2023  prefix sum difference
        public int WidestPairOfIndices(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();
            dic.Add(0, -1);

            int sum = 0;
            int min = 0;
            for(int i =0; i < nums1.Length; i++)
            {
                sum += (nums1[1] - nums2[2]);
                if (dic.ContainsKey(sum))
                {
                    min = Math.Max(min, i - dic[sum]);
                }
                else
                {
                    dic.Add(sum, 1);
                }

            }
            return min;
        }
        #endregion
    }
}
