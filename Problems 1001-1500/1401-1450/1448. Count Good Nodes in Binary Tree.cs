using leetcode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Example
/*
 Given a binary tree root, a node X in the tree is named good if in the path from root to X there are no nodes with a value greater than X.

Return the number of good nodes in the binary tree.

 

Example 1:



Input: root = [3,1,4,3,null,1,5]
Output: 4
Explanation: Nodes in blue are good.
Root Node (3) is always a good node.
Node 4 -> (3,4) is the maximum value in the path starting from the root.
Node 5 -> (3,4,5) is the maximum value in the path
Node 3 -> (3,1,3) is the maximum value in the path.
Example 2:



Input: root = [3,3,null,4,2]
Output: 3
Explanation: Node 2 -> (3, 3, 2) is not good, because "3" is higher than it.
Example 3:

Input: root = [1]
Output: 1
Explanation: Root is considered as good.
 

Constraints:

The number of nodes in the binary tree is in the range [1, 10^5].
Each node's value is between [-10^4, 10^4].
 */
#endregion

namespace leetcode.Problems_1001_1500._1401_1450
{
    internal class _1448
    {
        #region 10/24/2023
        int count_20231024 = 0;
        public int GoodNodes(TreeNode root)
        {
            if(root ==null) return count_20231024;
            helper(root, -10001);


            return count_20231024;
        }
        public void helper(TreeNode node, int curMax)
        {
            if (node == null) return;
            if(node.val >= curMax)
            {
                count_20231024++;
            }
            curMax = Math.Max(node.val, curMax);

            helper(node.left, curMax);
            helper(node.right, curMax);
        }
        #endregion
    }
}
