using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0380
    {
        #region Approach 1: HashMap + ArrayList

        #endregion

        #region solution
        //List<int> li;
        //public _0380()
        //{
        //    li = new List<int>() { };
        //}

        //public bool Insert(int val)
        //{
        //    if (li.Contains(val)) return false;
        //    else
        //    {
        //        li.Add(val);
        //        return true;
        //    }
        //}

        //public bool Remove(int val)
        //{
        //    if (li.Contains(val)) { li.Remove(val); return true; }
        //    else return false;
        //}

        //public int GetRandom()
        //{
        //    int count = li.Count;
        //    int ind = new Random().Next(0, count);

        //    return li[ind];
        //}
        #endregion

        #region 09/03/2024
        List<int> list;
        public _0380()
        {
            list = new List<int>();
        }

        public bool Insert(int val)
        {
            if(list.IndexOf(val) >=0)
            {
                return false;
            }
            else
            {
                list.Add(val);
                return true;
            }
        }

        public bool Remove(int val)
        {
            int index = list.IndexOf(val);
            if (index < 0) return false;
            list.RemoveAt(index);
            return true;
        }

        public int GetRandom()
        {
            int index = new Random().Next(0,list.Count);
            return list[index];
        }
        #endregion
    }
}
