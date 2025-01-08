using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0897
    {
        
        public TreeNode IncreasingBST(TreeNode root)
        {
            Queue<TreeNode> q = new Queue<TreeNode>() { };
            if (root == null) return null;
            dfs(root, q);
            var ans = new TreeNode(0);
            var temp = ans;
            while (q.Count > 0)
            {
                var n = q.Dequeue();
                n.left = null;
                n.right = null;
                temp.right = n;
                temp = ans.right;
            }
            return ans.right;
        }
        public void dfs(TreeNode node,Queue<TreeNode> q)
        {
            if(node != null)
            {
                dfs(node.left, q);
                q.Enqueue(node);
                dfs(node.right, q);
            }
        }
        //*******************travel and relink*************
        TreeNode cur;
        TreeNode ans;
        public TreeNode IncreasingBST_v2(TreeNode root)
        {
            ans = new TreeNode();
            cur = ans;
            inorder(root, cur);
            return ans.right;
        }
        public void inorder(TreeNode node,TreeNode record)
        {
            if(node != null)
            {
                inorder(node.left,record);
                node.left = null;
                record.right = node;
                record = node;
                inorder(node.right, record);
            }
        }
    }
}
