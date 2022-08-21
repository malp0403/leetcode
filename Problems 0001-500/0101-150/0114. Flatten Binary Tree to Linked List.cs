using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0114
    {
        #region answer
        public void Flatten(TreeNode root)
        {
            travel(root);
        }

        public TreeNode travel(TreeNode n)
        {
            if (n == null) return null;
            if (n.right == null && n.left == null) return n;

            TreeNode left = travel(n.left);
            TreeNode right = travel(n.right);

            if(left != null)
            {
                left.right = n.right;
                n.right = left;
                n.left = null;
            }

            return right == null ? left : right;
        }
        #endregion
        #region  01/16/2022
        // 01-16-2022--------------------
        public void Flatten_R2(TreeNode root)
        {
            helper(root);
        }
        public TreeNode helper(TreeNode node)
        {
            if (node == null) return null;
            if (node.right == null && node.left == null) return node;
            TreeNode lefttail = helper(node.left);
            TreeNode righttail = helper(node.right);
            if(lefttail != null)
            {
                lefttail.right = node.right;
                node.right = node.left;
                node.left = null;
            }
            return righttail == null ? lefttail : righttail;
        }
        #endregion
        #region 08/16/2022
        public void Flatten_20220816(TreeNode root)
        {
            helper_20220816(root);
        }
        public TreeNode helper_20220816(TreeNode node)
        {
            if (node == null) return null;
            
            
            TreeNode right = node.right;
            TreeNode left = node.left;
            if(left !=null)
            {
           
                left = helper_20220816(left);
                node.left = null;
                node.right = left;
                TreeNode end = left;
                while(end != null && end.right !=null)
                {
                    end = end.right;
                }
                end.right = helper_20220816( right);
                
            }
            else
            {
                node.right = helper_20220816(right);
            }
            return node;
        }
        public TreeNode helper_20220816v2(TreeNode node)
        {
            if (node == null) return null;
            if (node.left == null && node.right == null) return node;
            TreeNode lefttail = helper_20220816v2(node.left);
            TreeNode righttail = helper_20220816v2(node.right);
            if(lefttail != null)
            {
                lefttail.right = righttail;
                node.right = node.left;
                node.left = null;
            }

            return righttail == null ? lefttail : righttail;
        }
        public void Flatten_20220816v3(TreeNode root)
        {
            if (root == null) return;
            TreeNode node = root;
            while(node != null)
            {
                if(node.left != null)
                {
                    TreeNode rightMost = node.left;
                    while(rightMost.right != null)
                    {
                        rightMost = rightMost.right;
                    }
                    rightMost.right = node.right;
                    node.right = node.left;
                    node.left = null;
                }
                node = node.right;
            }
        }
        #endregion
    }
}
