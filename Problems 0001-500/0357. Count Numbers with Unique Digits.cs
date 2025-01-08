using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0351_0400
{
    internal class _0357
    {
        #region 09/01/2024
        public int CountNumbersWithUniqueDigits(int n)
        {
            int[] arr = Enumerable.Repeat(0, n + 1).ToArray();
            arr[0] = 1;
            for (int i =1; i <= n; i++)
            {
                int result = 9;
                int multi = 9;
                int temp = i;
                while(temp > 1)
                {
                    result *= multi;
                    multi -= 1;
                    temp--;
                }
                arr[i] = result;
            }

            int sum = 0;
            for(int i=0; i <= n; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        #endregion
    }
}
