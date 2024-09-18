using leetcode.Class;
using leetcode.Problems;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Example
/*
 Given the root of a binary tree and an array of TreeNode objects nodes, return the lowest common ancestor (LCA) of all the nodes in nodes. All the nodes will exist in the tree, and all values of the tree's nodes are unique.

Extending the definition of LCA on Wikipedia: "The lowest common ancestor of n nodes p1, p2, ..., pn in a binary tree T is the lowest node that has every pi as a descendant (where we allow a node to be a descendant of itself) for every valid i". A descendant of a node x is a node y that is on the path from node x to some leaf node.

 

Example 1:


Input: root = [3,5,1,6,2,0,8,null,null,7,4], nodes = [4,7]
Output: 2
Explanation: The lowest common ancestor of nodes 4 and 7 is node 2.
Example 2:


Input: root = [3,5,1,6,2,0,8,null,null,7,4], nodes = [1]
Output: 1
Explanation: The lowest common ancestor of a single node is the node itself.

Example 3:


Input: root = [3,5,1,6,2,0,8,null,null,7,4], nodes = [7,6,2,4]
Output: 5
Explanation: The lowest common ancestor of the nodes 7, 6, 2, and 4 is node 5.
 

Constraints:

The number of nodes in the tree is in the range [1, 104].
-109 <= Node.val <= 109
All Node.val are unique.
All nodes[i] will exist in the tree.
All nodes[i] are distinct.
 */
#endregion

#region Test
/*
             TreeNode n0 = new TreeNode(0);
            TreeNode n1 = new TreeNode(1);
            TreeNode n2 = new TreeNode(2);
            TreeNode n3 = new TreeNode(3);
            TreeNode n4 = new TreeNode(4);
            TreeNode n5 = new TreeNode(5);
            TreeNode n6 = new TreeNode(6);
            TreeNode n7 = new TreeNode(7);
            TreeNode n8 = new TreeNode(8);

            n3.left = n5;
            n3.right = n1;
            n5.left = n6;
            n5.right = n2;
            n2.left = n7;
            n2.right = n4;
            n1.left = n0;
            n1.right = n8;

            var obj = new _1676() { };
            obj.LowestCommonAncestor_20231017(n3,new TreeNode[] {n4,n7});
 */
#endregion

namespace leetcode.Problems_1501_2000._1651_1700
{
    internal class _1676
    {
        #region 10/17/2023
        TreeNode answer = null;
        HashSet<int> set;
        public TreeNode LowestCommonAncestor_20231017(TreeNode root, TreeNode[] nodes)
        {
            set = new HashSet<int>();
            foreach (var item in nodes)
            {
                set.Add(item.val);
            }

            dfs(root);
            return answer;

        }
        public int dfs(TreeNode node)
        {
            if (node == null) return 0;
            int initial = 0;
            if (set.Contains(node.val))
            {
                initial = 1;
            }

            int left = dfs(node.left);
            int right = dfs(node.right);

            int total = initial + left + right;

            if(total == set.Count && answer == null)
            {
                answer = node;
            }
            return total;
        }
        #endregion
    }
}
