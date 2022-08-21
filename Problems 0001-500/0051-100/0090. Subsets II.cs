using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0090
    {
        IList<IList<int>> answer = new List<IList<int>>() { };
        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            Array.Sort(nums);
            helper(0, new List<int>() { }, nums);

            return answer;
        }
        public void helper(int start,List<int> list,int[] nums)
        {
            answer.Add(list.Select(x => x).ToList());

            for(int i = start; i < nums.Length; i++)
            {
                if(i == start || (i != start && nums[i] != nums[i-1]))
                {
                    list.Add(nums[i]);
                    helper(i+1, list, nums);
                    list.RemoveAt(list.Count - 1);
                }
            }
        }
    }
}
