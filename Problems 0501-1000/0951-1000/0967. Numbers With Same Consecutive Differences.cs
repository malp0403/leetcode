using leetcode.BinarySearch;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Examples
/*
 Given two integers n and k, return an array of all the integers of length n where the difference between every two consecutive digits is k. You may return the answer in any order.

Note that the integers should not have leading zeros. Integers as 02 and 043 are not allowed.

 

Example 1:

Input: n = 3, k = 7
Output: [181,292,707,818,929]
Explanation: Note that 070 is not a valid number, because it has leading zeroes.
Example 2:

Input: n = 2, k = 1
Output: [10,12,21,23,32,34,43,45,54,56,65,67,76,78,87,89,98]
 */
#endregion

#region Test
/*
 
 */
#endregion
namespace leetcode.Problems_0501_1000._0951_1000
{
    internal class _0967
    {
        #region 11/13/2023
        List<int> ans;
        public int[] NumsSameConsecDiff_20231113(int n, int k)
        {
            ans = new List<int>();
            for(int i =1;i < 10; i++)
            {
                dfs(n-1, k, i, i);
            }
            return ans.ToArray();
        }
        public void dfs(int n,int k,int number,int prev)
        {
            if(n == 0)
            {
                ans.Add(number);
                return;
            }

            if(k == 0)
            {
                int increase = prev + k;
                dfs(n - 1, k, number * 10 + increase, increase);

            }
            else
            {
                int increase = prev + k;
                int descrease = prev - k;

                if (increase < 10)
                {
                    dfs(n - 1, k, number * 10 + increase, increase);
                }
                if (descrease >= 0)
                {
                    dfs(n - 1, k, number * 10 + descrease, descrease);
                }
            }


        }
        #endregion
    }
}
