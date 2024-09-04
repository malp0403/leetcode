using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0351_0400
{
    internal class _0370
    {
        #region 09/01/2024 Approach 2: Range Caching 差分数组
        public int[] GetModifiedArray_2024_09_01(int length, int[][] updates)
        {
            int[] arr = Enumerable.Repeat(0, length).ToArray();

            foreach (int[] ele in updates)
            {
                arr[ele[0]] += ele[2];
                if (ele[1] +1 < length)
                {
                    arr[ele[1] + 1] -= ele[2];
                }
            }

            for(int i =1;i< length; i++)
            {
                arr[i] += arr[i - 1];
            }

            return arr;
        }
        #endregion
    }
}
