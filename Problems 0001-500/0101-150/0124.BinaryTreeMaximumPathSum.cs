using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems._0101_150
{
    class _0124
    {
        #region Solution1
        int max = int.MinValue;
        public int MaxPathSum(TreeNode root)
        {

            helper(root);
            return max;
        }
        public int helper(TreeNode node)
        {
            if (node == null) return 0;
            int left = helper(node.left);
            int right = helper(node.right);

            int sum = (left + right + node.val);
            max = Math.Max(sum, max);
            int side = Math.Max(left, right) + node.val;

            int res = Math.Max(side, node.val);
            max = Math.Max(max, res);
            return res;

        }
        #endregion
        #region Solution2
        public int helper_v2(TreeNode node)
        {
            if (node == null) return 0;
            int left = Math.Max(helper(node.left), 0);
            int right = Math.Max(helper(node.right), 0);
            int sum = left + right + node.val;
            max = Math.Max(sum, max);

            return Math.Max(left, right) + node.val;
        }
        #endregion

    }
}
