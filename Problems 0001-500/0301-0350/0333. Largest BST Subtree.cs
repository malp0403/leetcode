using leetcode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
#region Examples
/*
 Given the root of a binary tree, find the largest 
subtree
, which is also a Binary Search Tree (BST), where the largest means subtree has the largest number of nodes.

A Binary Search Tree (BST) is a tree in which all the nodes follow the below-mentioned properties:

The left subtree values are less than the value of their parent (root) node's value.
The right subtree values are greater than the value of their parent (root) node's value.
Note: A subtree must include all of its descendants.

 

Example 1:



Input: root = [10,5,15,1,8,null,7]
Output: 3
Explanation: The Largest BST Subtree in this case is the highlighted one. The return value is the subtree's size, which is 3.
Example 2:

Input: root = [4,2,7,2,3,5,null,2,null,null,null,null,null,1]
Output: 2
 

Constraints:

The number of nodes in the tree is in the range [0, 104].
-104 <= Node.val <= 104
 

Follow up: Can you figure out ways to solve it with O(n) time complexity?
 */
#endregion

#region Test
/*
             TreeNode n1 = new TreeNode(1);
            TreeNode n2 = new TreeNode(2);
            TreeNode n3 = new TreeNode(3);
            n2.left = n1;
            n2.right = n3;
            var obj = new _0333();
            obj.LargestBSTSubtree(n2);
 */
#endregion
namespace leetcode.Problems_0001_500._0301_0350
{
    internal class _0333
    {
        #region 2023_11_19
        public int LargestBSTSubtree_2023_11_19(TreeNode root)
        {
            if (root == null) return 0;
            if (isValid_2023_11_19(root))
            {
                return countNode_2023_11_19(root);
            }

            return Math.Max(LargestBSTSubtree_2023_11_19(root.left), LargestBSTSubtree_2023_11_19(root.right));
        }
        public int findMin_2023_11_19(TreeNode node)
        {
            if (node == null) return int.MaxValue;

            return Math.Min(Math.Min(node.val, findMin_2023_11_19(node.left)), findMin_2023_11_19(node.right));
        }
        public int findMax_2023_11_19(TreeNode node)
        {
            if (node == null) return int.MinValue;

            return Math.Max(Math.Max(node.val, findMax_2023_11_19(node.left)), findMax_2023_11_19(node.right));
        }
        public int countNode_2023_11_19(TreeNode node)
        {
            if (node == null) return 0;
            return 1 + countNode_2023_11_19(node.left) + countNode_2023_11_19(node.right);
        }
        public bool isValid_2023_11_19(TreeNode node)
        {
            if (node == null) return true;
            int leftMax = findMax_2023_11_19(node.left);
            if (leftMax >= node.val) return false;
            int rightMin = findMin_2023_11_19(node.right);
            if (rightMin <= node.val) return false;
            if (isValid_2023_11_19(node.left) && isValid_2023_11_19(node.right)) return true;

            return false;

        }
        #endregion

    }
}
