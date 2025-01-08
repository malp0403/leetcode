using leetcode.Problems;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0151_0200
{
    internal class _0156
    {
        #region 03/28/2024
        public TreeNode UpsideDownBinaryTree(TreeNode root)
        {
            TreeNode newHead = null;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            while(root != null)
            {
                stack.Push(root);
                root = root.left;
            }
            TreeNode prevRight = null;
            while(stack.Count > 0)
            {
                TreeNode node = stack.Pop();
                if(node.left == null && node.right == null)
                {
                    newHead = node;
                }
                else
                {
                    prevRight.left = node.right;
                    node.right = node;
         
                }
                prevRight = node;

            }
            return newHead;
        }
        #endregion
    }
}
