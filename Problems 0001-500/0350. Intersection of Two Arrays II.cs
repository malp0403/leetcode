using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0301_0350
{
    internal class _0350
    {
        #region 08/31/2024
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            Dictionary<int,int> dic1 = new Dictionary<int,int>();
            Dictionary<int, int> dic2 = new Dictionary<int, int>();

            foreach (int i in nums1)
            {
                if (!dic1.ContainsKey(i)) { dic1.Add(i, 1); }
                else
                {
                    dic1[i]++;
                }
            }

            foreach (int i in nums2)
            {
                if (!dic2.ContainsKey(i)) { dic2.Add(i, 1); }
                else
                {
                    dic2[i]++;
                }
            }
            List<int> result = new List<int>();

            foreach(int i in dic1.Keys)
            {
                if(dic2.ContainsKey(i))
                {
                    int min = Math.Min(dic2[i], dic1[i]);
                    while(min > 0)
                    {
                        result.Add(i);
                    }
                }
            }

            return result.ToArray();

        }
        #endregion
    }
}
