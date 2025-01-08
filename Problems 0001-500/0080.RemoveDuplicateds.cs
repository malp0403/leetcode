using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0080
    {
        #region answer
        public int RemoveDuplicates_answer1(int[] nums)
        {
            int start = 1;
            int cur = nums[0];
            int maxCount = 1;
            for(int i =1; i < nums.Length; i++)
            {
                if(nums[i] != cur)
                {
                    cur = nums[i];
                    nums[start] = nums[i];
                    start++;
                    maxCount = 1;
                }
                else
                {
                   
                    if (maxCount > 0)
                    {
                        nums[start] = nums[i];
                        start++;
                    }
                    maxCount--;
                }
            }
            return start;
        }
        #endregion

        #region 03/09/2024
        public int RemoveDuplicates_2024_03_09(int[] nums)
        {
            int forward = 0;
            Dictionary<int,int> counts= new Dictionary<int, int> ();

            for(int i =0; i < nums.Length; i++)
            {
                if (counts.ContainsKey(nums[i]) )
                {
                    counts[nums[i]]++;
                }
                else
                {
                    counts.Add(nums[i], 1);
                }

                if (counts[nums[i]] > 2)
                {
                    forward++;
                }
                else
                {
                    nums[i - forward] = nums[i];
                }

            }

            return nums.Length - forward;
        }
        #endregion

        #region 03/09/2024 optimize space
        public int RemoveDuplicates_2024_03_09_optimize(int[] nums)
        {
            int forward = 0;
            int cur = nums[0];
            int curCount = 1;
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] == cur)
                {  
                    curCount++;
                    if(curCount > 2)
                    {
                        forward++;
                    }
                    else
                    {
                        nums[i - forward] = cur;
                    }
                }
                else
                {
                    cur = nums[i];
                    curCount = 1;
                    nums[i - forward] = nums[i];
                }

            }

            return nums.Length - forward;
        }
        #endregion
    }
}
