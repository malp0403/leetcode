using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0351_0400
{
    internal class _0397
    {
        #region 09/04/2024
        Dictionary<long, int> dic_2024_09_01;
        public int IntegerReplacement(int n)
        {
            dic_2024_09_01 = new Dictionary<long, int>();
            return dfs(n);
            
        }
        public int dfs(long n)
        {
            if (n == 1) return 0;

            if (dic_2024_09_01.ContainsKey(n)) return dic_2024_09_01[n];

            int ans = 0;
            if( n %2 == 0)
            {
                ans= dfs(n / 2) + 1;
            }
            else
            {
                ans = Math.Min(dfs(n - 1)+1, dfs(n + 1)+1);
            }

            dic_2024_09_01.Add(n, ans);

            return dic_2024_09_01[n];


        }
        #endregion

        #region 09/04/2024  if (num+1)%4 ==0 then use +1 instead of -1 --->>> someone else solution
        public int IntegerReplacement_app2(int n)
        {
            return helper_app2(n);
 

        }
        public int helper_app2(long n)
        {
            if (n == 1) return 0;
            if (n == 3) return 2;
            if (n % 2 == 0) return helper_app2(n / 2);
            else
            {
                if( (n+1) %4 ==0) return helper_app2(n + 1);
                else return helper_app2(n -1);
            }


          


        }
        #endregion
    }
}
