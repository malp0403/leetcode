using leetcode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Given the root of a binary tree, return the length of the longest path, where each node in the path has the same value. This path may or may not pass through the root.

The length of the path between two nodes is represented by the number of edges between them.

 

Example 1:


Input: root = [5,4,5,1,1,null,5]
Output: 2
Explanation: The shown image shows that the longest path of the same value (i.e. 5).
Example 2:


Input: root = [1,4,5,4,4,null,5]
Output: 2
Explanation: The shown image shows that the longest path of the same value (i.e. 4).
 

Constraints:

The number of nodes in the tree is in the range [0, 104].
-1000 <= Node.val <= 1000
The depth of the tree will not exceed 1000.
 */

namespace leetcode.Problems_0501_1000._0651_0700
{
    internal class _0687
    {
        #region 12/05/2023 LeetCode Solution1: DFS

        int max = 0;
        public int LongestUnivaluePath(TreeNode root)
        {
            helper(root, -1);
            return max;
        }

        public int helper(TreeNode node,int target)
        {
            if (node == null) return 0;
   

            int left = helper(node.left, node.val);
            int right = helper(node.right, node.val);

            max = Math.Max(max, left + right);



            return node.val == target? 1 + Math.Max(left,right):0;
        }
        #endregion
    }
}
