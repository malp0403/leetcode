using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0380
    {
        List<int> li;
        public _0380()
        {
            li = new List<int>() { };
        }

        public bool Insert(int val)
        {
            if (li.Contains(val)) return false;
            else
            {
                li.Add(val);
                return true;
            }
        }

        public bool Remove(int val)
        {
            if (li.Contains(val)) { li.Remove(val); return true; }
            else return false;
        }

        public int GetRandom()
        {
            int count = li.Count;
            int ind = new Random().Next(0, count);

            return li[ind];
        }
    }
}
