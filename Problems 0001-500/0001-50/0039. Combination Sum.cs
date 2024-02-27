using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0039
    {
        #region answer;
        IList<IList<int>> ans;
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            ans = new List<IList<int>>() { };
            backTracking(new List<int>() { }, 0, 0, target, candidates);
            return ans;

        }
        public void backTracking(List<int> list, int indx, int sum, int target, int[] candidates)
        {
            if (sum == target)
            {
                ans.Add(list.Select(x => x).ToList());
            }
            else if (sum > target) return;

            for (int i = indx; i < candidates.Length; i++)
            {
                list.Add(candidates[i]);
                backTracking(list, i, sum + candidates[i], target, candidates);
                list.RemoveAt(list.Count - 1);
            }
        }
        #endregion

        #region 08/01/2022
        IList<IList<int>> result_08012022;
        int target_08012022;
        public IList<IList<int>> CombinationSum_20220801(int[] candidates, int target)
        {
            target_08012022 = target;
            result_08012022 = new List<IList<int>>() { };
            helper(candidates, new List<int>() { }, 0, 0);
            return result_08012022;
        }
        public void helper(int[] candidates, List<int> list, int startInx, int sum)
        {
            if(sum == target_08012022)
            {
                result_08012022.Add(list.Select(x=>x).ToList());
                return;
            }
            else if(sum > target_08012022)
            {
                return;
            }
            else
            {
                for(int i = startInx; i < candidates.Length; i++)
                {
                    list.Add(candidates[i]);
                    helper(candidates, list, i, sum + candidates[i]);
                    list.RemoveAt(list.Count - 1);
                }
            }
        }
        #endregion

        #region 02/19/2024
        IList<IList<int>> answer = new List<IList<int>>();
        public IList<IList<int>> CombinationSum_2024_02_19(int[] candidates, int target)
        {
            helper_2024_02_19(0,candidates,target,new List<int>());
            return answer;
        }
        public void helper_2024_02_19(int index1, int[] candidates,int remains,List<int> curList)
        {
            if(remains ==0)
            {
                answer.Add(new List<int>(curList));
            }else if(remains > 0)
            {
                for(int i = index1; i < candidates.Length; i++)
                {
                    if(remains - candidates[i] >= 0)
                    {
                        curList.Add(candidates[i]);
                        helper_2024_02_19(i, candidates, remains - candidates[i], curList);
                        curList.RemoveAt(curList.Count - 1);
                    }
                }
            }
        }
        #endregion
    }
}
