using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leetcode.Problems
{
    class _0103
    {
        #region LeetCode Approach 1: BFS (Breadth-First Search)

        #endregion

        #region LeetCode Approach 2: DFS (Depth-First Search)

        #endregion

        #region answer
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
        #endregion

        #region 08/12/2022
        public IList<IList<int>> ZigzagLevelOrder_20220812(TreeNode root)
        {
            bool reverse = false;
            IList<IList<int>> result = new List<IList<int>>() { };
            if (root == null) return result;

            Queue<TreeNode> queue = new Queue<TreeNode>() { };
            queue.Enqueue(root);
            while(queue.Count != 0)
            {
                int count = queue.Count;
                IList<int> list = new List<int>() { };
                while(count > 0)
                {
                    TreeNode cur = queue.Dequeue();
                    list.Add(cur.val);

                    if (cur.left != null)
                    {
                        queue.Enqueue(cur.left);
                    }
                    if (cur.right != null)
                    {
                        queue.Enqueue(cur.right);
                    }
                    count--;
                }
                if (reverse)
                {
                    result.Add(Enumerable.Reverse(list).ToList());
                }
                else
                {
                    result.Add(list);
                }
                reverse = !reverse;
            }
            return result;
        }
        #endregion

        #region 03/18/2024
        public IList<IList<int>> ZigzagLevelOrder_2024_03_18(TreeNode root)
        {
            IList<IList<int>> answer = new List<IList<int>>() { };

            Queue<TreeNode> queue = new Queue<TreeNode>();
            if (root == null) return answer;
            bool isBackwards = false;
            queue.Enqueue(root);

            while(queue.Count != 0) { 
                int count= queue.Count;
                List<int> list = new List<int>();

                while (count > 0)
                {
                    TreeNode node = queue.Dequeue();
                    list.Add(node.val);
                    if(node.left != null)
                    {
                        queue.Enqueue(node.left);
                    }
                    if(node.right != null)
                    {
                        queue.Enqueue(node.right);
                    }


                    count--;
                }
                if (isBackwards)
                {
                    list.Reverse();
                }
                answer.Add(list);
                isBackwards = !isBackwards;
            }
            return answer;
        }
        #endregion
    }
}
