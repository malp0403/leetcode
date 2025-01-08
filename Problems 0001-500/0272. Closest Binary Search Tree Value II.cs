using leetcode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0251_0300
{
    internal class _0272
    {
        #region 07/11/2024 PriorityQueue
        public IList<int> ClosestKValues_2024_07_11(TreeNode root, double target, int k)
        {
            PriorityQueue<int,double> priorityQueue = new PriorityQueue<int,double>();

            Queue<TreeNode> queue = new Queue<TreeNode>();
            if(root == null) return new List<int>(){ };

            queue.Enqueue(root);
            while(queue.Count > 0)
            {

                TreeNode node = queue.Dequeue();

                double diff = -Math.Abs(node.val - target);
                priorityQueue.Enqueue(node.val, diff);
                if (priorityQueue.Count > k)
                {
                    priorityQueue.Dequeue();
                }
                if(node.left != null)
                {
                    queue.Enqueue(node.left);
                }
                if(node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }

            List<int> answer = new List<int>();
            while (priorityQueue.Count != 0)
            {
                answer.Add(priorityQueue.Dequeue());
            }

            return answer;
        }

        #endregion
    }
}
