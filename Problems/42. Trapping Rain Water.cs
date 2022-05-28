using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace leetcode.Problems
{
    class _42
    {
        public  int Trap(int[] height)
        {
            if (height.Length == 0) return 0;
            int sum = 0;
            int max = height.Max();
            int maxIndex = Array.IndexOf(height, max);
            var front_arr = height.TakeWhile((ele, ind) => { return ind <= maxIndex; }).ToArray();
            var end_arr = height.TakeLast(height.Length - (maxIndex)).Reverse().ToArray();

            sum = backTrack(0, sum, front_arr);
            sum = backTrack(0, sum, end_arr);
            return sum;
        }
        public  int backTrack(int start, int sum, int[] height)
        {
            while (start < height.Length && height[start] == 0)
            {
                start++;
            }
            if (start >= height.Length - 2) return sum;
            int indx = Array.FindIndex(height, start + 1, x => x >= height[start]);
            if (indx < 0) return sum;
            for (int i = start + 1; i < indx; i++)
            {
                sum += height[start] - height[i];
            }
            return backTrack(indx, sum, height);
        }
    }
}
