using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0019
    {
        #region solution_1
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode cur = head;
            int count = 0;
            while (cur != null)
            {
                count++;
                cur = cur.next;
            }
            int target = count - n;
            if (target == count) return head.next;
            int indx = 0;

            cur = head;
            ListNode prev = new ListNode();
            while(cur != null)
            {
                if (indx != target)
                {
                    prev.next = cur;
                    prev = prev.next;
                }
                cur = cur.next;

                indx++;
            }
            prev.next = null;
            return head;
        }

        public ListNode RemoveNthFromEnd_2(ListNode head, int n)
        {
            ListNode cur = head;
            int count = 0;
            while (cur != null)
            {
                count++;
                cur = cur.next;
            }
            int target = count - n;

            ListNode dummy = new ListNode();
            ListNode first = dummy;
            dummy.next = head;
            while (target > 0)
            {
                target--;
                first = first.next;

            }
            first.next = first.next.next;
            return dummy.next;
        }
        public ListNode RemoveNthFromEnd_3(ListNode head, int n)
        {
            ListNode dummy = new ListNode() { };
            dummy.next = head;
            ListNode first = dummy;
            ListNode second = dummy;

            for(int i =1; i <= n + 1; i++)
            {
                first = first.next;
            }
            while(first != null)
            {
                first = first.next;
                second = second.next;
            }
            second.next = second.next.next;
            return dummy;
        }
        #endregion


    }
}
