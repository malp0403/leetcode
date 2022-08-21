using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0112
    {
        #region answer
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
        #endregion
        #region Review2

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
        #endregion

        #region 08/16/2022
        bool Found_20220816 = false;
        public bool HasPathSum_20220816(TreeNode root, int targetSum)
        {
            if (root == null) return false;
            return helper_20220816(root, 0, targetSum);
        }
        public bool helper_20220816(TreeNode node,int sum,int targetsum)
        {
            if (Found_20220816) return true;
            if (node == null) return false;
            int cur = sum + node.val;
            if(cur == targetsum && node.right == null && node.left == null)
            {
                Found_20220816 = true;
                return true;
            }
            return helper_20220816(node.right, cur, targetsum) 
                || helper_20220816(node.left, cur, targetsum);

        }

        
        #endregion
    }
}
