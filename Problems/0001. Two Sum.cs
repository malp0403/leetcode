using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0001
    {
        #region answer
        public int[] TwoSum(int[] nums, int target)
        {
            HashSet<int> set = new HashSet<int>() { };
            Dictionary<int, int> d = new Dictionary<int, int>() { };
            for(int i=0; i < nums.Length; i++)
            {
                if (set.Contains(target - nums[i]))
                {
                    return new int[] { d[target - nums[i]], i };
                }
                else
                {
                    set.Add(nums[i]);
                    if (!d.ContainsKey(nums[i]))
                    {
                        d.Add(nums[i], i);
                    }
                   
                }
            }
            return null;
        }
        #endregion

        #region 07/10/2022
        public int[] Review_2(int[] nums, int target)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>() { };

            int[] result = new int[2];
            for(int i =0; i < nums.Length; i++)
            {
                int left = target - nums[i];
                if (dic.ContainsKey(left))
                {
                    result[0] = dic[left];
                    result[1] = i;
                    break;
                }
                if (!dic.ContainsKey(nums[i]))
                {
                    dic.Add(nums[i], i);

                }
            }
            return result;
            


        }
        #endregion

    }
}
