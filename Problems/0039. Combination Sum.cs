using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0039
    {
        IList<IList<int>> ans;
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            ans = new List<IList<int>>() { };
            backTracking(new List<int>() { }, 0, 0, target, candidates);
            return ans;

        }
        public void backTracking(List<int> list,int indx,int sum,int target,int[] candidates)
        {
            if (sum == target)
            {
                ans.Add(list.Select(x => x).ToList());
            }
            else if (sum > target) return;

            for(int i =indx; i < candidates.Length; i++)
            {
                list.Add(candidates[i]);
                backTracking(list, i, sum+ candidates[i], target, candidates);
                list.RemoveAt(list.Count - 1);
            }
        }
    }
}
