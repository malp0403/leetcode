using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0301_0350
{
    internal class _0331
    {
        #region 07/22/2024 LeetCode Approach 1: Iteration
        public bool IsValidSerialization_approach1(string preorder)
        {
            int slot = 1;
            string[] arr = preorder.Split(',');

            for (int i = 0; i < arr.Length; i++)
            {
                slot--;
                if (slot < 0) return false;
                if (arr[i] != "#") slot += 2;
            }
            return slot == 0;
        }
        #endregion

        #region 07/22/2024 LeetCode Approach 2: One pass

        public bool IsValidSerialization_approach2(string preorder)
        {
            if (preorder[preorder.Length - 1] != '#') return false;

            int slot = 1;
            for(int i =0; i < preorder.Length; i++)
            {
                if (preorder[i] == ',')
                {
                    slot--;
                    if(slot<0) return false;
                    if (preorder[i - 1] != '#') slot += 2;
                }
            }

            return (slot -1) == 0;
         
        }
        #endregion
    }
}
