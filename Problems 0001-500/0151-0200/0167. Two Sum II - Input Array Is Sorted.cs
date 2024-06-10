using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0151_0200
{
    internal class _0167
    {
        #region 04/15/2024
        public int[] TwoSum_2024_04_15(int[] numbers, int target)
        {
            int l = 0;
            int r = numbers.Length - 1;
            while(l < r)
            {
                if (numbers[l] + numbers[r] == target) return new int[] { l + 1, r + 1 };
                if(numbers[l] + numbers[r] < target)
                {
                    l++;
                }
                else
                {
                    r--;
                }
            }

            return new int[] { };
         
        }
        #endregion
    }
}
