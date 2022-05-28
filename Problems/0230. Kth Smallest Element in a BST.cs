using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0230
    {
        //***********inorder**************
        List<int> list = new List<int>() { };
        public int KthSmallest(TreeNode root, int k)
        {
            inorder(root);
            return list[k - 1];
        }
        public void inorder(TreeNode node)
        {
            if(node != null)
            {
                inorder(node.left);
                list.Add(node.val);
                inorder(node.right);
            }
        }

        //*********iterative************
        public int KthSmallest_R2(TreeNode root,int k)
        {
            Stack<TreeNode> stack = new Stack<TreeNode>() { };
            while (true)
            {
                if(root != null)
                {
                    stack.Push(root);
                    root = root.left;
                }
                root = stack.Pop();
                if (--k == 0) return root.val;
                root = root.right;
            }
        }
    }
}
