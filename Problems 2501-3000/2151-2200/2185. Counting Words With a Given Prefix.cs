using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_2501_3000._2151_2200
{
    internal class _2185
    {
        #region 10/08/2023
        public int PrefixCount(string[] words, string pref)
        {
            int len = pref.Length;
            int count = 0;
            foreach (var item in words)
            {
                if(item.Length >= len && item.Substring(0,len) == pref)
                {
                    count++;
                }
            }
            return count;
        }
        #endregion
    }
}
