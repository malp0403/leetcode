using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0501_1000._0751_0800
{
    internal class _0796
    {
        #region 09/18/2023
        public bool RotateString(string s, string goal)
        {
            int count = s.Length;

            while (count > 0)
            {
                s = s.Substring(1) + s[0];
                if(s == goal)
                {
                    return true;
                }
                count--;
            }
            return false;
        }
        #endregion

        #region LeetCode Solution1: Brutal force 

        #endregion
        #region LeetCode Solution2: Simple Check Contains
        public bool RotateString_contains(string s, string goal)
        {
            return s.Length == goal.Length && (s + s).Contains(goal);
        }
        #endregion
        #region LeetCode Solution3: Rolling Hash

        #endregion
        #region LeetCode Solution4: KMP (Knuth-Morris-Pratt) 

        #endregion
    }
}
