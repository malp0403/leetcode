using System;
using System.Collections.Generic;
using System.Text;
using leetcode.Class;
namespace leetcode.Problems
{
    class _0086
    {
        public ListNode Partition(ListNode head, int x)
        {
            ListNode answer = new ListNode(101);
            ListNode cur = answer;
            ListNode newHead = new ListNode(102);
            ListNode prev = newHead;

            while (head != null)
            {
                if (head.val < x)
                {
                    cur.next = head;
                    cur = cur.next;
                }
                else
                {
                    prev.next = head;
                    prev = prev.next;
                }
                head = head.next;
            }
            prev.next = null;
            cur.next = newHead.next;
            return answer.next;

        }
    }
}
