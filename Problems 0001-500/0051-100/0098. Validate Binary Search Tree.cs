using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0098
    {
        #region answer;
        Stack<TreeNode> stack;
        bool isFound = false;
        public bool IsValidBST_v1(TreeNode root)
        {
            return topDownDFS(root,Int32.MinValue, Int32.MaxValue);
        }
        public bool topDownDFS(TreeNode root,int low, int high)
        {
            if(root != null)
            {
                
                if ((root.val <= low) || (root.val >= high)) return false;
                return topDownDFS(root.right, root.val, high) && topDownDFS(root.left, low, root.val);
            }
            return true;
        }
        #endregion

        #region 08/12/2022
        public bool IsValidBST_20220812(TreeNode root)
        {
            return isValid_20220812(root, null, null);
        }
        public bool isValid_20220812(TreeNode node,int? min,int? max)
        {
            if (node == null) return true;
            if (min != null && node.val <= min) return false;
            if (max != null && node.val >= max) return false;
            return isValid_20220812(node.left, min, node.val)
                && isValid_20220812(node.right, node.val, max);
        }
        #endregion
    }
}
