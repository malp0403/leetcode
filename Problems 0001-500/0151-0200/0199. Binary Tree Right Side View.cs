using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0199
    {
        #region solution
        public IList<int> RightSideView(TreeNode root)
        {
            IList<int> ans = new List<int>() { };
            if (root == null) return ans;
            Queue<TreeNode> q = new Queue<TreeNode>() { };
            q.Enqueue(root);
            ans.Add(root.val);
            while (q.Count != 0)
            {
                int size = q.Count;
                TreeNode target = null;
                while (size > 0)
                {
                    TreeNode node = q.Dequeue();
                    if (node.right != null)
                    {
                        if (target == null) target = node.right;
                        q.Enqueue(node.right);
                    }
                    if (node.left != null)
                    {
                        if (target == null) target = node.left;
                        q.Enqueue(node.left);
                    }
                    size--;
                }
                if (target != null)
                {
                    ans.Add(target.val);
                }

            }
            return ans;
        }
        #endregion

        #region 06/11/2024
        public IList<int> RightSideView_2024_06_11(TreeNode root)
        {
            List<int> list = new List<int>();
            Queue<TreeNode> q = new Queue<TreeNode>();
            if(root == null) return list;

            q.Enqueue(root);
            int level = 1;
            while(q.Count != 0)
            {
                int count = q.Count;
                while(count > 0)
                {
                    TreeNode temp = q.Dequeue();
                    if(list.Count < level)
                    {
                        list.Add(temp.val);
                    }
                    if(temp.right != null)
                    {
                        q.Enqueue(temp.right);
                    }
                    if(temp.left != null)
                    {
                        q.Enqueue(temp.left);
                    }

                    count--;
                }
                level++;

            }
            return list;
        }
        #endregion
    }
}
