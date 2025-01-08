using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0398
    {
        #region 01/11/2022   
        //Dictionary<int, List<int>> dic = new Dictionary<int, List<int>>() { };
        //public _0398(int[] nums)
        //{
        //    for(int i =0; i < nums.Length; i++)
        //    {
        //        if (dic.ContainsKey(nums[i])) { dic[i].Add(i); }
        //        else
        //            dic.Add(nums[i], new List<int>() { i });
        //    }
        //}

        //public int Pick(int target)
        //{
        //    if (!dic.ContainsKey(target)) return 0;
        //    int sum = dic[target].Count;
        //    Random ran = new Random();
        //    return dic[target][ran.Next(0, sum)];
        //}

        //01-11-2022-----------------------------
        //Dictionary<int, List<int>> dic = new Dictionary<int, List<int>>() { };
        //public _0398(int[] nums)
        //{
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if (!dic.ContainsKey(nums[i])) dic.Add(nums[i], new List<int>() { i });
        //        else
        //        {
        //            dic[nums[i]].Add(i);
        //        }
        //    }
        //}
        //public int Pick(int target)
        //{
        //    List<int> list = dic[target];
        //    int indx = new Random().Next(0, list.Count);
        //    return list[indx];
        //}
        #endregion

        #region 09/04/2024
        Dictionary<int, List<int>> dic;
        public _0398(int[] nums)
        {
            dic = new Dictionary<int, List<int>>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!dic.ContainsKey(nums[i]))
                {
                    dic.Add(nums[i], new List<int>() { i });
                }
                else
                {
                    dic[nums[i]].Add(i);
                }
            }
        }

        public int Pick(int target)
        {
            List<int> list = dic[target];

            int index= new Random().Next(list.Count);

            return list[index];
        }
        #endregion
    }
}
