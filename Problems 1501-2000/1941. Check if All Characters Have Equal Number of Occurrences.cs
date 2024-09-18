using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_1501_2000._1901_1950
{
    internal class _1941
    {
        #region 20231010
        public bool AreOccurrencesEqual(string s)
        {
            int[] records = Enumerable.Repeat(0, 26).ToArray();
            foreach (var i in s)
            {
                records[i - 'a']++;
            }

            int? a =null;
            foreach (var item in records)
            {
                if(item != 0)
                {
                    if( a == null)
                    {
                        a = item;
                    }
                    else
                    {
                        if (a != item) return false;
                    }
                }
            }
            return true;
        }
        #endregion
    }
}
