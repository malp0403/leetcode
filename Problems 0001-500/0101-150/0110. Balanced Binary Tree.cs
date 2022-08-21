using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0110
    {
        #region Recursive
        //*****************Recursive***********************************************
        public bool IsBalanced_v1(TreeNode root)
        {
            if (root == null) return true;
            return Math.Abs(height(root.left) - height(root.right)) <= 1 && IsBalanced_v1(root.right) && IsBalanced_v1(root.left);
        }
        public int height(TreeNode node)
        {
            if (node == null) return -1;
            return 1 + Math.Max(height(node.left), height(node.right));
        }
        #endregion
        #region BottomUP
        //*****************Bottom-Up***********************************************

        public bool IsBalanced_v2(TreeNode root)
        {
            return helper(root).isBalanced;
        }
        public TreeNodeInfo helper(TreeNode n)
        {
            if (n == null) return new TreeNodeInfo(-1, true);
            TreeNodeInfo left = helper(n.left);
            if (!left.isBalanced)
            {
                return new TreeNodeInfo(-1, false);
            }
            TreeNodeInfo right = helper(n.right);
            if (!right.isBalanced)
            {
                return new TreeNodeInfo(-1, false);
            }
            if(Math.Abs(left.val - right.val) < 2)
            {
                return new TreeNodeInfo(1 + Math.Abs(left.val - right.val), true);
            }
            return new TreeNodeInfo(-1, false);
        }
        public class TreeNodeInfo
        {
            public int val;
            public bool isBalanced;
            public TreeNodeInfo(int _val, bool _isBalanced)
            {
                this.val = _val;
                this.isBalanced = _isBalanced;
            }
        }
        #endregion
        #region 12/28/2021
        //---------------------12-28-2021-----------------
        public bool IsBalanced_R2(TreeNode root)
        {
            if (root == null) return true;
            int r = height_R2(root.right);
            int l = height_R2(root.left);
            return Math.Abs(r - l) <= 1 && IsBalanced_R2(root.left) && IsBalanced_R2(root.right);
        }
        public int height_R2(TreeNode node)
        {
            if (node == null) return 0;
            int right = height_R2(node.right);
            int left = height_R2(node.left);
            return Math.Max(right, left) + 1;
        }
        #endregion
        #region answer

        public bool IsBalanced_R3(TreeNode node)
        {
            return Helper_R3(node) == -1;
        }
        public int Helper_R3(TreeNode node)
        {
            if (node == null) return 0;
            int left = Helper_R3(node.left);
            int right = Helper_R3(node.right);
            if (left == -1 || right == -1 || Math.Abs(left - right) > 1) return -1;
            return Math.Max(left, right) + 1;
        }
        #endregion

        #region 08/16/2022
        public bool IsBalanced_20220816(TreeNode root)
        {
            return helper_20220816(root) != -1;
        }
        public int helper_20220816(TreeNode node)
        {
            if (node == null) return 0;
            int left = helper_20220816(node.left);
            int right = helper_20220816(node.right);
            if (left == -1 || right == -1 || Math.Abs(left - right) > 1) return -1;
            return Math.Max(right, left) + 1;
        }
        #endregion


    }

}
