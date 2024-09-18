using leetcode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_2001_2500._2201_2250
{
    internal class _2236
    {
        #region 09/19/2023
        public bool CheckTree(TreeNode root)
        {
            return root.val == (root.left.val + root.right.val);
        }
        #endregion

        #region 09/23/2023
        public bool CheckTree_20230923(TreeNode root)
        {
            return root.val == (root.left.val + root.right.val);

        }
        #endregion
    }
}
