using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0270
    {
        #region 07/11/2024
        int min = int.MaxValue;
        public int ClosestValue(TreeNode root, double target)
        {
            travel(root, target);
            return min;
        }

        public void travel(TreeNode node, double target)
        {
            if (node != null)
            {
                min = Math.Abs(node.val - target) < Math.Abs(min - target) ? node.val : min;
                travel(node.left, target);
                travel(node.right, target);
            }
        }
        //---- usage of BST--
        public int ClosestValue_V2(TreeNode root, double target)
        {
            if (root == null) return 0;
            int min = root.val;
            while (root != null)
            {
                if (Math.Abs(root.val - target) < Math.Abs(min - target)) min = root.val;
                root = target < root.val ? root.left : root.right;
            }
            helper(root, target);
            return min;
        }
        #endregion

        #region 12/24/2021
        //---------12-24-2021-----------------------
        public int ClosestValue_R2(TreeNode root, double target)
        {
            helper(root, target);
            return min;
        }
        public void helper(TreeNode node, double target)
        {
            if (node != null)
            {
                if (Math.Abs(node.val - target) < Math.Abs(min - target)) min = node.val;
                helper(node.left, target);
                helper(node.right, target);
            }
        }
        #endregion

        #region 07/11/2024
        public int ClosestValue_2024_07_11(TreeNode root, double target)
        {
            double diff = int.MaxValue;
            int answer = -1;

            while (root != null)
            {
                if (Math.Abs(target - root.val) < diff)
                {

                    answer = root.val;
                    diff = Math.Abs(target - root.val);
                }
                else if (Math.Abs(target - root.val) == diff)
                {
                    answer = Math.Min(answer, root.val);
                }


                if (root.val == target) return root.val;
                if (root.val < target)
                {

                    root = root.right;
                }
                else
                {
                    root = root.left;
                }

            }

            return answer;
        }

        #endregion

    }
}
