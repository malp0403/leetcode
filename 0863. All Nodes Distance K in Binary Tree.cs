using leetcode.Problems;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode
{
    class _0863
    {
        Dictionary<TreeNode, TreeNode> dic = new Dictionary<TreeNode, TreeNode>() { };

        public IList<int> DistanceK(TreeNode root, TreeNode target, int k)
        {
            IList<int> ans = new List<int>() { };
            dfs(root);
            Queue<TreeNode> q = new Queue<TreeNode>() { };
            q.Enqueue(target);
            HashSet<int> visited = new HashSet<int>() { };
            int level = 0;
            while (q.Count != 0)
            {
                if (level == k)
                {
                    break;
                }
                int size = q.Count;
                while (size > 0)
                {
                    TreeNode n = q.Dequeue();
                    visited.Add(n.val);
                    if (dic.ContainsKey(n) && !visited.Contains(dic[n].val))
                    {
                        q.Enqueue(dic[n]);
                    }
                    if(n.left !=null && !visited.Contains(n.left.val))
                    {
                        q.Enqueue(n.left);
                    }
                    if(n.right !=null && !visited.Contains(n.right.val))
                    {
                        q.Enqueue(n.right);
                    }
                    size--;
                }
                level++;

            }
            while (q.Count != 0)
            {
                ans.Add(q.Dequeue().val);
            }
            return ans;

        }
        public void dfs(TreeNode node)
        {
            if(node != null)
            {
                if (node.right != null) dic.Add(node.right, node);
                dfs(node.right);
                if (node.left != null) dic.Add(node.left, node);
                dfs(node.left);
            }
        }
    }
}
