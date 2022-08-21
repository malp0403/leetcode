using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0716
    {
        List<int> storage;
        public _0716()
        {
            storage = new List<int>() { };
        }

        public void Push(int x)
        {
            storage.Add(x);
        }

        public int Pop()
        {
            int result = storage[storage.Count - 1];
            storage.RemoveAt(storage.Count - 1);
            return result;
        }

        public int Top()
        {
            return storage[storage.Count - 1];
        }

        public int PeekMax()
        {
            int prev = storage[0];
            int indx = 0;
            for(int i = 1; i < storage.Count; i++)
            {
                if (storage[i] >= prev)
                {
                    prev = storage[i];
                    indx = i;
                }
            }
            return storage[indx];
        }

        public int PopMax()
        {
            int prev = storage[0];
            int indx = 0;
            for (int i = 1; i < storage.Count; i++)
            {
                if (storage[i] >= prev)
                {
                    prev = storage[i];
                    indx = i;
                }
            }
            int result = storage[indx];
            storage.RemoveAt(indx);
            return result;
        }
    }
}
