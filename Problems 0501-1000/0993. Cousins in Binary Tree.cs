using leetcode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Examples
/*
 Given the root of a binary tree with unique values and the values of two different nodes of the tree x and y, return true if the nodes corresponding to the values x and y in the tree are cousins, or false otherwise.

Two nodes of a binary tree are cousins if they have the same depth with different parents.

Note that in a binary tree, the root node is at the depth 0, and children of each depth k node are at the depth k + 1.

 

Example 1:


Input: root = [1,2,3,4], x = 4, y = 3
Output: false
Example 2:


Input: root = [1,2,3,null,4,null,5], x = 5, y = 4
Output: true
Example 3:


Input: root = [1,2,3,null,4], x = 2, y = 3
Output: false
 

Constraints:

The number of nodes in the tree is in the range [2, 100].
1 <= Node.val <= 100
Each node has a unique value.
x != y
x and y are exist in the tree.
 */
#endregion
namespace leetcode.Problems_0501_1000._0951_1000
{
    internal class _0993
    {
        #region 11/12/2023
        public bool IsCousins_20231112(TreeNode root, int x, int y)
        {
            if (root == null || root.val == x || root.val == y) return false;
            int first = -1;
            TreeNode firstparent = null;
            int second = -1;
            TreeNode secondparent = null;

            int depth = 0;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0 && (first ==-1 || second == -1))
            {
                int count = queue.Count;
                while (count > 0)
                {
                    TreeNode node = queue.Dequeue();
 
                    if (node.right != null) {
                        queue.Enqueue(node.right);
                        if(node.right.val == x)
                        {
                            first = depth + 1;
                            firstparent = node;
                        }
                        if (node.right.val == y)
                        {
                            second = depth + 1;
                            secondparent = node;
                        }
                    }

                    if (node.left != null) {
                        queue.Enqueue(node.left);
                        if (node.left.val == x)
                        {
                            first = depth + 1;
                            firstparent = node;
                        }
                        if (node.left.val == y)
                        {
                            second = depth + 1;
                            secondparent = node;
                        }
                    }
                    count--;
                }
                depth++;
            }
            return first == second && firstparent != secondparent;
        }
        #endregion
    }
}
