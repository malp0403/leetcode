using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0528
    {
        #region 10/02/2024 Approach 1: Prefix Sums with Linear Search
        int[] prefixSum;
        public _0528(int[] w)
        {
            prefixSum = Enumerable.Repeat(0,w.Length).ToArray();
            for(int i =0; i < w.Length; i++)
            {
                prefixSum[i] = i == 0 ? w[i] : (w[i] + prefixSum[i - 1]);
            }
 
        }

        public int PickIndex()
        {
            
            double random = new Random().NextDouble();
            double target= random* prefixSum[prefixSum.Length-1];

            for (int i =0;i < prefixSum.Length; i++)
            {
                 if(target < prefixSum[i])
                {
                    return i;
                }
            }
            return prefixSum.Length-1;

        }
        #endregion
    }
}
        //List<int> li = new List<int>() { };
        //int sum = 0;
        //public Solution(int[] w)
        //{
           
        //    for(int i=0; i < w.Length; i++)
        //    {
        //        sum += w[i];
        //        li.Add(sum);
        //    }

        //}

        //public int PickIndex()
        //{
        //    Random r = new Random();
        //    int temp = r.Next(1, sum + 1);
        //    return li.FindIndex(x => x >= temp);
        //    //return li.FindIndex(x => x >= new Random().Next(1, sum + 1));
        //}