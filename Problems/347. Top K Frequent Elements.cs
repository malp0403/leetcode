using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _347
    {
        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>() { };
            for(int i =0; i < nums.Length; i++)
            {
                if (!dic.ContainsKey(nums[i])) dic.Add(nums[i], 1);
                else dic[nums[i]]++;
            }

            List<(int freq, int num)> list = new List<(int freq, int num)>() { };
            foreach (var key in dic.Keys)
            {
                list.Add((dic[key], key));
            }
            list.Sort((x,y)=> { return y.freq - x.freq; });

            List<int> ans = new List<int>() { };
            for(int i =0;i < k && i <nums.Length; i++)
            {
                ans.Add(list[i].num);
            }
            return ans.ToArray();
        }
    }
}
