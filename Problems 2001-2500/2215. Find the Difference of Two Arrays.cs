using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_2001_2500._2201_2250
{
    internal class _2215
    {
        #region 09/17/2024
        public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
        {
            HashSet<int> set1 = nums1.ToHashSet();
            HashSet<int> set2=  nums2.ToHashSet();
            IList<IList<int>> list = new List<IList<int>>();

            List<int> temp = new List<int>();
            foreach (int i in set1  )
            {
                if (!set2.Contains(i))
                {
                    temp.Add(i);
                }
            }

            list.Add(temp.ToList());
            temp = new List<int>();
            foreach (int i in set2)
            {
                if (!set1.Contains(i))
                {
                    temp.Add(i);
                }
            }
            list.Add(temp);

            return list;
        }
        #endregion
    }
}
