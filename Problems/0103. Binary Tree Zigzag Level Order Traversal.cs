using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0103
    {
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            if (root == null) return new List<IList<int>>() { };
            Queue<TreeNode> q = new Queue<TreeNode>() { };

            q.Enqueue(root);
            int count = 1;
            IList<IList<int>> answer = new List<IList<int>>() { };
            bool fromLeft = true;
            while (q.Count != 0)
            {
                count = q.Count;
                List<int> element = new List<int>() { };
                while (count > 0)
                {
                    var n = q.Dequeue();
                    element.Add(n.val);
                    if (n.left != null)
                    {
                        q.Enqueue(n.left);
                    }
                    if (n.right != null)
                    {
                        q.Enqueue(n.right);
                    }

                    count--;
                }
                if (!fromLeft)
                {
                    element.Reverse();
                }
                fromLeft = !fromLeft;
                answer.Add(element);
            }
            return answer;
        }
    }
}
