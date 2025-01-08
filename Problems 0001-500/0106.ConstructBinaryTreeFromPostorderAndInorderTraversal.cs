using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems._0101_150
{
    class _0016
    {
        #region LeetCode Approach 1: Recursion
        Dictionary<int, int> dic = new Dictionary<int, int>() { };
        int postIndex = 0;
        public TreeNode BuildTree(int[] inorder, int[] postorder)
        {
            postIndex = postorder.Length - 1;
            for (int i = 0; i < inorder.Length; i++)
            {
                dic.Add(inorder[i], i);
            }
            return helper(postorder, 0, postorder.Length - 1);
        }
        public TreeNode helper(int[] postorder, int left, int right)
        {
            if (left > right) return null;

            TreeNode head = new TreeNode(postorder[postIndex]);
            int indx = dic[postorder[postIndex--]];
            head.right = helper(postorder, indx + 1, right);
            head.left = helper(postorder, left, indx - 1);

            return head;
        }
        #endregion

        #region 03/20/2024

        Dictionary<int, int> dic_2024_03_20;
        int index_2024_03_20;
        public TreeNode BuildTree_2024_03_20(int[] inorder, int[] postorder)
        {
            dic_2024_03_20 = new Dictionary<int, int>();
            index_2024_03_20 = postorder.Length - 1;

            for(int i=0; i <  postorder.Length; i++)
            {
                dic_2024_03_20.Add(inorder[i], i);
            }
            return helper_2024_03_20(postorder,0,postorder.Length-1);
        }
        public TreeNode helper_2024_03_20(int[] postorder,int left, int right)
        {
            if(left > right) return null;

            int val = postorder[index_2024_03_20--];
            TreeNode head = new TreeNode(val);
            head.right = helper_2024_03_20(postorder, dic[val] + 1, right);

            head.left = helper_2024_03_20(postorder, left, dic[val] - 1);
            return head;
        }
        #endregion
    }
}
