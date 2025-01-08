using leetcode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0401_0450
{
    internal class _0404
    {
        #region 09/04/2024
        public int SumOfLeftLeaves(TreeNode root)
        {
            int sum = 0;

            if (root == null) return 0;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                TreeNode node = queue.Dequeue();

                if(node.left != null)
                {
                    if(node.left.left ==null && node.left.right == null)
                    {
                        sum += node.left.val;
                    }
                    queue.Enqueue(node.left);
                }
                if(node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }

            return sum;
        }

        #endregion
    }
}
