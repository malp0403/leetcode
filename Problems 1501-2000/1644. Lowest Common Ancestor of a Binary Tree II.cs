using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _1644
    {
        Dictionary<TreeNode, TreeNode> dic = new Dictionary<TreeNode, TreeNode>() { };
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            if (root == null) return null;
            dfs(root);
            if (!dic.ContainsKey(p) || !dic.ContainsKey(q)) return null;
            HashSet<TreeNode> set = new HashSet<TreeNode>() { };
            set.Add(root);
            while (q != null && q != root)
            {
                set.Add(q);
                q = dic[q];
            }

            while (!set.Contains(p))
            {
                p = dic[p];
            }
            return p;
        }
        public void dfs(TreeNode node)
        {
            if(node != null)
            {
                if(node.left != null)
                {
                    dic.Add(node.left, node);
                    dfs(node.left);
                }
                if(node.right != null)
                {
                    dic.Add(node.right, node);
                    dfs(node.right);
                }
            }
        }
    }
}
