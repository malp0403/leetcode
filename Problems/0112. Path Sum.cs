using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0112
    {
        public bool HasPathSum(TreeNode root, int targetSum)
        {
            if (root == null) return false;
            if (root.val == targetSum) return false;
            return helper(root, 0, targetSum);

        }
        public bool helper(TreeNode n,int sum, int target)
        {
            if(n != null)
            {
                sum += n.val;
                if(n.left == null && n.right == null)
                {
                    return sum == target;
                }
                return helper(n.right, sum, target) || helper(n.left, sum, target);

            }
            return false;

        }

        public bool HasPathSum_V2(TreeNode root, int targetSum)
        {
            if (root == null) return false;
            return helper_V2(root, targetSum, 0);
        }

        public bool helper_V2(TreeNode root, int targetSum,int sum)
        {
            if(root != null)
            {
                sum += root.val;
                if(root.left == null && root.right == null)
                {
                    if (sum == targetSum) {
                        return true;
                    }
                }
              return helper_V2(root.left, targetSum, sum) || helper_V2(root.right, targetSum, sum);
            }
            return false;
        }
    }
}
