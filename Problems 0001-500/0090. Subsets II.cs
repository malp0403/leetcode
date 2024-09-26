using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0090
    {
        #region Solution
        IList<IList<int>> answer = new List<IList<int>>() { };
        public IList<IList<int>> SubsetsWithDup_(int[] nums)
        {
            Array.Sort(nums);
            helper(0, new List<int>() { }, nums);

            return answer;
        }
        public void helper(int start, List<int> list, int[] nums)
        {
            answer.Add(list.Select(x => x).ToList());

            for (int i = start; i < nums.Length; i++)
            {
                if (i == start || (i != start && nums[i] != nums[i - 1]))
                {
                    list.Add(nums[i]);
                    helper(i + 1, list, nums);
                    list.RemoveAt(list.Count - 1);
                }
            }
        }
        #endregion

        #region 03/17/2024
        public IList<IList<int>> SubsetsWithDup(int[] nums)
        {
            List<IList<int>> answer = new List<IList<int>> ();
            answer.Add(new List<int>());
            int curMax = 0;
            for(int i =0; i < nums.Length; i++)
            {
                List<IList<int>> temp = new List<IList<int>>();
                if (i == 0 || nums[i] != nums[i - 1])
                {
                    foreach (var j in answer)
                    {
                        temp.Add(new List<int>(j) { nums[i] });
                    }

                }
                else
                {
                    foreach (var j in answer)
                    {
                        if (j.Contains(nums[i]) && j.Count == i)
                        {
                            temp.Add(new List<int>(j) { nums[i] });
                        }

                    }
                }

                answer.AddRange(temp);
                curMax++;
            }
            return answer;
        }

        #endregion

    }
}
