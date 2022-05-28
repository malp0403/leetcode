using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0114
    {
        public void Flatten(TreeNode root)
        {
            travel(root);
        }

        public TreeNode travel(TreeNode n)
        {
            if (n == null) return null;
            if (n.right == null && n.left == null) return n;

            TreeNode left = travel(n.left);
            TreeNode right = travel(n.right);

            if(left != null)
            {
                left.right = n.right;
                n.right = left;
                n.left = null;
            }

            return right == null ? left : right;
        }
        // 01-16-2022--------------------

        public void Flatten_R2(TreeNode root)
        {
            helper(root);
        }
        public TreeNode helper(TreeNode node)
        {
            if (node == null) return null;
            if (node.right == null && node.left == null) return node;
            TreeNode lefttail = helper(node.left);
            TreeNode righttail = helper(node.right);
            if(lefttail != null)
            {
                lefttail.right = node.right;
                node.right = node.left;
                node.left = null;
            }
            return righttail == null ? lefttail : righttail;
        }
    }
}
