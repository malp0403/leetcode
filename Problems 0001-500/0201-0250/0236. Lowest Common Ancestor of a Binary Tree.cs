using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0236
    {
        bool found = false;
        bool second = false;
        List<Stack<int>> l1 = new List<Stack<int>> { };
        List<int> l2 = new List<int>() { };
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            Dictionary<TreeNode, TreeNode> dic = new Dictionary<TreeNode, TreeNode>() { };
            dic.Add(root, null);
            Stack<TreeNode> s = new Stack<TreeNode>() { };
            s.Push(root);
            while (!dic.ContainsKey(p) || !dic.ContainsKey(q))
            {
                var temp = s.Pop();
                if (temp.right != null)
                {
                    dic.Add(temp.right, temp);
                    s.Push(temp.right);
                }
                if (temp.left != null)
                {
                    dic.Add(temp.left, temp);
                    s.Push(temp.left);
                }
            }
            List<TreeNode> li = new List<TreeNode>() { };
            while(p!= null)
            {
                li.Add(p);
                p = dic[p];
            }
            while(!li.Contains(q))
            {
                q = dic[q];
            }
            return q;

        }

        public List<int> findNode(TreeNode root, TreeNode q, Stack<int> s, List<int> result)
        {
            return null;
        }

        //01-17-2022----------------------------------------------------------------
        TreeNode ans = null;
        public TreeNode LowestCommonAncestor_R2(TreeNode root,TreeNode p , TreeNode q)
        {
            helper(root, p, q);
            return this.ans;
        }
        public bool helper(TreeNode node, TreeNode p , TreeNode q)
        {
            if (node == null) return false;
            int left = helper(node.left, p, q) ? 1 : 0;
            int right = helper(node.right, p, q) ? 1 : 0;
            int mid = node == p || node == q ? 1 : 0;
            if (left + right + mid >= 2)
            {
                this.ans = node;
            }
            return left + right + mid > 0;
        }
    }
}
