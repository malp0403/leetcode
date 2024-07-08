using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0226
    {
        #region Solution
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null) return null;

            var right = InvertTree(root.right);
            var left = InvertTree(root.left);

            root.right = left;
            root.left = right;

            return root;

        }
        //***************************Iterative***************************
        public TreeNode InvertTree_v2(TreeNode root)
        {
            Queue<TreeNode> q = new Queue<TreeNode>() { };
            q.Enqueue(root);
            while (q.Count != 0)
            {
                var a = q.Dequeue();
                var tempLeft = a.left;
                a.left = a.right;
                a.right = tempLeft;
                if (a.left != null) q.Enqueue(a.left);
                if (a.right != null) q.Enqueue(a.right);
            }
            return root;

        }

        /// <summary>
        /// 12/15/2021
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public TreeNode InvertTree_R2(TreeNode root)
        {
            if (root == null) return null;
            var right = InvertTree_R2(root.right);
            var left = InvertTree_R2(root.left);
            root.left = right;
            root.right = left;

            return root;
        }
        public TreeNode InvertTree_Review2_iterative(TreeNode root)
        {

            Queue<TreeNode> queue = new Queue<TreeNode>() { };
            if (root == null) return null;
            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                var node = queue.Dequeue();
                if (node != null)
                {
                    var temp = node.right;
                    node.right = node.left;
                    node.left = temp;
                    queue.Enqueue(node.left);
                    queue.Enqueue(node.right);
                }
            }


            return root;
        }
        #endregion

        #region 07/07/2024
        public TreeNode InvertTree_2024_07_07(TreeNode root)
        {
            if (root == null) return null;

            TreeNode node = root;

            TreeNode left = InvertTree_2024_07_07(node.left);
            TreeNode right = InvertTree_2024_07_07(node.right);
            node.right = left;
            node.left = right;

            return node;
        }
        #endregion

    }
}
