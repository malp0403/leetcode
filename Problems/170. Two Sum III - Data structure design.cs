using System;
using System.Collections.Generic;

namespace leetcode.Problems
{
    class _170
    {
        private List<int> list;
        public _170() {
            list = new List<int>() { };}
        public void add(int number) {
            list.Add(number);
        }
        public Boolean find(int value)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>() { };

            for (int i = 0; i < list.Count; i++) {
                if (dic.ContainsKey(value - list[i])) {
                    return true;
                }
                if (!dic.ContainsKey(list[i])) {
                    dic.Add(list[i], i);
                }
            }
            return false;
        }
    }
}
