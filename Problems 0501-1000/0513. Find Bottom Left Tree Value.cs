using leetcode.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#region Examples
/*
 Given the root of a binary tree, return the leftmost value in the last row of the tree.

 

Example 1:


Input: root = [2,1,3]
Output: 1
Example 2:


Input: root = [1,2,3,4,null,5,6,null,null,7]
Output: 7
 

Constraints:

The number of nodes in the tree is in the range [1, 104].
-231 <= Node.val <= 231 - 1
 */
#endregion
namespace leetcode.Problems_0501_1000._0501_0550
{
    internal class _0513
    {
        #region 11/27/2023
        public int FindBottomLeftValue(TreeNode root)
        {
            if (root == null) return 0;
            int ans = 0;
            Queue<TreeNode> q= new Queue<TreeNode>();
            q.Enqueue(root);

            while (q.Count > 0)
            {
                int count = q.Count;
                ans = q.Peek().val;
                while(count > 0)
                {
                    TreeNode node = q.Dequeue();
                    if(node.left != null)
                    {
                        q.Enqueue(node.left);
                    }
                    if(node.right != null)
                    {
                        q.Enqueue(node.right);
                    }
                }
            }
            return ans;
            
        }
        #endregion
    }
}
