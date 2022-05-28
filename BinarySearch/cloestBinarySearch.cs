using leetcode.Problems;
using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.BinarySearch
{
    class cloestBinarySearch
    {
        List<int> inorder = new List<int>() { };

        public int ClosestValue(TreeNode root, double target)
        {
            if (root == null) return -1;
            helper(root);

            //min
            if (target < inorder[0]) return inorder[0];
            if (target > inorder[inorder.Count - 1]) return inorder[inorder.Count - 1];

            int l = 0;
            int r = inorder.Count - 1;
            while (l <= r)
            {
                int mid = l + (r - l) / 2;
                if (inorder[mid] == target) return inorder[mid];
                if ((inorder[mid] - target) > 0 != (inorder[mid + 1] - target) > 0) {
                    return Math.Abs(inorder[mid] - target) > (inorder[mid + 1] - target) ? inorder[mid + 1] : inorder[mid];
                }
                else if(inorder[mid] < target)
                {
                    l = mid + 1;
                }
                else
                {
                    r = mid;
                }
            }
            return l;

        }
        public void helper(TreeNode node)
        {
            if(node != null)
            {
                helper(node.left);
                inorder.Add(node.val) ;
                helper(node.right);
            }
        }
        public int CloestValue_V2(TreeNode root,double target)
        {
            int cloest = root.val;
            int val;
            while(root != null)
            {
                val = root.val;
                cloest = Math.Abs(root.val - target) < Math.Abs(cloest - target) ? root.val : cloest;
                root = (target > root.val) ? root.right : root.left;
            }
            return cloest;
        }
    }

}
