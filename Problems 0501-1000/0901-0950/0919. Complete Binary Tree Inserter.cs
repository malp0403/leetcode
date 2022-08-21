using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0919
    {
        //List<List<TreeNode>> list = new List<List<TreeNode>>() { };
        //public _0919(TreeNode root)
        //{

        //    if (root == null) return;
        //    Queue<TreeNode> q = new Queue<TreeNode>() { };
        //    q.Enqueue(root);
        //    while (q.Count != 0)
        //    {
        //        int size = q.Count;
        //        List<TreeNode> li = new List<TreeNode>() { };
        //        while (size > 0)
        //        {
        //            TreeNode n = q.Dequeue();
        //            li.Add(n);
        //            if (n.left != null) q.Enqueue(n.left);
        //            if (n.right != null) q.Enqueue(n.right);
        //            size--;
        //        }
        //        list.Add(li);
        //    }
        //}

        //public int Insert(int val)
        //{
        //    TreeNode node = new TreeNode(val);
        //    int count = list.Count;

        //    if (count == 0)
        //    {
        //        list.Add(new List<TreeNode>() { node });
        //        return 0;
        //    }

        //    int eleCount = list[count - 1].Count;
        //    //full 
        //    if (eleCount == Math.Pow(2, count - 1))
        //    {
        //        List<TreeNode> newList = new List<TreeNode>() { };
        //        TreeNode parent = list[count - 1][0];

        //        parent.left = node;
        //        newList.Add(node);
        //        list.Add(newList);
        //        return parent.val;
        //    }
        //    else
        //    {
        //        int indx = eleCount / 2;
        //        TreeNode parent = list[count - 2][indx];

        //        if(parent.left == null)
        //        {
        //            parent.left = node;
        //        }
        //        else
        //        {
        //            parent.right = node;
        //        }
        //        list[count - 1].Add(node);
        //        return parent.val;
        //    }
        //}

        //public TreeNode Get_root()
        //{
        //    if (list.Count == 0) return null;
        //    else return list[0][0];
        //}

        //*************Stack-- keeping treenode needs children*************

        TreeNode _root = null;
        Queue<TreeNode> queue = new Queue<TreeNode>() { };
        public _0919(TreeNode root)
        {
            _root = root;
            Queue<TreeNode> q = new Queue<TreeNode>() { };
            if(root != null)
            {
                q.Enqueue(root);
                while (q.Count != 0)
                {
                    int size = q.Count;
                    while (size > 0)
                    {
                        TreeNode n = q.Dequeue();
                        if(n.left == null || n.right == null)
                        {
                            queue.Enqueue(n);
                        }
                        if (n.left != null) q.Enqueue(n.left);
                        if (n.right != null) q.Enqueue(n.right);
                        size--;
                    }
                }
            }
          
        }

        public int Insert(int val)
        {
            TreeNode parent = queue.Peek();
            TreeNode node = new TreeNode(val);
            if (parent.left == null) parent.left = node;
            else
            {
                parent.right = node;
                queue.Dequeue();
            }
            queue.Enqueue(node);
            return parent.val;
        }

        public TreeNode Get_root()
        {
            return _root;
        }
    }
}
