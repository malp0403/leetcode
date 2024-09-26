using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0622
    {
        List<int> list;
        int limit;
        public _0622(int k)
        {
            list = new List<int>() { };
            limit = k;
        }

        public bool EnQueue(int value)
        {
            if (!this.IsFull())
            {
                list.Add(value);
                return true;
            }
            return false;
        }

        public bool DeQueue()
        {
            if (list.Count == 0) return false;
            else
            {
                list.RemoveAt(0);
                return true;
            }
        }

        public int Front()
        {
            if (list.Count == 0) return -1;
            return list[0];
        }

        public int Rear()
        {
            if (list.Count == 0) return -1;
            return list[list.Count - 1];
        }

        public bool IsEmpty()
        {
            return list.Count == 0;
        }

        public bool IsFull()
        {
            return list.Count == limit;
        }
    }
}
