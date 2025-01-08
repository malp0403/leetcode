using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_2501_3000._2201_2250
{
    internal class _2206
    {
        #region 10/08/2023

        public bool DivideArray(int[] nums)
        {
            if (nums.Length % 2 == 1) return false;
            int[] arr = Enumerable.Repeat(0,501).ToArray();
            foreach (var item in nums)
            {
                arr[item]++;
            }
            for(int i =0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 1) return false;
            }
            return true;
        }

        #endregion
    }
}
