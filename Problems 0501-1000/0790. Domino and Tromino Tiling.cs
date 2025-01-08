using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0501_1000._0751_0800
{
    internal class _0790
    {
        #region 09/17/2023
        public int NumTilings(int n)
        {
            return helper(n);
        }
        public int helper(int n)
        {

            return 0;

        }
        #endregion

        #region 09/29/2024
        Dictionary<int,int> dic_2024_09_29= new Dictionary<int,int>();
        public int NumTilings_2024_09_29(int n)
        {
            return helper_2024_09_29(n);
        }
        public int helper_2024_09_29(int n)
        {
            if (n <= 0) return 0;
            if (n == 1) return 1;
            if (n == 2) return 2;
            if (n == 3) return 5;
            if (dic_2024_09_29.ContainsKey(n)) return dic_2024_09_29[n];
            int val = helper_2024_09_29(n - 1) + helper_2024_09_29(n - 2) + 2 * helper_2024_09_29(n - 3);

            dic_2024_09_29.Add(n, val);
            return val;

        }

        #endregion
    }
}
