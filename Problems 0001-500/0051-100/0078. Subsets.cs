using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0078
    {
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
    }
}
