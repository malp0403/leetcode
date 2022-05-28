using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0138
    {
        Dictionary<Node, Node> dic = new Dictionary<Node, Node>() { };
        public Node CopyRandomList(Node head)
        {
            if (head == null) return null;
            if (!dic.ContainsKey(head))
            {
                Node clone = new Node(head.val);
                dic.Add(head, clone);
                dic[head].next = CopyRandomList(head.next);
                dic[head].random = CopyRandomList(head.random);
            }
            return head;
        }
        public class Node
        {
            public int val;
            public Node next;
            public Node random;

            public Node(int _val)
            {
                val = _val;
                next = null;
                random = null;
            }
        }
    }
}
