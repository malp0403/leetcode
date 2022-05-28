using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _055
    {
        public bool CanJump(int[] nums)
        {
            int len = nums.Length;
            bool canJump = true;
            int pos = 0;
            while(pos <= len-1)
            {
                if(pos == len - 1)
                {
                    canJump = true;
                    break;
                }

                if (nums[pos] == 0) {
                    if (pos == (len - 1)) {
                        canJump = true;
                        break;
                    }
                    else
                    {
                        canJump = false;
                        break;
                    }
                }
                pos += nums[pos];
            }
            return canJump;
        }
    }
}
