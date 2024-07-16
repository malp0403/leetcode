using leetcode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0251_0300
{
    internal class _0285
    {
        #region 07/15/2024
        public TreeNode InorderSuccessor(TreeNode root, TreeNode p)
        {
            TreeNode result = null;
            while (root != null)
            {
                if (root.val > p.val)
                {
                    result = root;
                    root = root.left;
                }
                else
                {
                    root = root.right;
                }
            }

            return result;
        }
        #endregion

    }
}
