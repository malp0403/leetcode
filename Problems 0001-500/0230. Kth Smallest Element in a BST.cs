using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0230
    {
        #region Inorder
        //***********inorder**************
        List<int> list = new List<int>() { };
        public int KthSmallest(TreeNode root, int k)
        {
            inorder(root);
            return list[k - 1];
        }
        public void inorder(TreeNode node)
        {
            if (node != null)
            {
                inorder(node.left);
                list.Add(node.val);
                inorder(node.right);
            }
        }
        #endregion

        #region Iterative
        //*********iterative************
        public int KthSmallest_R2(TreeNode root, int k)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>() { };
            while (true)
            {
                if (root != null)
                {
                    stack.Push(root);
                    root = root.left;
                }
                root = stack.Pop();
                if (--k == 0) return root.val;
                root = root.right;
            }
        }
        #endregion

        #region 08/16/2023

        public int KthSmallest_20230816(TreeNode root, int k)
        {
            List<int> list = new List<int>() { };
            helper(root, list);
            return list[k - 1];
        }
        public void helper(TreeNode node, List<int> list)
        {
            if(node != null)
            {
                helper(node.left,list);
                list.Add(node.val);
                helper(node.right, list);
            }
        }


        #endregion

        #region 08/16/2023 iterative
        public int KthSmallest_20230816_itera(TreeNode root, int k)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>() { };
            while (true)
            {
                while(root != null)
                {
                    stack.Push(root);
                    root = root.left;
                }
                root = stack.Pop();
                if (--k == 0) return root.val;
                root = root.right;

            }
            return 0;

        }
        #endregion

        #region 07/07/2024
        List<int> list_2024_07_07;
        public int KthSmallest_2024_07_07(TreeNode root, int k) {
            list_2024_07_07 = new List<int>() { };
            helper(root);

            return list_2024_07_07[k - 1];

        }
        public void helper(TreeNode root)
        {
            if (root == null) return;

            helper(root.left);
            list_2024_07_07.Add((int)root.val);
            helper(root.right);
        }

        #endregion

    }
}
