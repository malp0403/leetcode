using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0528
    {
        #region 10/02/2024 Approach 1: Prefix Sums with Linear Search
        //int[] prefixSum;
        //public _0528(int[] w)
        //{
        //    prefixSum = Enumerable.Repeat(0,w.Length).ToArray();
        //    for(int i =0; i < w.Length; i++)
        //    {
        //        prefixSum[i] = i == 0 ? w[i] : (w[i] + prefixSum[i - 1]);
        //    }

        //}

        //public int PickIndex()
        //{

        //    double random = new Random().NextDouble();
        //    double target= random* prefixSum[prefixSum.Length-1];

        //    for (int i =0;i < prefixSum.Length; i++)
        //    {
        //         if(target < prefixSum[i])
        //        {
        //            return i;
        //        }
        //    }
        //    return prefixSum.Length-1;

        //}
        #endregion

        #region 10/02/2024 PrefixSum

        //int[] prefixSum;
        //public _0528(int[] w)
        //{
        //    prefixSum = new int[w.Length];
        //    for (int i = 0; i < w.Length; i++)
        //    {
        //        if (i == 0) { prefixSum[i] = w[i]; }
        //        else
        //        {
        //            prefixSum[i] = prefixSum[i-1] + w[i];
        //        }
        //    }
        //}

        //public int PickIndex()
        //{
        //    double total = prefixSum[prefixSum.Length - 1];
        //    double random = new Random().NextDouble();

        //    for(int i =0; i < prefixSum.Length; i++)
        //    {
        //        if (  random < (prefixSum[i]/total))
        //        {
        //            return i;
        //        }
        //    }

        //    return prefixSum.Length - 1;

        //}
        #endregion


    }
}
