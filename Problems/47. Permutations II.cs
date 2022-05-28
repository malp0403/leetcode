using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _47
    {
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            IList<IList<int>> list = new List<IList<int>>() { };
            List<int> remains = new List<int>() { };
            Stack<int> s = new Stack<int>() { };
            InsertNew(list, s, nums.Select(x=>x).ToList());
            return list;
        }
        public void InsertNew(IList<IList<int>> list, Stack<int> s, List<int> remains) {
            if (remains.Count == 0) {
                list.Add(s.ToList());
            }
            HashSet<int> set = new HashSet<int>();
            for (int i = 0; i < remains.Count;) {
                if (!set.Contains(remains[i])) {
                    s.Push(remains[i]);
                    var temp = new List<int>(remains);
                    temp.RemoveAt(i);
                    InsertNew(list, s, temp);
                    s.Pop();
                }
                set.Add(remains[i]);      
                i++;
            }
            
        }
    }
}
