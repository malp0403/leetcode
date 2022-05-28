using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0450
    {
        public TreeNode DeleteNode(TreeNode root, int key)
        {
            if (root == null) return root;
            if (root.val == key)
            {
                if(root.left != null)
                {
                    var cur = root.left;
                    while(cur != null && cur.right !=null)
                    {
                        cur = cur.right;
                    }
                    cur.right = root.right;
                    return root.left;

                }
                else
                {
                    return root.right;
                }
            }
            else
            {
                travel(root, null, key, false);
            }
            return root;
        }
        public void travel  (TreeNode node, TreeNode parent, int key,bool isLeft)
        {
            if (node != null)
            {
                if (node.val == key)
                {
                    if (isLeft)
                    {
                        if(node.left != null)
                        {
                            var cur = node.left;
                            while(cur !=null && cur.right != null)
                            {
                                cur = cur.right;
                            }
                            cur.right = node.right;
                            parent.left = node.left;
                        }
                        else
                        {
                            parent.left = node.right;
                        }
                    }
                    else
                    {
                        if(node.right != null)
                        {
                            var cur = node.right;
                            while(cur !=null && cur.left != null)
                            {
                                cur = cur.left;
                            }
                            cur.left = node.left;
                            parent.right = node.right;
                        }
                        else
                        {
                            parent.right = node.left;
                        }
                    }
                }
                else
                {
                    travel(node.left, node, key, true);
                    travel(node.right, node, key, false);
                }
            }
           
        }
    }
}
