using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _1382
    {
        List<int> inorder;
        public TreeNode BalanceBST(TreeNode root)
        {
            inorder = new List<int>() { };
            if (root == null) return null;
            dfs(root);

            return helper(0, inorder.Count-1,inorder);
                
        }
        public void dfs(TreeNode node)
        {
            if(node != null)
            {
                dfs(node.left);
                inorder.Add(node.val);
                dfs(node.right);
            }
        }
        public TreeNode helper(int lower, int upper,List<int> inorder)
        {
            if (lower >= upper) return null;
            int mid = lower + (upper - lower) / 2;
            TreeNode root = new TreeNode(inorder[mid]);
            root.left = helper(lower, mid-1,inorder);
            root.right = helper(mid + 1, upper, inorder);
            return root;
        }
    }
}
