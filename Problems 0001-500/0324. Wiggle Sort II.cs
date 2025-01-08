using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0301_0350
{
    internal class _0324
    {
        #region 07/23/2024
        public void WiggleSort(int[] nums)
        {
           List<int> list = new List<int>();
            Array.Sort(nums);
            int i = (nums.Length-1)/2;
            int j = nums.Length - 1;

            while(i >= 0)
            {
                list.Add(nums[i]);
                if(j!= (nums.Length - 1) / 2)
                {
                    list.Add(nums[j]);
                }
                i--;
                j--;
            }
            for(int k =0; k < list.Count; k++)
            {
                nums[k] = list[k];
            }

        }
        #endregion
    }
}
