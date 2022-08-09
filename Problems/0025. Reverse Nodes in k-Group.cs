using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0025
    {
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            ListNode newHead = head;
            int count = k;
            while(newHead != null && count !=0)
            {
                newHead = newHead.next;
                count--;
            }
            if (count != 0) return head;

            ListNode cur = head;
            ListNode prev = null;

            count = k;
            while(count != 0)
            {
                ListNode temp = cur.next;
                cur.next = prev;
                prev = cur;
                cur = temp;
                count--;
            }

            head.next = ReverseKGroup(cur, k);

            return prev;



            
        }

    }
}
