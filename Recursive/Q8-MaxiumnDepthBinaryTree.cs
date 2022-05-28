using leetcode.Problems;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Recursive
{
    class Q8_MaxiumnDepthBinaryTree
    {
        public int MaxDepth(TreeNode root)
        {
            return helper(root);
        }
        public int helper(TreeNode node)
        {
            if (node == null) return 0;
            int left = helper(node.left);
            int right = helper(node.right);
            return Math.Max(left, right) + 1;
        }
    }
}
