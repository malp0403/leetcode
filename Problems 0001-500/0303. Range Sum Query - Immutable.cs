using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0303
    {
        #region Solution
        //int[] sums;
        //public _0303(int[] nums)
        //{
        //    sums = Enumerable.Repeat(0, nums.Length).ToArray();
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if (i == 0)
        //        {
        //            sums[i] = nums[0];
        //        }
        //        else
        //        {
        //            sums[i] = sums[i - 1] + nums[i];
        //        }
        //    }
        //}

        //public int SumRange(int left, int right)
        //{
        //    if (left == 0) return sums[right];
        //    else return sums[right] - sums[left - 1];
        //}
        #endregion

        #region 07/22/2024
        //int[] _num;
        //public NumArray(int[] nums)
        //{
        //    _num = nums;
        //    for (int i =1;i < nums.Length; i++)
        //    {
        //        _num[i] = _num[i - 1] + _num[i];
        //    }
        //}

        //public int SumRange(int left, int right)
        //{
        //    if(left == 0)
        //    {
        //        return _num[right];
        //    }
        //    return _num[right] - _num[left - 1];
        //}
        #endregion
    }
}
