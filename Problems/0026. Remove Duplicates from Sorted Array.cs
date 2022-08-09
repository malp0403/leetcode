using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0026
    {
        #region answer
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;
            int cur = 0;
            for(int i=1;i< nums.Length; i++)
            {
                if(nums[i] != nums[cur])
                {
                    cur++;
                    nums[cur] = nums[i];
                }
            }
            return cur + 1;
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
    }
}
