using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0151_0200
{
    internal class _0154
    {
        #region 03/28/2024
        public int FindMin(int[] nums)
        {
            int lo = 0;
            int hi = nums.Length - 1;
            while(lo < hi)
            {
                int pivot =lo + (hi- lo)/2;
                if (nums[pivot] < nums[hi])
                {
                    hi = pivot;
                }
                else if (nums[pivot] > nums[hi])
                {
                    lo = pivot + 1;
                }
                else
                {
                    hi -= 1;
                }
            }
            return nums[lo];
        }
            #endregion
        }
    }
