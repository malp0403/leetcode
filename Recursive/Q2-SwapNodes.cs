using System;
using System.Collections.Generic;
using System.Text;
using leetcode.Class;
namespace leetcode.Recursive
{
    class Q2_SwapNodes
    {
        public ListNode SwapPairs(ListNode head)
        {
            return helper(head);
        }
        public ListNode helper(ListNode node)
        {
            if (node == null || node.next == null) return node;
            ListNode first = node;
            ListNode second = node.next;
            ListNode temp = second.next;
            second.next = first;
            first.next = helper(temp);
            return second;
        }
    }
}
