using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0501_1000._0701_0750
{
    internal class _0704
    {
        public int Search(int[] nums, int target)
        {
            int l = 0;
            int r = nums.Length-1;
            while(l<= r)
            {
                int mid = (r + l) / 2;
                if (nums[mid] == target) return mid;
                else if (nums[mid] < target)
                {
                    l = mid+1;
                }
                else
                {
                    r = mid - 1;
                }

            }



            return -1;

        }


    }
}
