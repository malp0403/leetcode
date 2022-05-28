using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0430
    {
        //***************************************Solution 1*******************************

        Node temp;
        public Node Flatten(Node head)
        {
            temp = new Node();
            flatten(temp,head);
            temp.next.prev = null;
            return temp.next;
        }
        public Node flatten(Node prev, Node cur)
        {
            if (cur == null) return prev;
            prev.next = cur;
            cur.prev = prev;

            var tempNext = cur.next;
            var tail = flatten(cur, cur.child);
            return flatten(tail, tempNext);
        }
        public class Node
        {
            public int val;
            public Node prev;
            public Node next;
            public Node child;
        }

        //***************************************Solution 2*******************************
        public Node Flatten_v2(Node head)
        {
            if (head == null) return null;
            Node temp = new Node();
            Node prev = new Node();
            Node cur = new Node();

            temp.next = head;
            Stack<Node> stack = new Stack<Node>() { };
            stack.Push(head);
            while (stack.Count != 0)
            {
                cur = stack.Pop();
                cur.prev = prev;
                prev.next = cur;

                if (cur.next != null) stack.Push(cur.next);
                if(cur.child != null)
                {
                    stack.Push(cur.child);
                    cur.child = null;
                }
                prev = cur;

            }
            return Flatten_v2(head);

        }

        //01-13-2022---------------------------------------------------
        public Node Flatten_R2(Node head)
        {
            if (head == null) return null;
            Node temp = new Node();
            Node cur = new Node();
            Node prev = new Node();
            Stack<Node> stack = new Stack<Node>() { };
            temp.next = head;
            stack.Push(head);
            while (stack.Count != 0)
            {
                cur = stack.Pop();
                prev.next = cur;
                cur.prev = prev;
                if (cur.next != null) stack.Push(cur.next);
                if (cur.child != null)
                {
                    stack.Push(cur.child);
                    cur.child = null;
                }
                prev = cur;
            }
            temp.next.prev = null;
            return temp.next;
        }
        //-------------------------------
    }

}
