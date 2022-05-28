using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0426
    {
        //****************dfs binding during Recursive****************
        Node first = null;
        Node last = null;
        public Node TreeToDoublyList_dfs(Node root)
        {
            if (root == null) return null;
            helper_dfs(root);

            last.right = first;
            first.left = last;
            return first;
        }
        public void helper_dfs(Node root)
        {
            if(root != null)
            {
                helper_dfs(root.left);
                if(last == null)
                {
                    last = root;
                    first = root;
                }
                else
                {
                    last.right = root;
                    root.left = last;
                    last = root;
                }
                helper_dfs(root.right);
            }
           
        }
        //********************************

        List<Node> inorder = new List<Node>() { };
        public Node TreeToDoublyList(Node root)
        {
            if (root == null) return null;
            dfs(root);
            Node head = new Node(-1001);
            head.right = inorder[0];
            Node pre = inorder[inorder.Count - 1];
            for(int i =0; i < inorder.Count; i++)
            {
                inorder[i].left = pre;
                pre.right = inorder[i];
                pre = inorder[i];
            }

            return head.right;
        }
        public void dfs(Node node)
        {
            if(node != null)
            {
                dfs(node.left);
                inorder.Add(node);
                dfs(node.right);
            }
        }
       
    }
    public class Node
    {
        public int val;
        public Node left;
        public Node right;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
            left = null;
            right = null;
        }

        public Node(int _val, Node _left, Node _right)
        {
            val = _val;
            left = _left;
            right = _right;
        }
    }
}
