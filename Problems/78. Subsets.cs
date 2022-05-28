using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _78
    {
        //recurseive
        public IList<IList<int>> recursive(int[] nums)
        {
            //IList<IList<int>> l = new List<IuList<int>>();
            IList<List<int>> l2 = new List<List<int>>();
            l2.Add(new List<int>() { });
            for (int i = 0; i < nums.Length; i++)
            {
                l2 = addElementToResult(l2, nums[i]);
            }
            return new List<IList<int>>(l2);
        }
        public IList<List<int>> addElementToResult(IList<List<int>> l2, int number)
        {
            var l3 = l2.Select(x => x).ToList();
            foreach (var ele in l2)
            {
                var temp = ele.Select(x => x).ToList();
                temp.Add(number);
                l3.Add(temp);
            }
            return l3;
        }

        //backtrack
        int n, k;
        IList<IList<int>> res = new List<IList<int>>() { };
        public IList<IList<int>> main_backTrack(int[] nums)
        {
            n = nums.Length;
            for (k = 0; k < nums.Length + 1; k++)
            {
                backTrack(0, new Stack<int>() { }, nums);

            }
            return res;
        }
        public void backTrack(int start, Stack<int> s, int[] nums)
        {
            if (s.Count == k)
            {
                res.Add(s.ToList());
                return;
            }
            for (int j = start; j < n; j++)
            {
                s.Push(nums[j]);
                backTrack(j + 1, new Stack<int>(s), nums);
                s.Pop();
            }
        }

        //bit

        public IList<IList<int>> BitMethod(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>() { };
            var  n1 = Math.Pow(2, nums.Length);
            for (int i = 0; i < n1; i++)
            {
                byte[] temp = BitConverter.GetBytes(i);
                List<int> list = new List<int>();
                Console.WriteLine(temp.Length);
                for (int j = 0; j < temp.Length; j++)
                {
                    if (temp[j] != '0')
                    {
                        list.Add(nums[j]);
                    }
                }
                result.Add(list);
            }
            return result;

        }
    }
}
