using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0111
    {
        #region BST
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
        #endregion
        #region Recursive
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
        #endregion

        #region 08/16/2022 solution1
        public int MinDepth_20220816v1(TreeNode root)
        {
            if (root == null) return 0;
            Queue<TreeNode> que = new Queue<TreeNode>() { };
            que.Enqueue(root);
            int level = 0;
            bool isReach = false;
            while(que.Count != 0)
            {
                int count = que.Count;
                level++;
                while(count != 0)
                {
                    TreeNode temp = que.Dequeue();
                    if (temp.right == null && temp.left == null)
                    {
                        isReach = true;
                        break;
                    }
                    if(temp.right != null)
                    {
                        que.Enqueue(temp.right);
                    }
                    if(temp.left != null)
                    {
                        que.Enqueue(temp.left);
                    }
                    count--;
                }
                if (isReach) break;
            }
            return level;
        }

        public int MinDepth_20220816v2(TreeNode root)
        {
            if (root == null) return 0;
            if (root.left == null && root.right == null) return 1;
            int min = Int16.MaxValue;
            if(root.left != null)
            {
                min = Math.Min(MinDepth_20220816v2(root.left), min);
            }
            if (root.right != null)
            {
                min = Math.Min(MinDepth_20220816v2(root.right), min);
            }
            return min + 1;
        }

        #endregion
    }
}
