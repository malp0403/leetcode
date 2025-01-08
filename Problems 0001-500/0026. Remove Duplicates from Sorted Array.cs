using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0026
    {
        #region LeetCode Approach 1: Two indexes approach
        public int RemoveDuplicates_LeetCode(int[] nums)
        {
            int index1 = 0;
            int index2 = 0;

            HashSet<int> set = new HashSet<int>();

            while (index2 < nums.Length)
            {
                if (!set.Contains(nums[index2]))
                {
                    set.Add(nums[index2]);
                    nums[index1] = nums[index2];
                    index1++;
                }

                index2++;
            }

            return index1;
        }
        #endregion

        #region 02/02/2022
        //02/02/2022------------------------
        public int ReMoveDuplicate(int[] nums)
        {
            if (nums.Length == 0) return 0;
            int curr = 0;
            for(int i=0; i < nums.Length; i++)
            {
                if (nums[i] != nums[curr])
                {
                    curr++;
                    nums[curr] = nums[i];
                }
            }
            return (curr+1);
        }
        #endregion

        #region 07/26/2022
        public int RemoveDuplicates_20220726(int[] nums)
        {
            int k = 0;
            HashSet<int> set = new HashSet<int>() { };
            for(int i =0; i < nums.Length; i++)
            {
                if (!set.Contains(nums[i]))
                {
                    set.Add(nums[i]);
                    nums[k] = nums[i];
                    k++;
                }
            }
            return k;
        }
        #endregion

        #region 02/01/2024 Two indexes approach
        public int RemoveDuplicates_2024_02_01(int[] nums)
        {
            int index1 = 0;
            int index2 = 0;

            HashSet<int> set = new HashSet<int>();

            while(index2 < nums.Length)
            {
                if (!set.Contains(nums[index2]))
                {
                    set.Add(nums[index2]);
                    nums[index1] = nums[index2];
                    index1++;
                }

                index2++;
            }

            return index1;
        }
        #endregion
    }
}
