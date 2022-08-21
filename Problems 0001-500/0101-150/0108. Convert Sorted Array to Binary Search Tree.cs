using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0108
    {
        #region answer
        public TreeNode SortedArrayToBST(int[] nums)
        {
            return helper(0, nums.Length - 1, nums);
        }
        //left mid
        public TreeNode helper(int left,int right,int[] nums)
        {
            if (left > right) return null;
            int p = (left + right) / 2;
            TreeNode root = new TreeNode(nums[p]);
            root.left = helper(left, p - 1, nums);
            root.right = helper(p + 1, right, nums);
            return root;
        }
        #endregion
        #region 12/16/2021
        //**********12/16/2021*************
        public TreeNode SortedArrayToBST_R2(int[] nums)
        {
            return helper_R2(0, nums.Length - 1, nums);
        }
        public TreeNode helper_R2(int left,int right,int[] nums)
        {
            if (left > right) return null;
            if (left == right) return new TreeNode(nums[left]);
            int mid = left + (right - left) / 2;
            TreeNode node = new TreeNode(nums[mid]);
            node.left = helper_R2(left, mid-1, nums);
            node.right = helper_R2(mid + 1, right, nums);
            return node;
        }
        #endregion
        #region 08/16/2022
        public TreeNode SortedArrayToBST_20220816(int[] nums)
        {
            return helper(nums, 0, nums.Length - 1);
        }
        public TreeNode helper(int[] nums, int left, int right)
        {
            if (left > right) return null;
            int mid = left + (right - left) / 2;
            TreeNode node = new TreeNode(nums[mid]);
            node.left = helper(nums, left, mid - 1);
            node.right = helper(nums, mid + 1, right);
            return node;
        }
        #endregion
    }
}
