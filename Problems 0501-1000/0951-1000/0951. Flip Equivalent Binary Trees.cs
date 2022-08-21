using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0951
    {
        //********** Recursive ***********
        public bool FlipEquiv(TreeNode root1, TreeNode root2)
        {
            if (root1 == null && root2 == null) return true;
            if (root1 == null || root2 == null || root1.val != root2.val) return false;
            return FlipEquiv(root1.right, root2.right) && FlipEquiv(root1.left, root2.left)
                || (FlipEquiv(root1.right, root2.left) && FlipEquiv(root1.left, root2.right));
        }
        //************DFS******************
        public bool FlipEquiv_R2(TreeNode root1,TreeNode root2)
        {
            List<int?> l1 = new List<int?>() { };
            List<int?> l2 = new List<int?>() { };
            helper(root1, l1);
            helper(root2, l2);
            return Enumerable.SequenceEqual(l1, l2);

        }
        public void helper(TreeNode node, List<int?> list)
        {
            if(node != null)
            {
                list.Add(node.val);
                int l = node.left != null ? node.left.val : -1;
                int r = node.right != null ? node.right.val: -1;

                if (l < r)
                {
                    helper(node.left, list);
                    helper(node.right, list);
                }
                else
                {
                    helper(node.right, list);
                    helper(node.left, list);
                }
                list.Add(null);
            }
        }
    }
}
