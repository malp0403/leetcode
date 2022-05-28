using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _167
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int left = 0;
            int right = numbers.Length - 1;
            while(left < right && left<numbers.Length && right >=0)
            {
                if (numbers[left] + numbers[right] == target)
                {
                    return new int[] { left+1, right+1 };
                } else if (numbers[left] + numbers[right] > target) {
                    right--;
                }
                else
                {
                    left++;
                }
            }
            return null;
        }
    }
}
