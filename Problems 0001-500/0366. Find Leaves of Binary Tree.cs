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

        #region 09/01/2024 DFS (Depth-First Search) without sorting
        Dictionary<TreeNode, int> dic_2024_09_01;
        IList<IList<int>> answer_2024_09_01 = new List<IList<int>>();

        public IList<IList<int>> FindLeaves(TreeNode root)
        {
            dic_2024_09_01 = new Dictionary<TreeNode, int>();
            depth_2024_09_01(root);

            return answer_2024_09_01;

        }
        public int depth_2024_09_01(TreeNode node)
        {
            if (node == null) return 0;

            if (dic_2024_09_01.ContainsKey(node))
            {
                return dic_2024_09_01[node];
            }

            int depth = Math.Max(depth_2024_09_01(node.left),depth_2024_09_01(node.right))+1;

            dic.Add(node, depth);
            if(answer_2024_09_01.Count < depth)
            {
                answer_2024_09_01.Add(new List<int>() { node.val });
            }
            else
            {
                answer_2024_09_01[depth - 1].Add(node.val);
            }
            return dic[node];
            

        }
        #endregion


    }
}
