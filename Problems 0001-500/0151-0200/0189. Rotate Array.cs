using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace leetcode.Problems
{
    class _0189
    {

        #region LeetCode Approach 4: Using Reverse
        public void Rotate_v1(int[] nums, int k)
        {
            k %= nums.Length;
            reverse(0, nums.Length - 1, nums);
            reverse(0, k - 1, nums);
            reverse(k, nums.Length - 1, nums);
        }
        public void reverse(int start, int end, int[] nums)
        {
            while (start < end)
            {
                var temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end--;
            }
        }

        #endregion

        public void Rotate_v2(int[] nums, int k)
        {
            int[] answer = new int[nums.Length];
            int pivotPoint = nums.Length - k-1;
            for (int i = 0; i < nums.Length; i++)
            {
                if(i< pivotPoint)
                {
                    var temp = nums[i];
                    nums[i] = nums[nums.Length - k];
                    nums[nums.Length - k] = temp;
                }
                else
                {
                    var temp = nums[i];
                    nums[i] = nums[nums.Length - k];
                    nums[nums.Length - k] = temp;
                }

            }

        }

        #region 06/11/2024
        public void Rotate_2024_06_11(int[] nums, int k)
        {
            k = k % nums.Length;
            int count = 0;
            for(int i =0; count < nums.Length; i++)
            {
                int current = i;
                int prev = nums[i];

                while(true)
                {
                    int next = (current + k) % nums.Length;
                    int temp = nums[next];
                    nums[next] = prev;

                    prev = temp;
                    current = next;
                    count++;
                    if (i == current) break;
                }

            }
          
        }
        #endregion

    }
}
