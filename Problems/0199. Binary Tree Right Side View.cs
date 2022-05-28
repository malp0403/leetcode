using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0199
    {
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
                    if(node.right != null)
                    {
                        if (target == null) target = node.right;
                        q.Enqueue(node.right);
                    }
                    if(node.left != null)
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
        
    }
}
