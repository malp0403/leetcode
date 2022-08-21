using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems._0101_150
{
    class _0104
    {
        public int Maxdepth(TreeNode root)
        {
            int level = 0;
            if (root == null) return level;
            Stack<TreeNode> stack = new Stack<TreeNode>() { };
            stack.Push(root);
            while(stack.Count != 0)
            {
                int count = stack.Count;
                level++;
                while(count != 0)
                {
                    TreeNode node = stack.Pop();
                    if(node.left != null)
                    {
                        stack.Push(node.left);
                    }
                    if(node.right != null)
                    {
                        stack.Push(node.right);
                    }
                    count--;
                }
            }
            return level;
        }
    }
}
