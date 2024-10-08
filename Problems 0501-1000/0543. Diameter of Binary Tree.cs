using leetcode.Problems;
using leetcode.Recursive;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.AccessControl;
using System.Text;

#region TestData

//var obj = new _0543() { };
//TreeNode n1 = new TreeNode(1);
//TreeNode n2 = new TreeNode(2);
//TreeNode n3 = new TreeNode(3);
//TreeNode n4 = new TreeNode(4);
//TreeNode n5 = new TreeNode(5);
//n1.left = n2; n1.right = n3;
//n2.left = n4; n2.right = n5;

//obj.DiameterOfBinaryTree_20230911(n1);

#endregion

namespace leetcode.Problems
{
    class _0543
    {
        #region Solution
        int max = 0;
        public int DiameterOfBinaryTree(TreeNode root)
        {
            travel(root);
            return max;
        }
        public int travel(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            int left = travel(root.left);
            int right = travel(root.right);
            max = Math.Max(max, left + right);

            return Math.Max(left, right) + 1;

        }
        #endregion

        #region 12/24/2021
        //-------------12-24-2021-------------
        public int DiameterOfBinaryTree_R2(TreeNode root)
        {
            helper(root);
            return max;
        }

        public int helper(TreeNode node)
        {
            if (node != null)
            {
                int left = helper(node.left);
                int right = helper(node.right);
                max = Math.Max(left + right, max);
                return Math.Max(left, right) + 1;
            }
            return 0;
        }
        #endregion

        #region 09/11/2023

        int max_20230911 = 1;
        public int DiameterOfBinaryTree_20230911(TreeNode root)
        {

            travel_20230911(root);

            return max_20230911;
        }
        public int travel_20230911(TreeNode node)
        {
            if (node == null) return 0;
            int left = travel_20230911(node.left);
            int right = travel_20230911(node.right);
            max_20230911 = Math.Max(left + right, max_20230911);
            int temp = Math.Max(left, right) + 1;


            return temp;

        }
        #endregion

        #region 10/06/2024
        int max_2024_10_06 = 0;
        public int DiameterOfBinaryTree_2024_10_06(TreeNode root)
        {

            dfs_2024_10_06(root);
            return max_2024_10_06-1;
        }

        public int dfs_2024_10_06(TreeNode node)
        {
            if(node == null) return 0;

            int left = dfs_2024_10_06(node.left);
            int right = dfs_2024_10_06(node.right);

            max_2024_10_06 = Math.Max(left+right+1,max_2024_10_06);

            return Math.Max(left, right) + 1;


        }

        #endregion











    }
}
