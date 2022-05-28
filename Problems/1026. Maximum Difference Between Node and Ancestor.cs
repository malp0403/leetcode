using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _1026
    {
        List<TreeNode> parents = new List<TreeNode>() { };
        int max = 0;
        public int MaxAncestorDiff(TreeNode root)
        {
            travel(root);
            return max;
        }

        public void travel(TreeNode node)
        {
            if(node != null)
            {
                if(parents.Count > 0)
                {
                    foreach (var n in parents)
                    {
                        max = Math.Max(max,Math.Abs(n.val - node.val));
                    }
                }

                parents.Add(node);
                travel(node.left);
                travel(node.right);
                parents.RemoveAt(parents.Count - 1);
            }
        }


        public int MaxAncestorDiff2(TreeNode root)
        {
            if (root == null) return 0;
            return travel2(root, root.val, root.val);
        }
        public int travel2(TreeNode m, int curMax, int curMin)
        {
            if (m == null)
            {
                return curMax - curMin;
            }
            curMax = Math.Max(m.val, curMax);
            curMin = Math.Min(m.val, curMin);
            int left = travel2(m.left, curMax, curMin);
            int right = travel2(m.right, curMax, curMin);
            return Math.Max(left, right);
        }

        //01-04-2021
        public int MaxAncestorDiff_R2(TreeNode root)
        {
            helper(root, Int16.MinValue, Int16.MaxValue);
            return max;
        }
        public void helper(TreeNode node,int curMax, int curMin)
        {
            if(node != null)
            {

                curMax = Math.Max(node.val, curMax);
                curMin = Math.Min(node.val, curMin);
                max = Math.Max(Math.Abs(curMax - curMin), max);
                helper(node.left, curMax, curMin);
                helper(node.right, curMax, curMin);
            }
        }

    }
}
