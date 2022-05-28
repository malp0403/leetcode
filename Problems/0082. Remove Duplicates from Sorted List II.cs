using System;
using System.Collections.Generic;
using System.Text;

namespace leetcode.Problems
{
    class _0082
    {
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null) return null;
            //check head is duplicate;
            ListNode temp = new ListNode();
            ListNode answer  = temp;

            while(head != null)
            {
                if(head.next ==null || (head.next != null && head.next.val != head.val))
                {
                    temp.next = new ListNode(head.val);
                    temp = temp.next;
                }
                while(head.next !=null && head.next.val == head.val)
                {
                    head = head.next;
                }

                head = head.next;

            }
            return answer.next;
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }
    }
}
