using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems._0101_150
{
    class _0105
    {
        Dictionary<int, int> dic;
        int preIndex = 0;
        public TreeNode BuildTree(int[] preorder,int[] inorder)
        {
            dic = new Dictionary<int, int>() { };
            for(int i=0; i < inorder.Length; i++)
            {
                dic.Add(inorder[i], i);
            }
            return helper(preorder, 0, inorder.Length - 1);
        }
        public TreeNode helper(int[] preorder, int left,int right)
        {
            if (left > right) return null;
            int indx= dic[preorder[preIndex]];
            TreeNode head = new TreeNode(preorder[preIndex++]);
            head.left = helper(preorder, left, indx - 1);
            head.right = helper(preorder, indx + 1, right);
            return head;
        }
    }
}
