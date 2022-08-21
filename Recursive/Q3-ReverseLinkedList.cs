using System;
using System.Collections.Generic;
using System.Text;
using leetcode.Class;
namespace leetcode.Recursive
{
    class Q3_ReverseLinkedList
    {
        //**************Solution 1**************************
        public ListNode ReverseList(ListNode head)
        {
            if (head == null || head.next == null) return head;
            ListNode p = ReverseList(head.next);
            head.next.next = head;
            head.next = null;
            return p;
        }
        //**************Solution 2**************************
        public ListNode ReverseList_V2(ListNode head)
        {
            if (head == null) return head;
            return helper(head, null);
        }
        public ListNode helper(ListNode node, ListNode prev)
        {
            if (node == null) return prev;
            ListNode temp = node.next;
            node.next = prev;
            return helper(temp, node);
        }

    }
}
