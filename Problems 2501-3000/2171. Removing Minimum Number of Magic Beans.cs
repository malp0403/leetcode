using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_2501_3000._2151_2200
{
    internal class _2171
    {
        #region 10/08/2023 toRemovel = total - (N-j)*beans[j] 
        public long MinimumRemoval(int[] beans)
        {
            long total = 0;
            foreach (int i in beans)
            {
                total += i;
            }
            Array.Sort(beans);

            long min = long.MaxValue;
            for(int i =0; i<beans.Length;i++) {
                min = Math.Min(min, total - (long)(beans.Length - i) * beans[i]);
            }
            return min;

        }
        #endregion
    }
}
