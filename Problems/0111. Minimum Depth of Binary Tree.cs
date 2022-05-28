using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0111
    {
        //*********************BST*****************
        public int MinDepth(TreeNode root)
        {
            Queue<TreeNode> q = new Queue<TreeNode>() { };
            if (root == null) return 0;
            q.Enqueue(root);
            int count = 0;
            while(q.Count != 0)
            {
                int size = q.Count;
                count++;
                while (size > 0)
                {
                    var n = q.Dequeue();
                    if(n.left == null && n.right == null)
                    {
                        return count;
                    }
                    if (n.left != null) q.Enqueue(n.left);
                    if (n.right != null) q.Enqueue(n.right);
                    size--;
                }
            }
            return 0;
        }

        //**************recursive************
        public int MinDepth_Recursive(TreeNode root)
        {
            if (root == null) return 0;
            if (root.left == null && root.right == null) return 1;
            int min_dep = Int16.MaxValue;
            if(root.left != null)
            {
                min_dep = Math.Min(MinDepth_Recursive(root.left), min_dep);
            }
            if (root.right != null)
            {
                min_dep = Math.Min(MinDepth_Recursive(root.right), min_dep);
            }
            return min_dep + 1;
        }
    }
}
