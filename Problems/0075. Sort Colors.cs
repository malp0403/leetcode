using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0075
    {
        public void SortColors(int[] nums)
        {
            int p1 = 0;
            int p2 = nums.Length - 1;
            int cur = 0;
            while (cur <= p2)
            {
                if (nums[cur] == 0)
                {
                    var temp = nums[p1];
                    nums[p1] = nums[cur];
                    nums[cur] = temp;
                    cur++;
                    p1++;
                }else if(nums[cur] == 2)
                {
                    var temp = nums[p2];
                    nums[p2] = nums[cur];
                    nums[cur] = temp;
                    p2--;
                    cur++;
                }
            }
        }
    }
}
