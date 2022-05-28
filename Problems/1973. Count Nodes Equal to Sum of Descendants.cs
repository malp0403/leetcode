using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _1973
    {
        int count = 0;
        public int EqualToDescendants(TreeNode root)
        {
            helper(root);
            return count;
        }
        public int helper(TreeNode node)
        {
            if (node == null) return 0;
            int left = helper(node.left);
            int right = helper(node.right);
            if (node.val == left + right) count++;
            return node.val + left + right;
        }
    }
}
