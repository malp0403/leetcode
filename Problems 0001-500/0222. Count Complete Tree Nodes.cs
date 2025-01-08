using leetcode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode.Problems_0001_500._0201_0250
{
    internal class _0222
    {
        #region 07/07/2024
        public int CountNodes(TreeNode root)
        {
            if(root == null) return 0;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            int count = 0;
            while(queue.Count > 0)
            {
                TreeNode node = queue.Dequeue();
                count++;
                if(node.left !=null)
                {
                    queue.Enqueue(node.left);
                }
                if(node.right !=null)
                {
                    queue.Enqueue(node.right);
                }

            }
            return count;
        }
        #endregion
    }
}
