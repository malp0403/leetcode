using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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

        #region 04/15/2024 Boyer-Moore Voting Algorithm
        public int MajorityElement_2024_04_15(int[] nums)
        {
            int count = 1;
            int num = nums[0];
            for(int i =1; i < nums.Length; i++)
            {
                if(count == 0)
                {
                    num = nums[i];
                    count = 1;
                }
                else
                {
                    if(num == nums[i])
                    {
                        count++;
                    }
                    else
                    {
                        count--;
                    }
                }
            }
            return num;
        }
        #endregion
    }
}
