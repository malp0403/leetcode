using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0146
    {
        #region my try

        //Dictionary<int, int> dic = new Dictionary<int, int>() { };
        //List<int> li = new List<int>() { };
        //int capacity = 0;

        //public _0146(int capacity)
        //{
        //    this.capacity = capacity;
        //}

        //public int Get(int key)
        //{
        //    if (dic.ContainsKey(key))
        //    {
        //        li.Remove(key);
        //        li.Add(key);
        //        return dic[key];
        //    }
        //    return -1;

        //}

        //public void Put(int key, int value)
        //{
        //    if (dic.ContainsKey(key))
        //    {
        //        dic[key] = value;
        //    }
        //    else
        //    {
        //        dic.Add(key, value);
        //    }

        //    if (li.Count >= capacity && !li.Contains(key))
        //    {
        //        //remove first element;
        //        int k = li[0];
        //        dic.Remove(k);
        //        li.RemoveAt(0);
        //    }
        //    if (li.Contains(key))
        //    {
        //        li.Remove(key);
        //    }
        //    li.Add(key);

        //}
        #endregion

        #region 12/29/2022
        Dictionary<int, int> dic;
        List<int> list;
        int _capacity;
        public _0146(int capacity)
        {
            _capacity = capacity;
            dic = new Dictionary<int, int>() { };
            list = new List<int>() { };
        }
        public int Get(int key)
        {
            if (dic.ContainsKey(key)) {
                list.Remove(key);
                list.Add(key);
                return dic[key];
            }
            return -1;
        }

        public void Put(int key, int value)
        {
            if(list.Count < _capacity || dic.ContainsKey(key))
            {
                if (dic.ContainsKey(key))
                {
                    dic[key] = value;
                    list.Remove(key);
                }
                else
                {
                    dic.Add(key, value);
                }
                list.Add(key);
            }
            else
            {
                int remove = list[0];
                dic.Remove(remove);
                list.Remove(remove);

                dic.Add(key, value);
                list.Add(key);
            }
        }
        #endregion
    }
}
