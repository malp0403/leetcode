using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _1110
    {
        ///*****************Test*********************
         //TreeNode n1 = new TreeNode(1);
        //TreeNode n2 = new TreeNode(2);
        //TreeNode n3 = new TreeNode(3);
        //TreeNode n4 = new TreeNode(4);
        //TreeNode n5 = new TreeNode(5);
        //TreeNode n6 = new TreeNode(6);
        //TreeNode n7 = new TreeNode(7);
        //n1.left = n2;
        //    n1.right = n3;
        //    n2.left = n4;
        //    n2.right = n5;
        //    n3.left = n6;
        //    n3.right = n7;
        /// </summary>

        int[] _to_delete;
        List<TreeNode> l;
        public IList<TreeNode> DelNodes(TreeNode root, int[] to_delete)
        {
            l = new List<TreeNode>() { };
            this._to_delete = to_delete;
            if (Array.IndexOf(_to_delete, root.val) < 0)
            {
                l.Add(root);
            }
            travel(root, null);
            return l;
        }

        public void travel(TreeNode n, TreeNode parent)
        {
            if (n != null)
            {
                travel(n.left, n);
                travel(n.right, n);

                if (Array.IndexOf(_to_delete, n.val) >= 0)
                {
                    if (parent != null)
                    {
                        if (parent.left == n)
                        {
                            parent.left = null;
                        }
                        else
                        {
                            parent.right = null;
                        }
                    }


                    if (n.left != null) l.Add(n.left);
                    if (n.right != null) l.Add(n.right);
                }
            }
        }

        //01-06-2022--------------------------------
        HashSet<int> set;
        IList<TreeNode> ans;
        public IList<TreeNode> DelNodes_R2(TreeNode root, int[] to_delete)
        {

            if (root == null) return null;
            ans = new List<TreeNode>() { };
            set = new HashSet<int>() { };
            foreach (var num in to_delete)
            {
                set.Add(num);
            }
            if (!set.Contains(root.val)) ans.Add(root);
            helper(root, null);
            return ans;

        }
        public void helper(TreeNode node, TreeNode parent)
        {
            if (node != null)
            {
                if (node.left != null)
                {
                    helper(node.left, node);
                    if (set.Contains(node.left.val))
                    {
                        node.left = null;
                    }
                    else
                    {
                        if (set.Contains(node.val))
                        {
                            ans.Add(node.left);
                        }
                    }
                }
                if (node.right != null)
                {
                    helper(node.right, node);

                    if (set.Contains(node.right.val))
                    {
                        node.right = null;
                    }
                    else
                    {
                        if (set.Contains(node.val))
                        {
                            ans.Add(node.right);
                        }
                    }
                }
            }
        }
        //-----------------------------------------
    }
}
