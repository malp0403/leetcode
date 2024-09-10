using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using static leetcode.Problems._0339;

namespace leetcode.Problems
{
    class _0341
    {

        #region Solution
        //List<int> list = new List<int>() { };
        //int ind = 0;
        //public _0341(IList<NestedInteger> nestedList)
        //{
        //    list = new List<int>() { };
        //    transform(nestedList);
        //}

        //public bool HasNext()
        //{
        //    return ind < list.Count;
        //}

        //public int Next()
        //{
        //    if (ind >= list.Count) return 0;
        //    var res = list[ind];
        //    ind++;
        //    return res;
        //}
        //public void transform(IList<NestedInteger> i)
        //{
        //    foreach (var item in i)
        //    {
        //        if (item.IsInteger()) list.Add(item.GetInteger());
        //        else
        //        {
        //            transform(item.GetList());
        //        }
        //    }
        //}
        #endregion

        #region 08/31/2024
        List<int> _list = new List<int>();
        int index = 0;
        public _0341(IList<NestedInteger> nestedList)
        {
            _list = helper(nestedList);
        }

        public bool HasNext()
        {
            return index < _list.Count;
        }

        public int Next()
        {
            
            return _list[index++];
        }
        public List<int> helper(IList<NestedInteger> nestedList)
        {
            List<int> list = new List<int>();
            foreach (NestedInteger ele in nestedList)
            {
                if (ele.IsInteger()) list.Add(ele.GetInteger());
                else
                {
                    list.AddRange(helper(ele.GetList()));
                }
            }

            return list;
        }
        #endregion
    }
}
