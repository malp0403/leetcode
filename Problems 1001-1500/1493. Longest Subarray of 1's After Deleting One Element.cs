using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Test
/*
          var obj = new _1493();
            obj.LongestSubarray(new int[] { 1, 1, 0, 1 });
 */
#endregion

namespace leetcode.Problems_1001_1500._1451_1500
{
    internal class _1493
    {
        #region Approach: Sliding Window 09/16/2024
        public int LongestSubarray_app1(int[] nums)
        {
            int zeroCount = 0;
            int window = 0;
            int start = 0;
            for(int i=0; i<nums.Length; i++)
            {
                zeroCount += (nums[i] == 0?1:0);

                while (zeroCount > 1)
                {
                    zeroCount -= (nums[start] == 0 ? 1 : 0);
                    start++;
                }
                window = Math.Max(window, i - start);

            }
            return window;
        }
        #endregion
        #region 09/16/2024 to Right, to Left
        public int LongestSubarray(int[] nums)
        {
            int count = 0;
            int[] toRight = Enumerable.Repeat(0, nums.Length).ToArray();
            int[] toLeft = Enumerable.Repeat(0, nums.Length).ToArray();
            bool hasZero = false;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 1)
                {
                    count++;
                }
                else
                {
                    hasZero = true;
                    count = 0;
                }
                toRight[i] = count;
            }

            count = 0;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                if (nums[i] == 1)
                {
                    count++;
                }
                else
                {
                    count = 0;
                }
                toLeft[i] = count;
            }
            if (!hasZero)
            {
                return nums.Length - 1;
            }
            int max = 0;
            for (int i = 0; i < nums.Length; i++)
            {

                if (nums[i] == 0)
                {
                    int left = i == 0 ? 0 : toRight[i - 1];
                    int right = i == nums.Length - 1 ? 0 : toLeft[i + 1];
                    max = Math.Max(max, left + right + 1);
                }
            }
            return max;
        }
        #endregion
    }
}
