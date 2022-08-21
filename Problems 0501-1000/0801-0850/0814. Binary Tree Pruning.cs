using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0814
    {
        public TreeNode PruneTree(TreeNode root)
        {
            var head = root;
            return hasOne(head)?root:null;
        }

        public bool hasOne(TreeNode node)
        {
            if(node != null)
            {

                bool left = hasOne(node.left);
                bool right = hasOne(node.right);

                if (!left)
                {
                    node.left = null;
                }


                if (!right) node.right = null;

                return left || right || node.val == 1;

            }
            return false;
        }

        //01-05-2022-------------------

        public TreeNode PruneTree_R2(TreeNode root)
        {
            helper(root);
            return root == null ? root : null;
        }
        public bool helper(TreeNode node)
        {
            if (node != null)
            {

                bool left = hasOne(node.left);
                bool right = hasOne(node.right);

                if (!left)
                {
                    node.left = null;
                }


                if (!right) node.right = null;

                return left || right || node.val == 1;

            }
            return false;
        }
    }
}
