using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Example
/*
 Given an array of n integers nums, a 132 pattern is a subsequence of three integers nums[i], nums[j] and nums[k] such that i < j < k and nums[i] < nums[k] < nums[j].

Return true if there is a 132 pattern in nums, otherwise, return false.

 

Example 1:

Input: nums = [1,2,3,4]
Output: false
Explanation: There is no 132 pattern in the sequence.
Example 2:

Input: nums = [3,1,4,2]
Output: true
Explanation: There is a 132 pattern in the sequence: [1, 4, 2].
Example 3:

Input: nums = [-1,3,2,0]
Output: true
Explanation: There are three 132 patterns in the sequence: [-1, 3, 2], [-1, 3, 0] and [-1, 2, 0].
 

Constraints:

n == nums.length
1 <= n <= 2 * 105
-109 <= nums[i] <= 109
 */
#endregion

namespace leetcode.Problems_0001_500._0451_0500
{
    internal class _0456
    {
        #region 11/25/2023  TLE with brutal force
        Dictionary<(int r, int c, bool d), bool> dic = new Dictionary<(int r, int c, bool d), bool>();
        public bool Find132pattern_2023_11_25(int[] nums)
        {

            int min = int.MaxValue;
            for(int i =0; i < nums.Length - 2; i++)
            {
                min = Math.Min(min, nums[i]);

                for (int j = i+1; j <nums.Length; j++)
                {
                    if (nums[j] > min && nums[j] < nums[i])
                    {
                        return true;
                    }
                }
            }
            return false;

        }

        public bool helper_2023_11_25(int left,int right, int[] nums)
        {

            for(int i =left+1; i < right; i++)
            {
                if (nums[i] > nums[right]) return true;
            }
            return false;
            
        }
        #endregion

        #region 11/25/2023 stack
        public bool Find132pattern_2023_11_25_stack(int[] nums)
        {
            int[] min = Enumerable.Repeat(0, nums.Length).ToArray();

            for(int i =0; i < nums.Length; i++)
            {
                if (i == 0) min[i] = nums[i];
                else min[i] = Math.Min(nums[i - 1], nums[i]);
            }

            Stack<int> stack = new Stack<int>();

             for(int j = nums.Length - 1; j >= 0; j--)
            {
                if (nums[j] > min[j])
                {
                    while(stack.Count>0 && stack.Peek() <= min[j])
                    {
                        stack.Pop();
                    }
                    if(stack.Count>0 && stack.Peek() < nums[j])
                    {
                        return true;
                    }
                    stack.Push(nums[j]);

                }
            }

            return false;

        }
        #endregion
    }
}
