using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0101
    {

        public bool IsSymmetric(TreeNode root)
        {
            Queue<TreeNode> queue = new Queue<TreeNode>() { };
            if (root == null) return true;
            if (root.left != null) queue.Enqueue(root.left);
            if (root.right != null) queue.Enqueue(root.right);

            while (queue.Count != 0)
            {
                int size = queue.Count;
                if (size % 2 != 0) return false;
                Stack<TreeNode> reference = new Stack<TreeNode>() { };
                int total = size;
                while (size > 0)
                {
                    var n = queue.Dequeue();
                    if (size > total / 2) reference.Push(n);
                    else
                    {
                        //compare;
                        var compared = reference.Pop();
                        if (!isSame(n, compared) || !isSame(n.left, compared.right) || !isSame(n.right, compared.left))
                            return false;
                    }
                    if (n.left != null) queue.Enqueue(n.left);
                    if (n.right != null) queue.Enqueue(n.right);
                    size--;
                }
            }
            return true;
        }
        public bool isSame(TreeNode? n, TreeNode? n2)
        {
            if (n == null && n2 == null) return true;
            if (n == null || n2 == null) return false;
            if (n.val == n2.val) return true;
            return false;
        }
        // iterative
        public bool IsSymmetric_v2(TreeNode root)
        {
            if (root == null) return true;
            Queue<TreeNode?> q = new Queue<TreeNode?>() { };
            q.Enqueue(root.left);
            q.Enqueue(root.right);
            while (q.Count != 0)
            {
                TreeNode? n1 = q.Dequeue();
                TreeNode? n2 = q.Dequeue();
                if (n1 == null && n2 == null) continue;
                if (n1 == null || n2 == null) return false;
                if (n1.val != n2.val) return false;
                q.Enqueue(n1.left);
                q.Enqueue(n2.right);
                q.Enqueue(n1.right);
                q.Enqueue(n2.left);
            }
            return true;
        }
        //recursive
        public bool IsSymmetric_v3(TreeNode root)
        {
            return isMirror(root, root);
        }
        public bool isMirror(TreeNode t1, TreeNode t2)
        {
            if (t1 == null && t2 == null) return true;
            if (t1 == null || t2 == null) return false;
            return t1.val == t2.val && isMirror(t1.left, t2.right) && isMirror(t1.right, t2.left);
        }

        //--------12-26-2021---------------
        public bool IsSymmetric_R2_Iterative(TreeNode root)
        {
            if (root == null) return true;
            Stack<TreeNode> stack = new Stack<TreeNode>() { };
            if (!helper2(root.right, root.left)) return false;
            if(root.left != null)
            {
                stack.Push(root.left);
                stack.Push(root.right);
                while (stack.Count != 0)
                {
                    TreeNode n1 = stack.Pop();
                    TreeNode n2 = stack.Pop();
                    if (!helper2(n1, n2)) return false;
                    if(n1 != null)
                    {
                        stack.Push(n1.left);
                        stack.Push(n2.right);
                        stack.Push(n1.right);
                        stack.Push(n2.left);
                    }
                }
            }
            return true;
        }
        public bool helper2(TreeNode t1,TreeNode t2)
        {
            if (t1 == null && t2 == null) return true;
            if (t1 == null || t2 == null) return false;
            return t1.val == t2.val;

        }

        //--------12-26-2021---------------
        public bool IsSymmetric_R2_Recursive(TreeNode root)
        {
            if (root == null) return true;
            return helper(root.right, root.left);
        }
        public bool helper(TreeNode t1, TreeNode t2)
        {
            if (t1 == null && t2 == null) return true;
            if (t1 == null || t2 == null) return false;
            return t1.val == t2.val && helper(t1.left, t2.right) && helper(t1.right, t2.left);
        }
    }
}
