using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0117
    {
        public Node Connect(Node root)
        {
            if (root == null) return null;
            Queue<Node> quene = new Queue<Node>() { };
            quene.Enqueue(root);
            quene.Enqueue(null);
            while (quene.Count > 0)
            {
                var start = quene.Dequeue();
                while (start != null)
                {
                    if(start.left != null)quene.Enqueue(start.left);
                    if (start.right != null)  quene.Enqueue(start.right);
                    var next = quene.Dequeue();
                    start.next = next;
                    start = start.next;
                }
                if (quene.Count > 0)
                {
                    quene.Enqueue(null);
                }
            }
            return root;
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
            }

            public Node(int _val, Node _left, Node _right, Node _next)
            {
                val = _val;
                left = _left;
                right = _right;
                next = _next;
            }
        }
    }
}
