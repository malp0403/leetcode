using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _002
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            Queue<int> s1 = new Queue<int>();
            Queue<int> s2 = new Queue<int>();
            while (l1 != null)
            {
                s1.Enqueue(l1.val);
                l1 = l1.next;
            }
            while (l2 != null)
            {
                s2.Enqueue(l2.val);
                l2 = l2.next;
            }
            ListNode s = new ListNode(0);
            ListNode temp = new ListNode(0);
            s.next = temp;
            int increase = 0;
            while (s1.Count > 0 || s2.Count > 0) {
                temp.next = new ListNode((s1.Count > 0 ? s1.Peek() : 0) + (s2.Count > 0 ? s2.Peek() : 0) + increase);
                if (s1.Count > 0) s1.Dequeue();
                if (s2.Count > 0) s2.Dequeue();
                temp = temp.next;
                if (temp.val >= 10)
                {
                    temp.val = temp.val - 10;
                    increase = 1;
                }
                else {
                    increase = 0;
                }
            }
            if (increase == 1) {
                temp.next = new ListNode(1);
            }
            return s.next.next;
        }
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public ListNode AddTwoNumbers_v2(ListNode l1, ListNode l2)
        {
            Queue<int> s1 = new Queue<int>();
            Queue<int> s2 = new Queue<int>();
            while (l1 != null)
            {
                s1.Enqueue(l1.val);
                l1 = l1.next;
            }
            while (l2 != null)
            {
                s2.Enqueue(l2.val);
                l2 = l2.next;
            }
            ListNode s = new ListNode(0);
            ListNode temp = new ListNode(0);
            s.next = temp;
            int increase = 0;
            while (s1.Count > 0 || s2.Count > 0)
            {
                temp.next = new ListNode((s1.Count > 0 ? s1.Peek() : 0) + (s2.Count > 0 ? s2.Peek() : 0) + increase);
                if (s1.Count > 0) s1.Dequeue();
                if (s2.Count > 0) s2.Dequeue();
                temp = temp.next;
                if(temp.val >= 10)
                {
                    temp.val = temp.val - 10;
                    increase = 1;
                }
                else
                {
                    increase = 0;
                }
            }
            if (increase == 1)
            {
                temp.next = new ListNode(1);
            }
            return s.next.next;
        }
    }
}
