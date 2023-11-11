using leetcode.Class;
using leetcode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Examples
/*
 Given a binary tree root and a linked list with head as the first node. 

Return True if all the elements in the linked list starting from the head correspond to some downward path connected in the binary tree otherwise return False.

In this context downward path means a path that starts at some node and goes downwards.

 

Example 1:



Input: head = [4,2,8], root = [1,4,4,null,2,2,null,1,null,6,8,null,null,null,null,1,3]
Output: true
Explanation: Nodes in blue form a subpath in the binary Tree.  
Example 2:



Input: head = [1,4,2,6], root = [1,4,4,null,2,2,null,1,null,6,8,null,null,null,null,1,3]
Output: true
Example 3:

Input: head = [1,4,2,6,8], root = [1,4,4,null,2,2,null,1,null,6,8,null,null,null,null,1,3]
Output: false
Explanation: There is no path in the binary tree that contains all the elements of the linked list from head.
 

Constraints:

The number of nodes in the tree will be in the range [1, 2500].
The number of nodes in the list will be in the range [1, 100].
1 <= Node.val <= 100 for each node in the linked list and binary tree.
 */
#endregion

namespace leetcode.Problems_1001_1500._1351_1400
{
    internal class _1367
    {
        #region 11/03/2023
        public bool IsSubPath_20231103(ListNode head, TreeNode root)
        {
            Queue<TreeNode> q = new Queue<TreeNode>();
            if (root == null) return false;
            q.Enqueue(root);
            while (q.Count > 0)
            {
                TreeNode node = q.Dequeue();
                if (node.val == head.val)
                {
                    if (find_20231103(head, node)) return true;
                }
                if(node.left !=null) q.Enqueue(node.left);
                if (node.right != null) q.Enqueue(node.right);
            }

            return false;        
        }
        public bool find_20231103(ListNode head,TreeNode node)
        {
            if (head == null) return true;
            if (head != null && node == null) return false;
            if (head.val != node.val) return false;

            return find_20231103(head.next, node.left) || find_20231103(head.next, node.right);
        }
        #endregion
    }
}
