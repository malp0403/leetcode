using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems._0101_150
{
    class _0104
    {
        #region LeetCode Approach 1: Recursion
        public int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;
            return Math.Max(MaxDepth(root.left), MaxDepth(root.right))+1;
        }
        #endregion

        #region LeetCode Approach 2: Tail Recursion + BFS

        #endregion

        #region LeetCode Approach 3: Iteration
        public int Maxdepth_3(TreeNode root)
        {
            int level = 0;
            Queue<TreeNode> q = new Queue<TreeNode>();
            if (root == null) return level;
            q.Enqueue(root);
            while (q.Count != 0)
            {

                int count = q.Count;
                while (count != 0)
                {
                    TreeNode node = q.Dequeue();
                    if (node.left != null)
                    {
                        q.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        q.Enqueue(node.right);
                    }
                    count--;
                }


                level++;
            }
            return level;
        }
        #endregion

        #region Solution
        public int Maxdepth_(TreeNode root)
        {
            int level = 0;
            if (root == null) return level;
            Stack<TreeNode> stack = new Stack<TreeNode>() { };
            stack.Push(root);
            while (stack.Count != 0)
            {
                int count = stack.Count;
                level++;
                while (count != 0)
                {
                    TreeNode node = stack.Pop();
                    if (node.left != null)
                    {
                        stack.Push(node.left);
                    }
                    if (node.right != null)
                    {
                        stack.Push(node.right);
                    }
                    count--;
                }
            }
            return level;
        }
        #endregion

        #region 03/18/2024
        public int MaxDepth_2024_03_18(TreeNode root)
        {
            int level = 0;
            Queue<TreeNode> q = new Queue<TreeNode>();
            if(root == null) return level;
            q.Enqueue(root);
            while (q.Count != 0)
            {

                int count = q.Count;
                while(count != 0)
                {
                    TreeNode node = q.Dequeue();
                    if (node.left != null)
                    {
                        q.Enqueue(node.left);
                    }
                    if (node.right != null)
                    {
                        q.Enqueue(node.right);
                    }
                    count--;
                }


                level++;
            }
            return level;
        }
        #endregion
    }
}
