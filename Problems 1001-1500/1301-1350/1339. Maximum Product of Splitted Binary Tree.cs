using leetcode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Examples
/*
 Given the root of a binary tree, split the binary tree into two subtrees by removing one edge such that the product of the sums of the subtrees is maximized.

Return the maximum product of the sums of the two subtrees. Since the answer may be too large, return it modulo 109 + 7.

Note that you need to maximize the answer before taking the mod and not after taking it.

 

Example 1:


Input: root = [1,2,3,4,5,6]
Output: 110
Explanation: Remove the red edge and get 2 binary trees with sum 11 and 10. Their product is 110 (11*10)
Example 2:


Input: root = [1,null,2,3,4,null,null,5,6]
Output: 90
Explanation: Remove the red edge and get 2 binary trees with sum 15 and 6.Their product is 90 (15*6)
 

Constraints:

The number of nodes in the tree is in the range [2, 5 * 104].
1 <= Node.val <= 104
 */
#endregion

namespace leetcode.Problems_1001_1500._1301_1350
{
    internal class _1339
    {
        #region 11/04/2023 DFS
        long max = long.MinValue;
        long sum = 0;
        int mod = 1000000007;
        public int MaxProduct_20231104(TreeNode root)
        {
            TreeNode temp = root;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(temp);
            while (queue.Count > 0)
            {
                TreeNode temp2 = queue.Dequeue();
                sum += (long)temp2.val;
                if (temp2.right != null)
                {
                    queue.Enqueue((temp2.right));
                }
                if (temp2.left != null)
                {
                    queue.Enqueue((temp2.left));
                }
            }
            helper_20231104(root);
            return (int)(max % mod);
        }

        public long helper_20231104(TreeNode node)
        {
            if (node == null) return 0;

            long left = helper_20231104(node.left);
            long right = helper_20231104(node.right);
            long curSum = (long)node.val + left + right;
            max = Math.Max(max, (long)curSum * (sum - curSum));

            return curSum;
        }
        #endregion
    }
}
