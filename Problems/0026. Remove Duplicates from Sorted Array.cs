using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0026
    {
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
    }
}
