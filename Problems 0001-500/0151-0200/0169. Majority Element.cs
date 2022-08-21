using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0169
    {
        public int MajorityElement(int[] nums)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>() { };
            foreach (var num in nums)
            {
                if (dic.ContainsKey(num)) dic[num]++;
                else
                {
                    dic.Add(num, 1);
                }
            }
            int max = 0;
            int k = 0;
            foreach (var key in dic.Keys)
            {
                if(dic[key] > max)
                {
                    max = dic[key];
                    k = key;
                }
            }
            return k;
        }

        //**********************12/16/2021**************

        public int MajorityElement_R2(int[] nums)
        {
            Array.Sort(nums);
            return nums[nums.Length / 2];
        }
    }
}
