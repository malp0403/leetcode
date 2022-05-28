using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _46
    {
        public IList<IList<int>> Permute(int[] nums)
        {
            List<IList<int>> l = new List<IList<int>>() { };
            Stack<int> cur = new Stack<int>() { };
            Dictionary<int, int> dic = new Dictionary<int, int>() { };

            InsertNew(l, cur, nums.Select(x=>x).ToList(), dic);

            //for (int i = 0; i < nums.Length; i++) {
            //    cur.Push(nums[i]);
            //    List<int> temp = nums.Select(x => x).ToList();
            //    temp.RemoveAt(i);
            //    InsertNew(l, cur, temp);
            //    cur.Pop();
            //}
            return l;
        }

        public void InsertNew(List<IList<int>> l, Stack<int> cur, List<int> remains,Dictionary<int,int> dic ) {
            if (remains.Count == 0) {
                if(!l.Contains(cur.ToList()))
                l.Add(cur.ToList());
                return;
            }
            for (int i = 0; i < remains.Count; i++) {
                    cur.Push(remains[i]);
                    List<int> newList = new List<int>(remains);
                    newList.RemoveAt(i);
                    InsertNew(l, cur, newList, dic);
                    cur.Pop();

            }
        }
    }
}
