using leetcode.Problems_2501_3000._2201_2250;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Test Data
//var obj2 = new _2216();
//obj2.MinDeletion(new int[] { 1, 1, 2, 2, 3, 3 });
#endregion

namespace leetcode.Problems_2501_3000._2201_2250
{
    internal class _2216
    {
        #region 10/07/2023
        public int MinDeletion_20231007(int[] nums)
        {
            int shift = 0;
            for(int i =0; i < nums.Length-1; i++)
            {
                if((i - shift) % 2 ==0)
                {
                    if (nums[i] == nums[i + 1])
                    {
                        shift ++;
                    }
                }
            }
            if( (nums.Length-shift) %2 != 0)
            {
                shift++;
            }

            return shift;
        }
        #endregion
    }
}
