using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0090
    {

        #region LeetCode Approach 2: Cascading (Iterative)
        public IList<IList<int>> SubsetsWithDup_Approach2(int[] nums)
        {
            Array.Sort(nums);
            IList<IList<int>> answer = new List<IList<int>>();
            answer.Add(new List<int>());     
            int subsetSize = 0;
            for (int i =0; i < nums.Length; i++)
            {

                int startIndex =  i == 0 || nums[i] != nums[i - 1] ? 0 : subsetSize;

                subsetSize = answer.Count;

                for(; startIndex < subsetSize; startIndex++)
                {
                    List<int> temp = new List<int>(answer[startIndex]);
                    temp.Add(nums[i]);
                    answer.Add(temp);
                }

            }
            return answer;

        }
        #endregion

        #region Approach 3: Backtracking
        public IList<IList<int>> SubsetsWithDup_Backtracking(int[] nums)
        {
            Array.Sort(nums);
            IList<IList<int>> answer = new List<IList<int>>();
            helper_Backtracking(answer, new List<int>(), nums, 0);
            return answer;
        }

        public void helper_Backtracking(IList<IList<int>> answer, List<int> cur, int[] nums,int index)
        {
            answer.Add(new List<int>(cur));

            for(int i = index;i < nums.Length; i++)
            {
                if (i != index && nums[i] == nums[i - 1]) continue;
                cur.Add(nums[i]);
                helper_Backtracking(answer, cur, nums, i + 1);
                cur.RemoveAt(cur.Count - 1);
            }
        }
            #endregion
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
