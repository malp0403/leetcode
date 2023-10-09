using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_2501_3000._2401_2450
{
    internal class _2441
    {
        #region 09/26/2023
        public int FindMaxK_20230926(int[] nums)
        {
            HashSet<int> seen = new HashSet<int>();
            foreach (var item in nums)
            {
                if(item > 0)
                {
                    seen.Add(item);
                }
            }
            int max = -1;
            foreach (var item in nums)
            {
                if(item < 0)
                {
                    if (seen.Contains(-item))
                    {
                        max = Math.Max(max, -item);
                    }
                }
            }
            return max; 
        }
        #endregion

        #region 0(1) T(n)
        public int FindMaxK__o1_20230926(int[] nums)
        {
            Array.Sort(nums);
            int i = 0;
            int j = nums.Length - 1;

            while(i<j && nums[i] < 0)
            {
                if (nums[i] + nums[j] == 0) return nums[j];
                if (-nums[i] < nums[j])
                {
                    j--;
                }
                else
                {
                    i++;
                }
               
            }

            return -1;

        }
            #endregion
        }
    }
