using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0040
    {
        IList<IList<int>> result;
        public IList<IList<int>> CombinationSum2(int[] candidates, int target)
        {
            Array.Sort(candidates);
            result = new List<IList<int>>() { };
            helper(candidates, target, new List<int>() { }, 0, 0);
            return result;

        }
        public void helper(int[] candidates, int target, List<int> list, int startIndx, int sum)
        {
            if(sum== target)
            {
                result.Add(list.Select(x => x).ToList());
            }else if (sum > target)
            {
                return;
            }
            else
            {
                for(int i =startIndx;i < candidates.Length; i++)
                {
                    if(i > startIndx && candidates[i] == candidates[i-1])
                    {
                        continue;
                    }

                    list.Add(candidates[i]);
                    helper(candidates, target, list, i + 1, sum + candidates[i]);
                    list.RemoveAt(list.Count - 1);
                    
                }
            }
        }
    }
}
