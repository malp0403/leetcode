using leetcode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Exampless
/*
 Given the root of a binary tree, collect a tree's nodes as if you were doing this:

Collect all the leaf nodes.
Remove all the leaf nodes.
Repeat until the tree is empty.
 

Example 1:


Input: root = [1,2,3,4,5]
Output: [[4,5,3],[2],[1]]
Explanation:
[[3,5,4],[2],[1]] and [[3,4,5],[2],[1]] are also considered correct answers since per each level it does not matter the order on which elements are returned.
Example 2:

Input: root = [1]
Output: [[1]]
 

Constraints:

The number of nodes in the tree is in the range [1, 100].
-100 <= Node.val <= 100
 */
#endregion

namespace leetcode.Problems_0001_500._0351_0400
{
    internal class _0366
    {
        #region 11/19/2023
        Dictionary<TreeNode,int> dic= new Dictionary<TreeNode,int>();
        public IList<IList<int>> FindLeaves_(TreeNode root)
        {
            return null;
        }
        public int dfs_2023_11_19(TreeNode node)
        {
            return 0;
        }
        #endregion
    }
}
