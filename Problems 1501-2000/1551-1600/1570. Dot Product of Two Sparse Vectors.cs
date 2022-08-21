using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _1570SparseVector
    {
        Dictionary<int, int> dic = new Dictionary<int, int>() { };
        public _1570SparseVector(int[] nums)
        {
            for(int i =0; i < nums.Length; i++)
            {
                dic.Add(i, nums[i]);
            }
        }

        // Return the dotProduct of two sparse vectors
        public int DotProduct(_1570SparseVector vec)
        {
            int result = 0;
            foreach(var key in dic.Keys)
            {
                result += (dic[key] * vec.dic[key]);
            }
            return result;
        }
    }
}
