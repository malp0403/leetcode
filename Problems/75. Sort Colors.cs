using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _75
    {
        public void SortColors(int[] nums)
        {
            int po = 0;
            int p2 = nums.Length - 1;
            int cur = 0;
            int temp;
            while (cur <= p2) {
                if (nums[cur] == 2)
                {
                    temp = nums[cur];
                    nums[cur] = nums[p2];
                    nums[p2] = temp;
                    p2--;
                }
                else if (nums[cur] == 0)
                {
                    temp = nums[cur];
                    nums[cur] = nums[po];
                    nums[po] = temp;
                    cur++;
                    po++;
                }
                else {
                    cur++;
                }
            }

        }
        public void swap(int i, int j){
            int temp = i;
            i = j;
            j = i; 
         }
    }
}
