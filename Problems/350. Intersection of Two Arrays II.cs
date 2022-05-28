using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _350
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>() { };
            for(int i =0; i < nums1.Length; i++)
            {
                if (!dic.ContainsKey(nums1[i]))
                {
                    dic.Add(nums1[i], 1);
                }
                else
                {
                    dic[nums1[i]]++;
                }
            }

            List<int> list = new List<int>() { };
            for(int j = 0; j < nums2.Length; j++)
            {
                if(dic.ContainsKey(nums2[j]) && dic[nums2[j]] > 0)
                {
                    list.Add(nums2[j]);
                    dic[nums2[j]]--;
                }
            }
            return list.ToArray();

        }

        public int[] Intersect2(int[] nums1, int[] nums2)
        {
            Array.Sort(nums1);
            Array.Sort(nums2);
            List<int> li = new List<int>() { };
            int i = 0;
            int j = 0;
            int k = 0;
            while(i<nums1.Length && j < nums2.Length)
            {
                if(nums1[i] == nums2[j])
                {
                    li.Add(nums1[i]);
                    i++;
                    j++;
                }else if(nums1[i] < nums2[j])
                {
                    i++;
                }
                else
                {
                    j++;
                }
            }

            return li.ToArray();
        }

    }
}
