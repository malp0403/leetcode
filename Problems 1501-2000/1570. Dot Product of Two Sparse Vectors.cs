using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _1570SparseVector
    {
        #region Approach 1: Non-efficient Array Approach
        //Dictionary<int, int> dic = new Dictionary<int, int>() { };
        //public _1570SparseVector(int[] nums)
        //{
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        dic.Add(i, nums[i]);
        //    }
        //}

        //// Return the dotProduct of two sparse vectors
        //public int DotProduct(_1570SparseVector vec)
        //{
        //    int result = 0;
        //    foreach (var key in dic.Keys)
        //    {
        //        result += (dic[key] * vec.dic[key]);
        //    }
        //    return result;
        //}
        #endregion

        #region Approach 2: Hash 
        //public Dictionary<int, int> dic_2024_10_02;
        //public _1570SparseVector(int[] nums)
        //{
        //    dic_2024_10_02 = new Dictionary<int, int>();
        //    for(int i =0; i < nums.Length; i++)
        //    {
        //        if (nums[i] != 0)
        //        {
        //            dic_2024_10_02.Add(i, nums[i]);
        //        }
        //    }
        //}

        //// Return the dotProduct of two sparse vectors
        //public int DotProduct(_1570SparseVector vec)
        //{
        //    int result = 0;
        //    HashSet<int> set = dic_2024_10_02.Keys.ToHashSet();
        //    foreach (var key in vec.dic_2024_10_02.Keys)
        //    {
        //        if (set.Contains(key))
        //        {
        //            result += vec.dic_2024_10_02[key] * dic_2024_10_02[key];
        //        }
        //    }
        //    return result;
        //}
        #endregion

        #region Approach 3: Index-Value Pairs

        #endregion

        #region 10/06/2024

        //HashSet<int> nonZeroSet= new HashSet<int>();
        //int[] _nums;
        //public SparseVector(int[] nums)
        //{
        //    _nums= nums;
        //    for(int i =0; i<nums.Length; i++)
        //    {
        //        if (nums[i] != 0)
        //        {
        //            nonZeroSet.Add(i);

        //        }
        //    }

        //}
        //public int DotProduct(SparseVector vec)
        //{
        //    int sum = 0;
        //    foreach (int i in vec.nonZeroSet)
        //    {
        //        if (nonZeroSet.Contains(i))
        //        {
        //            sum += (vec._nums[i] * _nums[i]);
        //        }
        //    }
        //    return sum;
        //}
        #endregion


    }
}
