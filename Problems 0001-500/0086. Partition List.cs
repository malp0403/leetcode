using System;
using System.Collections.Generic;
using System.Text;
using leetcode.Class;
namespace leetcode.Problems
{
    class _0086
    {
        #region Solution
        public ListNode Partition_s(ListNode head, int x)
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
        #endregion

        #region 03/17/2024
        public ListNode Partition(ListNode head, int x)
        {
            ListNode first = new ListNode(0);
            ListNode second = new ListNode(0);
            ListNode first_temp = new ListNode(0);
            ListNode second_temp = new ListNode(0);

            while (head != null)
            {
                if (head.val <x)
                {
                    first_temp.next = head;
                    first_temp = first_temp.next;
                }
                else
                {
                    second_temp.next = head;
                    second_temp = second_temp.next;
                }
                head = head.next;
            }
            second_temp.next = null;

            first_temp.next = second.next;

            return first.next;
        }
        #endregion

    }
}
