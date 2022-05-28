using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0572
    {
        public bool IsSubtree(TreeNode root, TreeNode subRoot)
        {
            if (subRoot == null) return true;

            TreeNode start = null;
            Queue<TreeNode> queue = new Queue<TreeNode>() { };
            if (root == null)
            {
                return subRoot == null;
            }
            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                var n = queue.Dequeue();
                if (n.val == subRoot.val)
                {
                    if (isSub(n, subRoot)) return true;
                }
                if (n.left != null) queue.Enqueue(n.left);
                if (n.right != null) queue.Enqueue(n.right);
            }

            if (start == null) return false;

            return true;
        }
        public bool isSub(TreeNode root, TreeNode sub)
        {
            Queue<TreeNode> q1 = new Queue<TreeNode>() { };
            Queue<TreeNode> q2 = new Queue<TreeNode>() { };
            q1.Enqueue(root);
            q2.Enqueue(sub);
            while (q1.Count != 0 || q2.Count != 0)
            {
                var n1 = q1.Dequeue();
                var n2 = q2.Dequeue();
                if (!helper(n1, n2)) return false;
                if (n1 == null) continue;
                q1.Enqueue(n1.left);
                q2.Enqueue(n2.left);
                q1.Enqueue(n1.right);
                q2.Enqueue(n2.right);
            }
            return true;
        }
        public bool helper(TreeNode n1, TreeNode n2)
        {
            if (n1 == null && n2 == null) return true;
            if (n1 == null || n2 == null) return false;
            if (n1.val == n2.val) return true;
            return false;
        }
    }
}
