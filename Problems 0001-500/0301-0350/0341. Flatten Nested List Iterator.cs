using System;
using System.Collections.Generic;
using System.Text;
using static leetcode.Problems._0339;

namespace leetcode.Problems
{
    class _0341
    {
        List<int> list = new List<int>() { };
        int ind = 0;
        public _0341(IList<NestedInteger> nestedList)
        {
            list = new List<int>() { };
            transform(nestedList);
        }

        public bool HasNext()
        {
            return ind < list.Count;
        }

        public int Next()
        {
            if (ind >= list.Count) return 0;
            var res = list[ind];
            ind++;
            return res;
        }
        public void transform(IList<NestedInteger> i)
        {
            foreach (var item in i)
            {
                if (item.IsInteger()) list.Add(item.GetInteger());
                else
                {
                    transform(item.GetList());
                }
            }
        }
    }
}
