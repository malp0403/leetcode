using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems._0101_150
{
    class _0105
    {
        #region Solution
        Dictionary<int, int> dic;
        int preIndex = 0;
        public TreeNode BuildTree_(int[] preorder, int[] inorder)
        {
            dic = new Dictionary<int, int>() { };
            for (int i = 0; i < inorder.Length; i++)
            {
                dic.Add(inorder[i], i);
            }
            return helper(preorder, 0, inorder.Length - 1);
        }
        public TreeNode helper(int[] preorder, int left, int right)
        {
            if (left > right) return null;
            int indx = dic[preorder[preIndex]];
            TreeNode head = new TreeNode(preorder[preIndex++]);
            head.left = helper(preorder, left, indx - 1);
            head.right = helper(preorder, indx + 1, right);
            return head;
        }
        #endregion

        #region 08/10/2023
        int index_20230810;
        public TreeNode BuildTree_20230810(int[] preorder, int[] inorder)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>() { };
            for(int i =0; i < inorder.Length; i++)
            {
                dic.Add(inorder[i], i);
            }
            return helper_20230810(preorder, 0, preorder.Length - 1, dic);
        }
        public TreeNode helper_20230810(int[] preorder,int left,int right,Dictionary<int,int> dic)
        {
            if (left > right) return null;

            int indx = dic[preorder[index_20230810]];
            TreeNode head = new TreeNode(preorder[index_20230810++]);

            head.left = helper_20230810(preorder, left, indx - 1,dic);
            head.right = helper_20230810(preorder, indx + 1, right,dic);
            return head;

            
        }
        #endregion

        #region 03/20/2024
        int index_2024_03_20 = 0;
        public TreeNode BuildTree_2024_03_20(int[] preorder, int[] inorder)
        {
            Dictionary<int,int> dic = new Dictionary<int, int> { };
            for(int i =0;i < inorder.Length; i++)
            {
                dic.Add(inorder[i], i);
            }

            return helper_2024_03_20(preorder, 0, preorder.Length - 1, dic);

        }
        public TreeNode helper_2024_03_20(int[] preorder,int left,int right,Dictionary<int,int> dic)
        {
            if (left > right) return null;

            int val = preorder[index_2024_03_20];
            TreeNode head = new TreeNode(val);
            index_2024_03_20++;
            head.left = helper_2024_03_20(preorder, left, dic[val] - 1, dic);
            head.right = helper_2024_03_20(preorder, dic[val] + 1, right, dic);

            return head;
        }
        #endregion

    }
}
