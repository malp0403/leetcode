using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0151_0200
{
    public class _0152
    {

        #region 08/13/2023
        public int MaxProduct_20230813(int[] nums)
        {
            if (nums.Length == 0) return 0;
            int max_so_far = nums[0];
            int min_so_far = nums[0];
            int result = nums[0];

            for(int i =1;i < nums.Length; i++)
            {
                int temp = Math.Max(nums[i], Math.Max(nums[i] * max_so_far, nums[i] * min_so_far));
                min_so_far = Math.Min(nums[i], Math.Min(nums[i] * max_so_far, nums[i] * min_so_far));

                max_so_far = temp;

                result = Math.Max(max_so_far, result);

            }
            return result;
        }
        #endregion

    }
}
