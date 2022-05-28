using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0053
    {
        public int MaxSubArray(int[] nums)
        {
            int sum = 0;
            int max = nums[0];

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                max = Math.Max(sum, max);
                if (sum <= 0) sum = 0;
            }
            return max;
        }
        //----- divide and conquer--------------

        public int MaxSubArray_V2(int[] nums)
        {
            return helper(nums, 0, nums.Length - 1);
        }

        public int helper(int[] nums, int left,int right)
        {
            if (left > right) return int.MinValue;
            int mid = left + (right-left)/ 2;
            int curr = 0;
            int bestLeft = 0;
            int bestRight = 0;
            for(int i= mid - 1; i >= left; i--)
            {
                curr += nums[i];
                bestLeft = Math.Max(curr, bestLeft);
            }
            curr = 0;
            for(int i = mid + 1; i <= right; i++)
            {
                curr += nums[i];
                bestRight = Math.Max(curr, bestRight);
            }
            int bestCombined = bestLeft + nums[mid] + bestRight;
            int leftHalf = helper(nums, left, mid - 1);
            int leftRight = helper(nums, mid + 1, right);
            return Math.Max(bestCombined, Math.Max(leftHalf, leftRight));
        }



        public IList<int> SpiralOrder(int[][] matrix)
        {
            List<int> result = new List<int>() { };
            int rows = matrix.Length;
            int columns = matrix[0].Length;

            int up = 0;
            int left = 0;
            int right = columns - 1;
            int down = rows - 1;
            while (result.Count < rows * columns)
            {
                for (int col = left; col <= right; col++)
                {
                    result.Add(matrix[up][col]);
                }
                for (int row = up + 1; row <= down; row++)
                {
                    result.Add(matrix[row][right]);
                }
                if (up != down)
                {
                    for (int col = right - 1; col >= left; col--)
                    {
                        result.Add(matrix[down][col]);
                    }
                }
                if (left != right)
                {
                    for (int row = down - 1; row > up; row--)
                    {
                        result.Add(matrix[row][left]);
                    }
                }
                left++;
                right--;
                up++;
                down--;
            }
            return result;
        }
    }
}
