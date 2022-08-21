using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0543
    {
        int max = 0;
        public int DiameterOfBinaryTree(TreeNode root)
        {
            travel(root);
            return max;
        }

        public int travel(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            int left = travel(root.left);
            int right = travel(root.right);
            max = Math.Max(max, left + right);

            return Math.Max(left, right) + 1;

        }

        //-------------12-24-2021-------------
        public int DiameterOfBinaryTree_R2(TreeNode root)
        {
            helper(root);
            return max;
        }

        public int helper(TreeNode node)
        {
            if(node != null)
            {
                int left = helper(node.left);
                int right = helper(node.right);
                max = Math.Max(left + right, max);
                return Math.Max(left, right) + 1;
            }
            return 0;
        }
    }
}
