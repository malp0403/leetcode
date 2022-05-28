using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.BinarySearch
{
    class SearchInsortedArray
    {
        public int Search(int target)
        {
            ArrayReader reader = new ArrayReader() { };
            int l = 0;
            int r = (int)Math.Pow(10, 4) - 1;
            while (l <= r)
            {
                int mid = l + (r-l) / 2;
                int res = reader.Get(mid);
                if(res == Int32.MaxValue)
                {
                    r = mid - 1;
                }
                else
                {
                    if (res == target) return mid;
                    else if (res < target) l = mid + 1;
                    else r = mid-1;
                }
            }
            return -1;
        }
        public class ArrayReader
        {
            int[] arr = new int[] { -1, 0, 3, 5, 9, 12 };
            public ArrayReader() { }
            public int Get(int index)
            {
                if (index >= arr.Length) return Int32.MaxValue;
                else return arr[index];
            }
        }
    }
}
