﻿using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0426
    {
        #region Approach 1: Recursion
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
            if (root != null)
            {
                helper_dfs(root.left);
                if (last == null)
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
        #endregion

        #region Solution
        List<Node> inorder = new List<Node>() { };
        public Node TreeToDoublyList(Node root)
        {
            if (root == null) return null;
            dfs(root);
            Node head = new Node(-1001);
            head.right = inorder[0];
            Node pre = inorder[inorder.Count - 1];
            for (int i = 0; i < inorder.Count; i++)
            {
                inorder[i].left = pre;
                pre.right = inorder[i];
                pre = inorder[i];
            }

            return head.right;
        }
        public void dfs(Node node)
        {
            if (node != null)
            {
                dfs(node.left);
                inorder.Add(node);
                dfs(node.right);
            }
        }
        #endregion

        #region 09/12/2024
        Node first_2024_09_12;
        Node last_2024_09_12;
        public Node TreeToDoublyList_2024_09_12(Node root)
        {
            if (root == null) return null;
            helper_2024_09_12(root);
            last.right = first;
            first.left = last;

            return first;
        }
        public void helper_2024_09_12(Node node)
        {
            if(node != null)
            {
                helper_2024_09_12(node.left);

                if(last_2024_09_12 != null)
                {
                    node.left = last_2024_09_12;
                    last.right = node;
                }
                else
                {
                    first_2024_09_12 = node;
                }
                last_2024_09_12 = node;

                helper_2024_09_12(node.right);
            }
        }
        #endregion

        #region 10/07/2024  global first , last;
        Node first_2024_10_07 = null;
        Node last_2024_10_07 = null;
        public Node TreeToDoublyList_2024_10_07(Node root)
        {
            if (root == null) return null;
            helper(root);
            last.right = first;
            first.left = last;
            return first;
        }
        public void helper(Node node)
        {
            if(node != null)
            {
                helper(node.left);

                if (last !=null)
                {
                    last.right = node;
                    node.left = last;
                }
                else
                {
                    first = node;
                }

                last = node;
                helper(node.right);

            }
        }
        #endregion







    }
    public class Node
    {
        public int val;
        public Node left;
        public Node right;
        public Node next;

        public Node() { }

        public Node(int _val)
        {
            val = _val;
            left = null;
            right = null;
            next = null;
        }

        public Node(int _val, Node _left, Node _right,Node _next = null)
        {
            val = _val;
            left = _left;
            right = _right;
            next = _next;
        }
    }
}
