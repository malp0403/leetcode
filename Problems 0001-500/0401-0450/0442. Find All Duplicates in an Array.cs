using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0442
    {
        public IList<int> FindDuplicates(int[] nums)
        {
            IList<int> answer = new List<int>() { };
            for(int i =0; i < nums.Length; i++)
            {
                int indx = Math.Abs(nums[i]) - 1;
                if(nums[indx] < 0)
                {
                    answer.Add(Math.Abs(indx+1));
                }
                else
                {
                    nums[indx] = -nums[indx];
                }
            }
            return answer;
        }
    }
}
