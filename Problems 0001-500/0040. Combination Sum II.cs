using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0040
    {
        #region Solution
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
            if (sum == target)
            {
                result.Add(list.Select(x => x).ToList());
            }
            else if (sum > target)
            {
                return;
            }
            else
            {
                for (int i = startIndx; i < candidates.Length; i++)
                {
                    if (i > startIndx && candidates[i] == candidates[i - 1])
                    {
                        continue;
                    }

                    list.Add(candidates[i]);
                    helper(candidates, target, list, i + 1, sum + candidates[i]);
                    list.RemoveAt(list.Count - 1);

                }
            }
        }
        #endregion

        #region 02/19/2024
        IList<IList<int>> answer= new List<IList<int>>();
        public IList<IList<int>> CombinationSum2_2024_02_19(int[] candidates, int target)
        {
            Array.Sort(candidates, (x, y) => { return y - x; });
            helper_2024_02_19(0, candidates, target, new List<int>());

            return answer;
        }

        public void helper_2024_02_19(int index, int[] candidates,int remains,List<int> list)
        {

            if(remains == 0)
            {
                answer.Add(new List<int>(list));
            }
            else if(remains >0)
            {
                if (index >= candidates.Length) return;

                list.Add(candidates[index]);
                helper_2024_02_19(index + 1, candidates, remains - candidates[index], list);
                list.RemoveAt(list.Count - 1);

                int nexIndex = index + 1;
                while(nexIndex <candidates.Length && candidates[nexIndex] == candidates[index])
                {
                    nexIndex++;
                }
                helper_2024_02_19(nexIndex, candidates, remains, list);
            }
        }
        #endregion

    }
}
