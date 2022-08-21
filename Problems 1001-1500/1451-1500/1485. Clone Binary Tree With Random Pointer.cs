using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _1485
    {
        public NodeCopy CopyRandomBinaryTree(Node root)
        {
            Dictionary<Node, NodeCopy> d = new Dictionary<Node, NodeCopy>() { };
            Stack<Node> stack = new Stack<Node>() { };
            if (root == null) return null;
            stack.Push(root);
            while (stack.Count != 0)
            {
                var n = stack.Pop();
                if (!d.ContainsKey(n)) d.Add(n, new NodeCopy(n.val));
                if (n.left != null)
                {
                    stack.Push(n.left);
                }
                if(n.right != null)
                {
                    stack.Push(n.right);
                }
            }
            stack.Push(root);
            while (stack.Count != 0)
            {
                var n = stack.Pop();
                var copy = d[n];
                if(n.right != null)
                {
                    copy.right = d[n.right];
                    stack.Push(n.right);
                }
                if (n.left != null)
                {
                    copy.left = d[n.left];
                    stack.Push(n.left);
                }
                if (n.random != null)
                {
                    copy.random = d[n.random];
                }
            }
            return d[root];
        }

        public class Node
        {
            public int val;
            public Node left;
            public Node right;
            public Node random;
            public Node(int val = 0, Node left = null, Node right = null, Node random = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
                this.random = random;
            }
        }
        public class NodeCopy
        {
            public int val;
            public NodeCopy left;
            public NodeCopy right;
            public NodeCopy random;
            public NodeCopy(int val = 0, NodeCopy left = null, NodeCopy right = null, NodeCopy random = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
                this.random = random;
            }
        }


    }


}
