using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _90
    {
        // recursive
        public  IList<IList<int>> SubsetsWithDup_recursive(int[] nums)
        {
            IList<IList<int>> res = new List<IList<int>>() { new List<int>() { } };
            Dictionary<int, int> dic = new Dictionary<int, int>() { };
            for (int i = 0; i < nums.Length; i++)
            {
                bool exists = dic.ContainsKey(nums[i]);
                if (exists) dic[nums[i]]++;
                else dic.Add(nums[i], 1);

                res = addRecursive(res, nums[i], dic);
            }

            return res;
        }
        public IList<IList<int>> addRecursive(IList<IList<int>> res, int num, Dictionary<int, int> dic)
        {
            int count = dic[num];
            var resCopy = res.Select(x => x).ToList();
            foreach (var ele in resCopy)
            {
                if (count == 1)
                {
                    var eleCopy = ele.Select(x => x).ToList();
                    eleCopy.Add(num);
                    res.Add(eleCopy);
                }
                else
                {
                    var eleCopy = ele.Select(x => x).ToList();
                    if (eleCopy.FindAll(x => x == num).Count == (count - 1))
                    {
                        eleCopy.Add(num);
                        res.Add(eleCopy);
                    }
                }
            };
            return res;
        }

        //backtrack

       // public IList<IList<int>> SubsetsWithDup_backtrack(int[] nums)
       // {
       //     IList<IList<int>> res = new List<IList<int>>() { new List<int>() { } };
       //     Dictionary<int, int> dic = new Dictionary<int, int>() { };
       //     foreach (var n in nums) {
       //         if (dic.ContainsKey(n)) dic[n]++;
       //         else dic.Add(n, 1);
       //     }
       //     for (int i = 0; i < nums.Length + 1; i++) {
       //         backtrack(res, i,new Stack<int>() { }, dic,i,nums);
       //     }

       //     return res;
       // }
       //public void backtrack(IList<IList<int>> res, int i,Stack<int> s, Dictionary<int, int> dic,int limit,int[] source) {
       //     if (s.Count == limit) {
       //         res.Add(s.ToList());
       //         return;
       //     }
       //     for (int j = i; j < source.Length; j++) {
       //         if (s.Count(x => x == source[j]) != dic[source[j]] - 1){
       //             s.Push(source[j]);
       //             backtrack(res, i + 1, new Stack<int>(s), dic, limit, source);
       //             s.Pop();
       //         }
       //     }
       // }
    }
}
