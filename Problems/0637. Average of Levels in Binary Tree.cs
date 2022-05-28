using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0637
    {
        public IList<double> AverageOfLevels(TreeNode root)
        {
            IList<double> ans = new List<double>() { };
            if (root == null) return ans;
            Queue<TreeNode> queue = new Queue<TreeNode>() { };
            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                int size = queue.Count;
                double sum = 0;
                int count = size;
                while(size > 0)
                {
                    var node = queue.Dequeue();
                    sum += node.val;
                    if (node.left != null) queue.Enqueue(node.left);
                    if (node.right != null) queue.Enqueue(node.right);
                    size--;
                }
                ans.Add(sum / count);
            }
            return ans;
        }
    }
}
