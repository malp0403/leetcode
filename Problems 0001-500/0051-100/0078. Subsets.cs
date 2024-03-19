using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0078
    {
        #region LeetCode Approach 1: Cascading
        public IList<IList<int>> Subsets_Approach1(int[] nums)
        {
            IList<IList<int>> output = new List<IList<int>>();
            output.Add(new List<int>());
            foreach (var item1 in nums)
            {
                IList<IList<int>> newSet = new List<IList<int>>() { };

                foreach (var item2 in output)
                {
                    List<int> temp = new List<int>(item2) {item1 };
                    newSet.Add(temp);
                }

                foreach (var item3 in newSet)
                {
                    output.Add(item3);
                }

            }

            return output;
        }
        #endregion

        #region answer
        IList<IList<int>> ans = new List<IList<int>>() { };
        //*************** back tracking********************
        public IList<IList<int>> Subsets(int[] nums)
        {
            ans = new List<IList<int>>() { };
            for(int i=0; i < nums.Length + 1; i++)
            {
                backTracking(0, new List<int>() { }, nums, i);
            }
            return ans;

        }
        public void backTracking(int start,List<int> list,int[] nums,int total)
        {
            if(total == 2)
            {
                var s = "t";
            }
            if(list.Count == total)
            {
                ans.Add(list.Select(x=>x).ToList());return;
            }
            for(int i = start; i < nums.Length; i++)
            {
                list.Add(nums[i]);
                backTracking(i + 1, list, nums, total);
                list.RemoveAt(list.Count - 1);
            }
        }
        //************Bit*********************
        public IList<IList<int>> Subsets_V2(int[] nums)
        {
            int n = nums.Length;
            for(int i = (int)Math.Pow(2, n); i < (int)Math.Pow(2, n + 1); i++)
            {
                string bitmask = Convert.ToString(i, 2).Substring(1);
                List<int> curr = new List<int>() { };
                for(int j = 0; j < n; j++)
                {
                    if(bitmask[j] == '1')
                    {
                        curr.Add(nums[j]);
                    }
                }
                ans.Add(curr);
            }
            return ans;
        }
        #endregion

        #region 08/10/2022 BitMask
        public IList<IList<int>> Subsets_20220810(int[] nums)
        {
            IList<IList<int>> res = new List<IList<int>>() { };
            int n = nums.Length;
            for(int i = (int)Math.Pow(2, n); i < Math.Pow(2, n + 1); i++)
            {
                string bitMask = Convert.ToString(i, 2).Substring(1);
                IList<int> list = new List<int>() { };
                for(int j=0; j < bitMask.Length; j++)
                {
                    if(bitMask[j] == '1')
                    {
                        list.Add(nums[j]);
                    }
                }
                res.Add(list);
            }

            return res;
        }
        #endregion

        #region 03/09/2024 Approach 1: Cascading
        public IList<IList<int>> Subsets_2024_03_09(int[] nums)
        {
            IList<IList<int>> output = new List<IList<int>>();
            output.Add(new List<int>());
            foreach (var item1 in nums)
            {
                IList<IList<int>> newSet = new List<IList<int>>() {};

                foreach (var item2 in output)
                {
                    List<int> temp = new List<int>(item2);
                    temp.Add(item1);
                    newSet.Add(temp);
                }

                foreach (var item3 in newSet)
                {
                    output.Add(item3);
                }

            }

            return output;
        }
        #endregion

    }
}
