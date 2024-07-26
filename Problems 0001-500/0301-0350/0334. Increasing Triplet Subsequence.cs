using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0301_0350
{
    internal class _0334
    {
        #region 07/25/2024 Approach 1: Linear Scan
        public bool IncreasingTriplet(int[] nums)
        {
            int first = int.MaxValue;
            int second = int.MaxValue;
            for(int i =0; i < nums.Length; i++)
            {
                if (nums[i] <= first) {
                    first = nums[i];
                }else if (nums[i] <= second) { 
                    second = nums[i];
                }
                else
                {
                    return true;
                }

            }
            return false;
            
        }

     


        #endregion
    }
}
