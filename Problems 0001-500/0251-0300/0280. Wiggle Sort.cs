using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0251_0300
{
    internal class _0280
    {

        #region 07/11/2024
        public void WiggleSort(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                if (i % 2 == 0 && nums[i] > nums[i - 1])
                {
                    int temp = nums[i];
                    nums[i] = nums[i - 1];
                    nums[i - 1] = temp;
                }
                if (i % 2 == 1 && nums[i] < nums[i - 1])
                {
                    int temp = nums[i];
                    nums[i] = nums[i - 1];
                    nums[i - 1] = temp;
                }
            }
        }
        #endregion

    }
}
