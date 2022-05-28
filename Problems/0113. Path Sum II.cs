using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0113
    {
        IList<IList<int>> result = new List<IList<int>>() { };
        public IList<IList<int>> PathSum(TreeNode root, int targetSum)
        {
            List<TreeNode> path = new List<TreeNode>() { };
            travel(root, 0, targetSum, path);


            return result;
        }
        public void travel(TreeNode n, int sum,int target,List<TreeNode> l)
        {
            if( n != null)
            {
                l.Add(n);
                sum += n.val;
                //check if it is the leaf;
                if(n.right == null && n.left == null)
                {
                    if(sum == target)
                    {
                        var copy = l.Select(x=>x.val).ToList();
                        result.Add(copy);
                    }
                }
                travel(n.right, sum, target, l);
                travel(n.left, sum, target, l);

                l.RemoveAt(l.Count - 1);
                sum -= n.val;
            }
        }
    }
}
