using leetcode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Quic;
using System.Text;

#region Test Data

//TreeNode n1 = new TreeNode(1);
//TreeNode n2 = new TreeNode(2);
//TreeNode n3 = new TreeNode(2);
//TreeNode n4 = new TreeNode(2);
//TreeNode n5 = new TreeNode(2);
//n1.left = n2; n1.right = n3;
//n2.left = n4; n3.left = n5;

//var obj = new _0101();
//var res = obj.IsSymmetric_20230810(n1);

#endregion

namespace leetcode.Problems
{
    class _0101
    {

        #region LeetCode Approach 1: Recursive
        public bool IsSymmetric_approach1(TreeNode root)
        {
            if (root == null) return true;
            return helper_approach1(root.left, root.right);
        }

        public bool helper_approach1(TreeNode node1, TreeNode node2)
        {
            if (node1 == null && node2 == null) return true;
            if (node1 == null || node2 == null || node1.val != node2.val) return false;

            return helper_approach1(node1.right, node2.left) && helper_approach1(node1.left, node2.right);
        }
        #endregion

        #region LeetCode Approach 2: Iterative
        public bool IsSymmetric_approach2(TreeNode root)
        {
            if (root == null) return true;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            queue.Enqueue(root);
            while(queue.Count > 0)
            {
                TreeNode n1= queue.Dequeue();
                TreeNode n2= queue.Dequeue();
                if (n1 == null && n2 == null) continue;
                if (n1 == null || n2 == null || n1.val != n2.val) return false;
                queue.Enqueue(n1.left);
                queue.Enqueue(n2.right);
                queue.Enqueue(n1.right);
                queue.Enqueue(n2.left);
            }

            return true;
        }
        #endregion

        #region answer
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
        #endregion

        #region 12/26/2021
        //--------12-26-2021---------------
        public bool IsSymmetric_R2_Iterative(TreeNode root)
        {
            if (root == null) return true;
            Stack<TreeNode> stack = new Stack<TreeNode>() { };
            if (!helper2(root.right, root.left)) return false;
            if (root.left != null)
            {
                stack.Push(root.left);
                stack.Push(root.right);
                while (stack.Count != 0)
                {
                    TreeNode n1 = stack.Pop();
                    TreeNode n2 = stack.Pop();
                    if (!helper2(n1, n2)) return false;
                    if (n1 != null)
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
        public bool helper2(TreeNode t1, TreeNode t2)
        {
            if (t1 == null && t2 == null) return true;
            if (t1 == null || t2 == null) return false;
            return t1.val == t2.val;

        }
        #endregion

        #region 12/26/2021
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
        #endregion

        #region 08/12/2022
        // two solutions: 1 iterative, 2. recursive
        public bool IsSymmetric_20220812(TreeNode root)
        {
            return helper_20220812(root, root);
        }
        public bool helper_20220812(TreeNode left, TreeNode right)
        {
            if (left == null && right == null) return true;
            if (left == null || right == null) return false;
            return left.val == right.val && isMirror(left.left, right.right)
                && isMirror(left.right, right.left);
        }
        #endregion

        #region 08/10/2023   recursive:left == right, right == left
        public bool IsSymmetric_20230810(TreeNode root)
        {
            if (root == null) return true;

            return helper_20230810(root.left, root.right);
        }
        public bool helper_20230810(TreeNode? n1, TreeNode? n2)
        {
            if (n1 == null && n2 == null) return true;
            if (n1 == null || n2 == null) return false;

            return n1.val == n2.val && helper_20230810(n1.left, n2.right) && helper_20230810(n1.right, n2.left);
        }
        #endregion

        #region 08/10/2023 Iterative one queen
        public bool IsSymmetric_20230810_iterative(TreeNode root)
        {
            Queue<TreeNode> q1 = new Queue<TreeNode>();
            q1.Enqueue(root);
            q1.Enqueue(root);

            while (q1.Count != 0)
            {

                TreeNode n1 = q1.Dequeue();
                TreeNode n2 = q1.Dequeue();
                if (n1 == null && n2 == null) continue;
                if (n1 == null || n2 == null) return false;
                if (n1.val != n2.val) return false;

                q1.Enqueue(n1.left);
                q1.Enqueue(n2.right);
                q1.Enqueue(n1.right);
                q1.Enqueue(n2.left);


            }
            return true;
        }
        #endregion

        #region 03/18/2024
        public bool IsSymmetric_2024_03_18(TreeNode root)
        {
            if (root == null) return true;
            return helper_2024_03_18(root.left, root.right);
        }

        public bool helper_2024_03_18(TreeNode node1, TreeNode node2)
        {
            if (node1 == null && node2 == null) return true;
            if (node1 == null || node2 == null || node1.val != node2.val) return false;

            return helper_2024_03_18(node1.right, node2.left) && helper_2024_03_18(node1.left, node2.right);
        }
        #endregion
    }
}
