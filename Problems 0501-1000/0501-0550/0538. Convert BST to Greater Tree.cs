using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0538
    {
        public TreeNode ConvertBST(TreeNode root)
        {
            int sum = 0;
            TreeNode node = root;
            while(node != null)
            {
                if(node.right == null)
                {
                    sum += node.val;
                    node.val = sum;
                    node = node.left;
                } 
                else
                {
                    var suc = getParent(node);
                    if (node.left == null)
                    {
                        suc.left = node;
                        node = node.right;
                    }
                    else
                    {
                        suc.left = null;
                        sum += node.val;
                        node.val = sum;
                        node = node.left;
                    }
                }
            }
            return root;
        }

        public TreeNode getParent(TreeNode node)
        {
            TreeNode suc = node.right;
            while(suc.left !=null && suc.left != node)
            {
                suc = suc.left;
            }
            return suc;
        }

        //01-11-2022-------------------------------
        public TreeNode ConvertBST_R2(TreeNode root)
        {
            int sum = 0;
            TreeNode cur = root;
            while(cur != null)
            {
                if(cur.right == null)
                {
                    sum += cur.val;
                    cur.val = sum;
                    cur = cur.left;
                }
                else
                {
                    TreeNode n = Helper_R2(cur);
                    if(n.left == null)
                    {
                        n.left = cur;
                        cur = cur.right;
                    }
                    else
                    {
                        n.left = null;
                        sum += cur.val;
                        cur.val = sum;
                        cur = cur.left;
                    }
                }
            }
            return root;
        }
        public TreeNode Helper_R2(TreeNode node)
        {
            TreeNode n = node.right;
            while(n.left !=null && n.left != node)
            {
                n = n.left;
            }
            return n;
        }
    }
}
