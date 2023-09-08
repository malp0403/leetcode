using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0055
    {
        #region answer
        //*******************Solution 1******************
        public bool CanJump_v1(int[] nums)
        {
            return canJumpFromPosition(0, nums);
        }
        public bool canJumpFromPosition(int position,int[] nums)
        {
            if (position == nums.Length - 1) return true;
            int furthest = Math.Min(position + nums[position], nums.Length - 1);
            for(int nextPosition=position+1; nextPosition <= furthest; nextPosition++)
            {
                if (canJumpFromPosition(nextPosition, nums))
                {
                    return true;
                }
            }
            return false;
        }
        //*******************Solution 2******************
        int[] dp;
        public bool CanJump_v2(int[] nums)
        {
            dp = Enumerable.Repeat(0, nums.Length).ToArray();
            dp[nums.Length - 1] = 1;
            return dp[nums.Length - 1] ==1;
        }
        public bool canJumpFromPosition_v2(int position,int[] nums)
        {
            if(dp[position] != 0)
            {
                return dp[position] == 1;
            }
            if (position == nums.Length - 1) return true;

            int furthest = Math.Min(position + nums[position], nums.Length - 1);
            for (int nextPosition = position + 1; nextPosition <= furthest; nextPosition++)
            {
                if (canJumpFromPosition_v2(nextPosition, nums))
                {
                    dp[position] = 1;
                    return true;
                }
            }
            dp[position] = -1;
            return false;
        }
        //*******************Solution 3 bottom up******************
        public bool CanJump_v3(int[] nums)
        {
            dp = Enumerable.Repeat(0, nums.Length).ToArray();
            dp[nums.Length - 1] = 1;

            for(int i = nums.Length -2; i >= 0; i--)
            {
                int furthest = Math.Min(i + nums[i], nums.Length - 1);
                for(int j = i + 1; j <= furthest; i++)
                {
                    if (dp[j] == 1)
                    {
                        dp[i] = 1;
                        break;
                    }
                }
            }
            return dp[0] == 1;
        }
        //*******************Solution 4******************
        public bool CanJump_v4(int[] nums)
        {
            int lastGoodIndex = nums.Length - 1;
            for(int i =nums.Length-1; i >= 0; i--)
            {
                if(i+nums[i] >= lastGoodIndex)
                {
                    lastGoodIndex = i;
                }
            }
            return nums[0] >= lastGoodIndex;
            
        }
        #endregion

        #region 08/05/2022
        public bool CanJump_20220805(int[] nums)
        {
            int furthest = 0;
            int cur = 0;
            for(int i =0; i < nums.Length; i++)
            {


                furthest = Math.Max(furthest,i + nums[i]);
                if(i == furthest)
                {
                    return false;
                }
                if (furthest >= nums.Length - 1) return true;
                if(i == cur)
                {
                    if(furthest == cur) {
                        return furthest >=nums.Length-1?true:false;
                    }
                    cur = furthest;
                }
            }
            return true;
        }
        #endregion

        #region 08/07/2023  0(1) records farthest.
        public bool CanJump_20230807(int[] nums)
        {
            int farthest = 0;
            for(int i =0; i < nums.Length; i++)
            {
                farthest = Math.Max(nums[i] + i, farthest);
                if (farthest >= nums.Length - 1) return true;
                if (i == farthest && nums[i] == 0) return false;
            }
            return true;

        }
        #endregion

        #region 08/07/2023 backTracking

        public bool CanJump_20230807_v2(int[] nums)
        {
            int lastPos = nums.Length - 1;
            for(int i =nums.Length-1; i >= 0; i--)
            {
               if(i + nums[i] >= lastPos)
                {
                    lastPos = i;
                }
            }
            return lastPos == 0;

        }
        #endregion

    }
}
