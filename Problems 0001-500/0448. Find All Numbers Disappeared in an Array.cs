using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0448
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {

            for(int i =0; i < nums.Length; i++)
            {
                nums[Math.Abs(nums[i])-1] = -Math.Abs(nums[Math.Abs(nums[i])-1]); 
            }
            IList<int> answer = new List<int>() { };
            for(int i =0; i < nums.Length; i++)
            {
                if(nums[i] > 0)
                {
                    answer.Add(i);
                }
            }
            return answer;
        }

        public IList<int> FindDisappearedNumbers_R2(int[] nums) {
            HashSet<int> set = new HashSet<int>() { };
            int n = nums.Length;
            while (n > 0)
            {
                set.Add(n);
                n--;
            }
            foreach (var num in nums)
            {
                if (set.Contains(num))
                {
                    set.Remove(num);
                }
            }
            return set.ToList<int>();
        }

        public IList<int> FindDisappearedNumbers_R3(int[] nums) { 
            for(int i =0; i < nums.Length; i++)
            {
                var index = Math.Abs(nums[i]);
                nums[index - 1] = -Math.Abs(nums[index - 1]);
            }
            IList<int> list = new List<int>() { };
            for(int i =0; i < nums.Length; i++)
            {
                if (nums[i] < 0)
                {
                    list.Add(i);
                }
            }
            return list;
        }
    }
}
