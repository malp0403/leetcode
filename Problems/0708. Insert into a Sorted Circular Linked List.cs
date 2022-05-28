using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0708
    {
        public Node Insert(Node head, int insertVal)
        {
            Node node;
            if (head == null)
            {
                node = new Node(insertVal);
                node.next = node;
                return node;
            }

            var cur = head;
            while (true)
            {
                if (cur.val <= insertVal && cur.next.val >= insertVal)
                    break;
                if(cur.val > cur.next.val)
                {
                    if (insertVal >= cur.val ) break;
                    if (insertVal <= cur.next.val) break;
                }
                cur = cur.next;
                if (cur == head) break;
            }


            node = new Node(insertVal);
            var temp = cur.next;
            cur.next = node;
            node.next = temp;

            return head; 
        }
        public class Node
        {
            public int val;
            public Node next;

            public Node() { }

            public Node(int _val)
            {
                val = _val;
                next = null;
            }

            public Node(int _val, Node _next)
            {
                val = _val;
                next = _next;
            }
        }
    }
}
