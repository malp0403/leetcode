using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0865
    {
        //********* new class*************************
        public TreeNode SubtreeWithAllDeepest(TreeNode root)
        {
            return helper(root).lca;
        }
        public MyTreeNode helper(TreeNode node)
        {
            if (node == null) return new MyTreeNode(0, null);
            MyTreeNode left = helper(node.left);
            MyTreeNode right = helper(node.right);

            TreeNode lca = left.height == right.height ? node : (left.height < right.height ? right.lca : left.lca);
            return new MyTreeNode(Math.Max(left.height, right.height) + 1, lca);
        }

        public class MyTreeNode
        {
            public int height;
            public TreeNode lca;
            public MyTreeNode(int height,TreeNode lca)
            {
                this.height = height;
                this.lca = lca;
            }
        }
        //**********************************
    }
}
