using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0098
    {
        Stack<TreeNode> stack;
        bool isFound = false;
       
        public bool IsValidBST_v1(TreeNode root)
        {
            return topDownDFS(root,Int32.MinValue, Int32.MaxValue);
        }
        public bool topDownDFS(TreeNode root,int low, int high)
        {
            if(root != null)
            {
                
                if ((root.val <= low) || (root.val >= high)) return false;
                return topDownDFS(root.right, root.val, high) && topDownDFS(root.left, low, root.val);
            }
            return true;
        }
       
    }
}
