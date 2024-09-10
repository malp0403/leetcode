using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0351_0400
{
    internal class _0383
    {
        #region 09/03/2024
        public bool CanConstruct(string ransomNote, string magazine)
        {
            int[] mag = Enumerable.Repeat(0, 26).ToArray();
            foreach (char c in magazine)
            {
                mag[c - 'a']++;
            }

            foreach (char c in ransomNote)
            {
                mag[c - 'a']--;
                if (mag[c - 'a'] < 0) return false;
            }
            return true;
        }
        #endregion
    }
}
