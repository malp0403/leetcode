using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0061
    {
        public ListNode RotateRight(ListNode head, int k)
        {
            ListNode end = head;
            int total = 1;
            while(end != null && end.next !=null)
            {
                total++;
                end = end.next;
            }
            k = k % total;
            if (k == 0) return head;

            int count = 1;
            ListNode temp = head;
            while( count != total - k)
            {
                count++;
                temp = temp.next;
            }
            ListNode newHead = temp.next;
            end.next = head;
            temp.next = null;
            return newHead;

        }
    }
}
