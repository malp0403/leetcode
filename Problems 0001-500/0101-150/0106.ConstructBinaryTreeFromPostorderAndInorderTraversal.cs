using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems._0101_150
{
    class _0016
    {
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
    }
}
