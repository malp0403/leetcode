using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0251_0300
{
    internal class _0276
    {
        #region 07/11/2024
        int count_2024_07_11 = 0;
        int[][] dp;

        Dictionary<int, int> dic_2024_07_11;
        public int NumWays(int n, int k)
        {
            if (k == 1 && n >= 3) return 0;
            dic_2024_07_11 = new Dictionary<int, int>();

            return helper_2024_07_11(n,k);

        }

        public int helper_2024_07_11(int i ,int k)
        {
            if (i == 1) return k;
            if (i == 2) return k * k;

            if (dic_2024_07_11.ContainsKey(i)) return dic_2024_07_11[i];

            dic_2024_07_11.Add(i, (k - 1) * (helper_2024_07_11(i - 1, k) + helper_2024_07_11(i - 2, k)));

            return dic_2024_07_11[i];
        }

        public void dfs_2024_07_11(int[] curArry,int index,int n, int k)
        {
            if(index == n)
            {
                count_2024_07_11++;
                return;
            }

            for(int i =0; i < k; i++)
            {
                if(index >= 2)
                {
                    if (curArry[index-2] != i)
                    {
                        curArry[index] = i;
                        dfs_2024_07_11(curArry, index + 1, n, k);
                        curArry[index] = -1;
                    }
                }
                else
                {
                    curArry[index] = i;

                    dfs_2024_07_11(curArry, index + 1, n, k);

                    curArry[index] = -1;
                }
            }


     
        }
        #endregion
    }
}
