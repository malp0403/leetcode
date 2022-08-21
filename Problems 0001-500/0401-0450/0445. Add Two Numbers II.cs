using System;
using System.Collections.Generic;
using System.Text;
using leetcode.Class;
namespace leetcode.Problems
{
    class _0445
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            l1 = reverseNode(l1);
            l2 = reverseNode(l2);
            int incre = 0;
            ListNode head = null;
            while(l1 !=null || l2 != null)
            {
                var v1 = 0;
                if (l1 != null)
                {
                    v1 = l1.val;
                    l1 = l1.next;
                }
                var v2 = 0;
                if (l2 != null)
                {
                    v2 = l2.val;
                    l2 = l2.next;
                }
                int total = (v1 + v2+ incre) % 10;
                incre = (v1 + v2 + incre) / 10;

                var temp = new ListNode(total);
                temp.next = head;
                head = temp;
               
            }
            if(incre != 0)
            {
                var temp = new ListNode(1);
                temp.next = head;
                head = temp;
            }

            return head;




        }

        public ListNode reverseNode(ListNode head)
        {
            ListNode last = null;
            while(head != null)
            {
                var temp = head.next;
                head.next = last;

                last = head;
                head = temp;
            }
            return last;
        }
    }
}
